using System;

namespace Pocos
{
    namespace axosimple.Cu10
    {
        public partial class ServiceMode : AXOpen.Core.AxoTask, AXSharp.Connector.IPlain, IModeContainer
        {
            public ServiceMode() : base()
            {
            }
        }
    }
}