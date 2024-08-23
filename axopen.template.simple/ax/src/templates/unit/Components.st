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
        END_VAR

        
        METHOD PUBLIC Update
            VAR_INPUT
                parent : IAxoObject;                
            END_VAR
            VAR_IN_OUT
                Inputs : axosimple.Inputs; // must be a ref_to due to arrays in components
                Outputs : axosimple.Outputs;
            END_VAR    
            THIS.Initialize(parent);
            
            THIS.Initialize(parent);
            // HERE INITIALIZE YOUR COMPONENTS
            ;
            
        END_METHOD
    END_CLASS
END_NAMESPACE    
