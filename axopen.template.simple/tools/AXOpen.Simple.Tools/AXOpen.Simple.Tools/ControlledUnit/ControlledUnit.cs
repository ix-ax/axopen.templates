using AX.ST.Semantic.Analyzer;
using AX.ST.Semantic.Model.Declarations;
using AX.ST.Syntax.Parser;
using AXSharp.Compiler.Cs.Onliner;
using AXSharp.Compiler.Cs.Plain;
using AXSharp.Compiler;
using Cocona;
using System.Reflection;
using Microsoft.CodeAnalysis;
using System.Xml.Linq;
using AX.ST.Syntax.Tree;

namespace AXOpen.Simple.Tools.ControlledUnit
{
    public class ControlledUnit
    {
        [Command("cuadd")]
        public Task AddControlledUnit(  [Option('x',Description = "Simatic-ax project folder.")] string ProjectFolder,
                                        [Option('n',Description = "Name of the controlled unit to be added.")] string CuName,
                                        [Option('d',Description = "Fully qualified class, where the controlled unit should be declared. Must be of type AxoContext or AxoObject.")] string CuDeclarationLocation,
                                        [Option('p',Description = "Fully qualified class, where the process data of the controlled unit should be declared.")] string PdDeclarationLocation,
                                        [Option('t',Description = "Fully qualified class, where the technology data of the controlled unit should be declared.")] string TdDeclarationLocation)
        {
            var axProjectFolder = string.IsNullOrEmpty(ProjectFolder) ? Environment.CurrentDirectory : ProjectFolder;

            Environment.CurrentDirectory = GetFullPath(axProjectFolder);

            var ax = new AxProject(Environment.CurrentDirectory);

            var project = new AXSharpProject(ax, new[] { typeof(CsOnlinerSourceBuilder), typeof(CsPlainSourceBuilder) }, typeof(CsProject), null);

            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            var projectSources = project.AxProject.Sources.Select(p => (parseTree: STParser.ParseTextAsync(p).Result, source: p));

            project.TargetProject.LoadReferences();

            IEnumerable<ISyntaxTree> refParseTrees = new List<ISyntaxTree>();
            //refParseTrees = project.GetReferences();

            var toCompile = refParseTrees.Concat(projectSources.Select(p => p.parseTree));

            var compilationResult = AX.ST.Semantic.Compilation.Create(toCompile, new List<ISemanticAnalyzer>(), AX.ST.Semantic.Compilation.Settings.Default).Result;

            var semanticTree = compilationResult.Compilation.GetSemanticTree();

            IClassDeclaration? ControlledUnitDeclarationLocation = semanticTree.GetRoot().GetDescendentNodes().Where(p => p is IClassDeclaration)?.OfType<IClassDeclaration>().Where(p => p.FullyQualifiedName.Equals(CuDeclarationLocation)).FirstOrDefault();
            IClassDeclaration? ProcessDataDeclarationLocation = semanticTree.GetRoot().GetDescendentNodes().Where(p => p is IClassDeclaration)?.OfType<IClassDeclaration>().Where(p => p.FullyQualifiedName.Equals(PdDeclarationLocation)).FirstOrDefault();
            IClassDeclaration? TechnologyDataDeclarationLocation = semanticTree.GetRoot().GetDescendentNodes().Where(p => p is IClassDeclaration)?.OfType<IClassDeclaration>().Where(p => p.FullyQualifiedName.Equals(TdDeclarationLocation)).FirstOrDefault();
            IMethodDeclaration? ControlledUnitDeclarationLocationMain = ControlledUnitDeclarationLocation?.ChildNodes.Where(f => f is IMethodDeclaration).Where(f => ((IDeclaration)f).Name.Equals("Main")).FirstOrDefault() as IMethodDeclaration;


            // Check existence of the class where the controlled unit should be declared
            if (ControlledUnitDeclarationLocation == null)
            {
                Console.WriteLine(@"Required class {0} where controlled unit {1} should be declared does not exists.", CuDeclarationLocation, CuName);
                return Task.FromCanceled(new CancellationToken());
            }
            // Check existence of the Main method inside the class where the controlled unit should be declared
            if (ControlledUnitDeclarationLocationMain == null)
            {
                Console.WriteLine(@"Required class {0} where controlled unit {1} should be declared does not contains method 'Main()'.", CuDeclarationLocation, CuName);
                return Task.FromCanceled(new CancellationToken());
            }
            // Check if the controlled unit is already declared
            if (ControlledUnitDeclarationLocation.Fields.Where(f => f.Name.Equals(CuName)).Count() > 0)
            {
                Console.WriteLine(@"Required controlled unit {0} is already declared in the class {1}", CuName, ControlledUnitDeclarationLocation.FullyQualifiedName);
                return Task.FromCanceled(new CancellationToken());
            }
            // Check existence of the class where the process data of the controlled unit should be declared
            if (ProcessDataDeclarationLocation == null)
            {
                Console.WriteLine(@"Required class {0} where the process data of the controlled unit {1} should be declared does not exists.", PdDeclarationLocation, CuName);
                return Task.FromCanceled(new CancellationToken());
            }
            // Check if the process data of the controlled unit is already declared
            if (ProcessDataDeclarationLocation.Fields.Where(f => f.Name.Equals(CuName)).Count() > 0)
            {
                Console.WriteLine(@"Process data of the controlled unit {0} is already declared in the class {1}", CuName, ProcessDataDeclarationLocation.FullyQualifiedName);
                return Task.FromCanceled(new CancellationToken());
            }
            // Check existence of the class where the technology data of the controlled unit should be declared
            if (TechnologyDataDeclarationLocation == null)
            {
                Console.WriteLine(@"Required class {0} where the technology data of the controlled unit {1} should be declared does not exists.", TdDeclarationLocation, CuName);
                return Task.FromCanceled(new CancellationToken());
            }
            // Check if the technology data of the controlled unit is already declared
            if (TechnologyDataDeclarationLocation.Fields.Where(f => f.Name.Equals(CuName)).Count() > 0)
            {
                Console.WriteLine(@"Technology data of the controlled unit {0} is already declared in the class {1}", CuName, TechnologyDataDeclarationLocation.FullyQualifiedName);
                return Task.FromCanceled(new CancellationToken());
            }

            AX.Text.FileLinePositionSpan ControlledUnitSpan = ControlledUnitDeclarationLocation.Fields.LastOrDefault().Location.GetLineSpan();
            string ControlledUnitDeclarationFileName = ControlledUnitSpan.Filename;
            int ControlledUnitDeclarationLine = ControlledUnitSpan.Span.Start.Line;
            int ControlledUnitDeclarationCharacter = ControlledUnitSpan.Span.Start.Character;
            AX.Text.FileLinePositionSpan ControlledUnitDeclarationLocationMainSpan = ControlledUnitDeclarationLocationMain.Location.GetLineSpan();
            int ControlledUnitDeclarationLocationMainLine = ControlledUnitDeclarationLocationMainSpan.Span.End.Line;
            int ControlledUnitDeclarationLocationMainCharacter = ControlledUnitDeclarationLocationMainSpan.Span.Start.Character + 4;

            List<string> lines = new List<string>();

            try
            {
                // Read the file line by line
                using (StreamReader sr = new StreamReader(ControlledUnitDeclarationFileName))
                {
                    string line;
                    int currentLine = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                        currentLine++;

                        if (currentLine == ControlledUnitDeclarationLine + 1)
                        {
                            string declarationShift = string.Empty;
                            for (int i = 0; i < ControlledUnitDeclarationCharacter; i++)
                            {
                                declarationShift = declarationShift + " ";
                            }
                            lines.Add(declarationShift + "{#ix-set:AttributeName = \"<#" + CuName + "#>\"}");
                            lines.Add(declarationShift + CuName + ": " + ControlledUnitDeclarationLocation.ContainingNamespace.Name + "." + CuName + ".UnitContainer;");
                        }

                        if (currentLine == ControlledUnitDeclarationLocationMainLine)
                        {
                            string entryCallShift = string.Empty;
                            for (int i = 0; i < ControlledUnitDeclarationLocationMainCharacter; i++)
                            {
                                entryCallShift = entryCallShift + " ";
                            }
                            lines.Add(entryCallShift + CuName + ".Run(THIS, Inputs ^, Outputs ^, REF(Glob));");
                        }
                    }
                }

                // Overwrite the file with updated content
                using (StreamWriter se = new StreamWriter(ControlledUnitDeclarationFileName))
                {
                    foreach (string line in lines)
                    {
                        se.WriteLine(line);
                    }
                }

                Console.WriteLine(@"File {0} updated successfully.", ControlledUnitDeclarationFileName);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }


