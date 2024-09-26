// axosimple
// Copyright (c)2024 Peter Kurhajec and Contributors All Rights Reserved.
// Contributors: https://github.com/PTKu/ix/graphs/contributors
// See the LICENSE file in the repository root for more information.
// https://github.com/PTKu/ix/blob/master/LICENSE
// Third party licenses: https://github.com/PTKu/ix/blob/master/notices.md

using AXOpen.Messaging.Static;
using axosimple.server.Units;
using AXSharp.Connector;

namespace axosimple.BaseUnit
{
    public abstract partial class UnitContainerBase : AXOpen.Core.AxoObject, axosimple.IUnit
    {
        /// <summary>
        /// Gets the data payload for the unit.
        /// </summary>
        public abstract AXOpen.Data.AxoDataEntity? Data { get; }

        /// <summary>
        /// Gets data header for the unit.
        /// </summary>
        public abstract AXOpen.Data.AxoDataEntity? DataHeader { get; }
        
        public abstract AXOpen.Data.AxoDataEntity? TechnologySettings { get; }

        public abstract AXOpen.Data.AxoDataEntity? SharedTechnologySettings { get; }

        public abstract AxoObject? UnitComponents { get; }
        
        public abstract AxoMessageProvider MessageProvider { get; }
    
        public abstract ITwinObject[] Associates { get; }
        
        public IUnitServices Services { get; internal set; } 
        
        public abstract AxoTask AutomatTask { get; }
        
        public abstract AxoTask GroundTask { get; }
        

        public abstract AxoTask ServiceTask { get; }
        
        public eAxoTaskState GroundStatus
        {
            get
            {
                try
                {
                    return (AXOpen.Core.eAxoTaskState)GroundTask?.Status.LastValue;
                }
                catch
                {
                    return eAxoTaskState.Disabled;
                }
            }
        }

        public eAxoTaskState AutomatStatus
        {
            get
            {
                try
                {
                    return (AXOpen.Core.eAxoTaskState)AutomatTask?.Status.LastValue;
                }
                catch
                {
                    return eAxoTaskState.Disabled;
                }
            }
        }

        public eAxoTaskState ServiceStatus
        {
            get
            {
                try
                {
                    return (AXOpen.Core.eAxoTaskState)ServiceTask?.Status.LastValue;
                }
                catch
                {
                    return eAxoTaskState.Disabled;
                }
            }
        }
    }
}