using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class Outputs
        {
            public Boolean[] P0 { get; set; } = new Boolean[8];
            public Boolean[] P1 { get; set; } = new Boolean[8];
            public Int32[] A0 { get; set; } = new Int32[8];
            public Int32[] A1 { get; set; } = new Int32[8];
            public Boolean[] D0 { get; set; } = new Boolean[8];
            public Boolean[] D1 { get; set; } = new Boolean[8];
        }
    }
}