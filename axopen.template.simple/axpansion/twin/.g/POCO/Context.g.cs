using System;
using Pocos.AXOpen.Core;
using Pocos.AXOpen.Data;

namespace Pocos
{
    namespace axosimple
    {
        public partial class Context : AXOpen.Core.AxoContext, AXSharp.Connector.IPlain
        {
            public Context() : base()
            {
            }

            public axosimple.GlobalContextObjects Glob { get; set; } = new axosimple.GlobalContextObjects();
            public axosimple.TechnologySafety Safety { get; set; } = new axosimple.TechnologySafety();
            public axosimple.Cu10.Unit Cu10 { get; set; } = new axosimple.Cu10.Unit();
        }
    }
}