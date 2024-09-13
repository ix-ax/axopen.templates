using System;

namespace Pocos
{
    namespace axosimple.MyUnit
    {
        public partial class TechnologyDataPayload : AXOpen.Data.AxoDataEntity, AXSharp.Connector.IPlain
        {
            public TechnologyDataPayload() : base()
            {
            }

            public axosimple.TechnologyUnitHeader Header { get; set; } = new axosimple.TechnologyUnitHeader();
        }
    }
}