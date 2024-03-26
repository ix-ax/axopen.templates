using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class Unit : axosimple.BaseUnit.UnitBase, AXSharp.Connector.IPlain
        {
            public axosimple.UnitTemplate.UnitObjects UnitObjects { get; set; } = new axosimple.UnitTemplate.UnitObjects();
            public axosimple.UnitTemplate.GroundSequence GroundSequence { get; set; } = new axosimple.UnitTemplate.GroundSequence();
            public axosimple.UnitTemplate.AutomatSequence AutomatSequence { get; set; } = new axosimple.UnitTemplate.AutomatSequence();
            public axosimple.UnitTemplate.ServiceMode ServiceMode { get; set; } = new axosimple.UnitTemplate.ServiceMode();
        }
    }
}