            AX.Text.FileLinePositionSpan ProcessDataSpan = ProcessDataDeclarationLocation.Fields.LastOrDefault().Location.GetLineSpan();
            string ProcessDataDeclarationFileName = ProcessDataSpan.Filename;
            int ProcessDataDeclarationLine = ProcessDataSpan.Span.Start.Line;
            int ProcessDataDeclarationCharacter = ProcessDataSpan.Span.Start.Character;

            lines = new List<string>();

            try
            {
                // Read the file line by line
                using (StreamReader sr = new StreamReader(ProcessDataDeclarationFileName))
                {
                    string line;
                    int currentLine = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                        currentLine++;

                        if (currentLine == ProcessDataDeclarationLine + 1)
                        {
                            string declarationShift = string.Empty;
                            for (int i = 0; i < ProcessDataDeclarationCharacter; i++)
                            {
                                declarationShift = declarationShift + " ";
                            }
                            lines.Add(declarationShift + "{#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}");
                            lines.Add(declarationShift + CuName + ": " + ProcessDataDeclarationLocation.ContainingNamespace.Name + "." + CuName + ".ProcessDataExchange;");
                        }
                    }
                }

                // Overwrite the file with updated content
                using (StreamWriter se = new StreamWriter(ProcessDataDeclarationFileName))
                {
                    foreach (string line in lines)
                    {
                        se.WriteLine(line);
                    }
                }

