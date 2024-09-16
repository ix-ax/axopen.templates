using System;

namespace Pocos
{
    namespace axosimple.Cu10
    {
        public partial class Unit : axosimple.BaseUnit.UnitBase, AXSharp.Connector.IPlain
        {
            public Unit() : base()
            {
            }

            public axosimple.Cu10.UnitObjects X { get; set; } = new axosimple.Cu10.UnitObjects();
            public axosimple.Cu10.GroundSequence Ground { get; set; } = new axosimple.Cu10.GroundSequence();
            public axosimple.Cu10.AutomatSequence Auto { get; set; } = new axosimple.Cu10.AutomatSequence();
            public axosimple.Cu10.ServiceMode Service { get; set; } = new axosimple.Cu10.ServiceMode();
        }
    }
}