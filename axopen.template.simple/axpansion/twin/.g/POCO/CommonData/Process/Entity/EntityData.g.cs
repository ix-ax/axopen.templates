using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class EntityData : AXOpen.Data.AxoDataEntity, AXSharp.Connector.IPlain
        {
            public Int16 LastStation { get; set; }

            public Int16 NextStation { get; set; }

            public Int16 OpenOn { get; set; }

            public AXOpen.Inspectors.AxoComprehensiveResult Results { get; set; } = new AXOpen.Inspectors.AxoComprehensiveResult();
            public string Carrier { get; set; } = string.Empty;
            public Boolean IsEmpty { get; set; }

            public Boolean IsMaster { get; set; }

            public Boolean WasReset { get; set; }
        }
    }
}