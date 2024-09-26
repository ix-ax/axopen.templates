using System;

namespace Pocos
{
    namespace axosimple.BaseUnit
    {
        public partial class UnitContainerBase : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain, axosimple.IUnit
        {
            public UnitContainerBase() : base()
            {
            }
        }
    }
}