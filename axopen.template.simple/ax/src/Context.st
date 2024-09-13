USING AXOpen.Core;
USING AXOpen.Data;

NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS PUBLIC Context EXTENDS AXOpen.Core.AxoContext                   
        VAR PUBLIC          
            Glob : GlobalContextObjects;            
            Inputs : REF_TO axosimple.Inputs;
            Outputs : REF_TO axosimple.Outputs; 
            Safety : TechnologySafety;

            // Units snippet unitDeclaration
                                   
                                                            
        END_VAR      
            
        METHOD PROTECTED OVERRIDE Main    
            Safety.Run(THIS);                    
            Glob.Run(THIS);

            IF(Inputs = NULL || Outputs = NULL) THEN
                RETURN;
            END_IF;                                                                   
            
            // Unit entry call unitEntryCall
            
        END_METHOD        
    END_CLASS   
             
   
   
END_NAMESPACE

