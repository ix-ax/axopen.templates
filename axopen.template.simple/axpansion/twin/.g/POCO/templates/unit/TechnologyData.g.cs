using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class TechnologyData : AXOpen.Data.AxoDataEntity, AXSharp.Connector.IPlain
        {
            public axosimple.TechnologyUnitHeader Header { get; set; } = new axosimple.TechnologyUnitHeader();
            public Single HeatingTemperature { get; set; }
        }
    }
}