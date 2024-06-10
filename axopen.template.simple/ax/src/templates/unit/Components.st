NAMESPACE axosimple.UnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;

    ///<summary>
    /// Groups components of this controller unit.
    ///</summary>
    {S7.extern=ReadWrite}
    CLASS Components
        EXTENDS AXOpen.Core.AxoObject
        VAR PUBLIC
            // HERE DECLARE COMPONENTS USED BY THIS CONTROLLED UNIT    
            HorizontalCylinder : AXOpen.Components.Pneumatics.AxoCylinder;    
            VerticalCylinder : AXOpen.Components.Pneumatics.AxoCylinder;       
            GripperCylinder : AXOpen.Components.Pneumatics.AxoCylinder;       
        END_VAR

        
        METHOD PUBLIC Update
            VAR_INPUT
                parent : IAxoObject;
                Inputs : ref_to axosimple.Inputs; // must be a ref_to due to arrays in components
                Outputs : ref_to axosimple.Outputs;
            END_VAR
            THIS.Initialize(parent);
            
            THIS.Initialize(parent);
            // HERE INITIALIZE YOUR COMPONENTS
            HorizontalCylinder.Run(THIS, Inputs^.P0[0], Inputs^.P0[1], Outputs^.P0[0], Outputs^.P0[1]);
            VerticalCylinder.Run(THIS, Inputs^.P0[2], Inputs^.P0[3], Outputs^.P0[2], Outputs^.P0[3]);       
            GripperCylinder.Run(THIS, Inputs^.P0[4], Inputs^.P0[5], Outputs^.P0[4], Outputs^.P0[5]);       
            
        END_METHOD
    END_CLASS
END_NAMESPACE    
