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
            public AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoDataman Reader_1 { get; set; } = new AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoDataman();
            public AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoDataman Reader_2 { get; set; } = new AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoDataman();
            public AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoInsight Camera_1 { get; set; } = new AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoInsight();
            public AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoInsight Camera_2 { get; set; } = new AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoInsight();
            public AXOpen.Components.Rexroth.Drives.AxoIndraDrive Drive_R1 { get; set; } = new AXOpen.Components.Rexroth.Drives.AxoIndraDrive();
            public AXOpen.Components.Rexroth.Drives.AxoIndraDrive Drive_R2 { get; set; } = new AXOpen.Components.Rexroth.Drives.AxoIndraDrive();
            public AXOpen.Components.Festo.Drives.AxoCmmtAs Drive_F1 { get; set; } = new AXOpen.Components.Festo.Drives.AxoCmmtAs();
            public AXOpen.Components.Festo.Drives.AxoCmmtAs Drive_F2 { get; set; } = new AXOpen.Components.Festo.Drives.AxoCmmtAs();
            public Boolean _enable { get; set; }

            public Boolean _enablePositive { get; set; }

            public Boolean _enableNegative { get; set; }

            public AXOpen.Components.Abb.Robotics.AxoIrc5_v_1_x_x Robot_A1 { get; set; } = new AXOpen.Components.Abb.Robotics.AxoIrc5_v_1_x_x();
            public AXOpen.Components.Abb.Robotics.AxoOmnicore_v_1_x_x Robot_A2 { get; set; } = new AXOpen.Components.Abb.Robotics.AxoOmnicore_v_1_x_x();
        }
    }
}