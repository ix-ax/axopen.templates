using System;

namespace Pocos
{
    namespace axosimple.BaseUnit
    {
        public partial class UnitObjects : AXSharp.Connector.IPlain
        {
            public Int16 StationNumber { get; set; }

            public string LastTechnologySettings { get; set; } = string.Empty;
        }
    }
}