                Console.WriteLine(@"File {0} updated successfully.", ProcessDataDeclarationFileName);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            AX.Text.FileLinePositionSpan TechnologyDataSpan = TechnologyDataDeclarationLocation.Fields.LastOrDefault().Location.GetLineSpan();
            string TechnologyDataDeclarationFileName = TechnologyDataSpan.Filename;
            int TechnologyDataDeclarationLine = TechnologyDataSpan.Span.Start.Line;
            int TechnologyDataDeclarationCharacter = TechnologyDataSpan.Span.Start.Character;

            lines = new List<string>();

            try
            {
                // Read the file line by line
                using (StreamReader sr = new StreamReader(TechnologyDataDeclarationFileName))
                {
                    string line;
                    int currentLine = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                        currentLine++;

                        if (currentLine == TechnologyDataDeclarationLine + 1)
                        {
                            string declarationShift = string.Empty;
                            for (int i = 0; i < TechnologyDataDeclarationCharacter; i++)
                            {
                                declarationShift = declarationShift + " ";
                            }
                            lines.Add(declarationShift + "{#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}");
                            lines.Add(declarationShift + CuName + ": " + TechnologyDataDeclarationLocation.ContainingNamespace.Name + "." + CuName + ".TechnologyDataExchange;");
                        }
                    }
                }

                // Overwrite the file with updated content
                using (StreamWriter se = new StreamWriter(TechnologyDataDeclarationFileName))
                {
                    foreach (string line in lines)
                    {
                        se.WriteLine(line);
                    }
                }

                Console.WriteLine(@"File {0} updated successfully.", TechnologyDataDeclarationFileName);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }



            sw.Stop();
            Log.Logger.Information($"Done in {TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds)}");
            return Task.CompletedTask;
        }


        private static string GetFullPath(string path)
        {
            if (Path.IsPathRooted(path))
            {
                Console.WriteLine("Path si rooted.");
                return path;
            }
            else
            {
                var fullPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, path));
                Console.WriteLine($"Path si relative '{fullPath}'.");
                return fullPath;
            }
        }
    }
}
