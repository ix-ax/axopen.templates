using System;

namespace Pocos
{
    namespace axosimple.MyUnit
    {
        public partial class ServiceMode : AXOpen.Core.AxoTask, AXSharp.Connector.IPlain, IModeContainer
        {
            public ServiceMode() : base()
            {
            }
        }
    }
}