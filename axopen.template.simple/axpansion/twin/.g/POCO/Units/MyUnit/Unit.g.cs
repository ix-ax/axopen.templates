using System;

namespace Pocos
{
    namespace axosimple.MyUnit
    {
        public partial class Unit : axosimple.BaseUnit.UnitBase, AXSharp.Connector.IPlain
        {
            public Unit() : base()
            {
            }

            public axosimple.MyUnit.UnitObjects X { get; set; } = new axosimple.MyUnit.UnitObjects();
            public axosimple.MyUnit.GroundSequence Ground { get; set; } = new axosimple.MyUnit.GroundSequence();
            public axosimple.MyUnit.AutomatSequence Auto { get; set; } = new axosimple.MyUnit.AutomatSequence();
            public axosimple.MyUnit.ServiceMode Service { get; set; } = new axosimple.MyUnit.ServiceMode();
        }
    }
}