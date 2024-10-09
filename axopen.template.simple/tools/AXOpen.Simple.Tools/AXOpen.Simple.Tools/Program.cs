using Cocona;
using AXOpen.Simple.Tools.ControlledUnit;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {       
        var builder = CoconaApp.CreateBuilder();

        var app = builder.Build();

        app.AddCommands<ControlledUnit>();

        app.Run();
    }
}