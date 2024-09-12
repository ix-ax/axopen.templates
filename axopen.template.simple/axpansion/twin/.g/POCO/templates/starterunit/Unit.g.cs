using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class Unit : axosimple.BaseUnit.UnitBase, AXSharp.Connector.IPlain
        {
            public Unit() : base()
            {
            }

            public axosimple.StarterUnitTemplate.UnitObjects X { get; set; } = new axosimple.StarterUnitTemplate.UnitObjects();
            public axosimple.StarterUnitTemplate.GroundSequence Ground { get; set; } = new axosimple.StarterUnitTemplate.GroundSequence();
            public axosimple.StarterUnitTemplate.AutomatSequence Auto { get; set; } = new axosimple.StarterUnitTemplate.AutomatSequence();
            public axosimple.StarterUnitTemplate.ServiceMode Service { get; set; } = new axosimple.StarterUnitTemplate.ServiceMode();
        }
    }
}