using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class EntityHeaderDataManager : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public axosimple.EntityData Entity { get; set; } = new axosimple.EntityData();
        }
    }
}