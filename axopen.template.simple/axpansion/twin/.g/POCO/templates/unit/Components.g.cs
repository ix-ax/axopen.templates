using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class Components : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain
        {
            public AXOpen.Elements.AxoDi DI_1 { get; set; } = new AXOpen.Elements.AxoDi();
            public AXOpen.Elements.AxoDi DI_2 { get; set; } = new AXOpen.Elements.AxoDi();
            public AXOpen.Elements.AxoDo DO_1 { get; set; } = new AXOpen.Elements.AxoDo();
            public AXOpen.Elements.AxoDo DO_2 { get; set; } = new AXOpen.Elements.AxoDo();
            public AXOpen.Elements.AxoAi AI_1 { get; set; } = new AXOpen.Elements.AxoAi();
            public AXOpen.Elements.AxoAi AI_2 { get; set; } = new AXOpen.Elements.AxoAi();
            public AXOpen.Elements.AxoAo AO_1 { get; set; } = new AXOpen.Elements.AxoAo();
            public AXOpen.Elements.AxoAo AO_2 { get; set; } = new AXOpen.Elements.AxoAo();
            public AXOpen.Components.Pneumatics.AxoCylinder Cylinder_1 { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
            public AXOpen.Components.Pneumatics.AxoCylinder Cylinder_2 { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
        }
    }
}