using System;

namespace Pocos
{
    namespace axosimple.BaseUnit
    {
        public partial class UnitBase : AXSharp.Connector.IPlain
        {
            public UnitBase()
            {
            }

            public Int16 StationNumber { get; set; }

            public string LastTechnologySettings { get; set; } = string.Empty;
        }
    }
}