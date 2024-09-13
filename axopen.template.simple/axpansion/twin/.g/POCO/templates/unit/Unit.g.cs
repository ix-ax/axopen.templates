using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class Unit : axosimple.BaseUnit.UnitBase, AXSharp.Connector.IPlain
        {
            public Unit() : base()
            {
            }

            public axosimple.UnitTemplate.UnitObjects X { get; set; } = new axosimple.UnitTemplate.UnitObjects();
            public axosimple.UnitTemplate.GroundSequence Ground { get; set; } = new axosimple.UnitTemplate.GroundSequence();
            public axosimple.UnitTemplate.AutomatSequence Auto { get; set; } = new axosimple.UnitTemplate.AutomatSequence();
            public axosimple.UnitTemplate.ServiceMode Service { get; set; } = new axosimple.UnitTemplate.ServiceMode();
        }
    }
}