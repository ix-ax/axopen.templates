using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class Unit : axosimple.BaseUnit.UnitBase, AXSharp.Connector.IPlain
        {
            public axosimple.StarterUnitTemplate.UnitObjects UnitObjects { get; set; } = new axosimple.StarterUnitTemplate.UnitObjects();
            public axosimple.StarterUnitTemplate.GroundSequence GroundSequence { get; set; } = new axosimple.StarterUnitTemplate.GroundSequence();
            public axosimple.StarterUnitTemplate.AutomatSequence AutomatSequence { get; set; } = new axosimple.StarterUnitTemplate.AutomatSequence();
            public axosimple.StarterUnitTemplate.ServiceMode ServiceMode { get; set; } = new axosimple.StarterUnitTemplate.ServiceMode();
        }
    }
}