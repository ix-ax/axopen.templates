
NAMESPACE axosimple.StarterUnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
    
    ///<summary>
    /// Provides automatic mode sequence for `StarterUnitTemplate` unit.
    ///</summary>
    {#ix-set:AttributeName = "<#AUTOMAT#>"}
    {S7.extern=ReadWrite}
    CLASS PUBLIC AutomatSequence
        EXTENDS AXOpen.Core.AxoSequencerContainer IMPLEMENTS IModeContainer
        VAR PUBLIC
            ///<summary>
            /// Step coordinators for this sequence.            
            ///</summary>
            Steps : ARRAY[0..100] OF AxoStep;                   
        END_VAR

        VAR PRIVATE
            X : REF_TO axosimple.StarterUnitTemplate.UnitObjects;
           
            _currentId : STRING;

            _dialogAnswer : eDialogAnswer;
            _externalCloseOkSignal : BOOL;
        END_VAR

        METHOD INTERNAL Run
            VAR_INPUT
                inParent : AXOpen.Core.IAxoObject;
                inUnitObjects : REF_TO UnitObjects;
            END_VAR     

            IF X = NULL THEN 
                X := inUnitObjects;                                             
            END_IF;

            SUPER.Run(inParent);
        END_METHOD
                
        VAR
            resutl : IAxoTaskState;
            _isDone : BOOL;
        END_VAR       
        
        
        
        METHOD PROTECTED OVERRIDE OnBeforeSequenceStart
            X^._IDL.Restore(); 
            X^.PD.Restore();
            X^.TD.Restore(); 
        END_METHOD

        ///<summary>
        ///     Contains logic of the steps of this sequence
        ///</summary>
        METHOD OVERRIDE Main
            
            IF (X = NULL) THEN
                RETURN;
            END_IF;

            // This sequecner executes the steps in cycles from top to bottom
            // in the same order they are written in the program
            // Each step in the sequence must can be used only once.
            // This sets the sequence to run in cycles (top-botton-top and again).
            THIS.SequenceMode := eAxoSequenceMode#Cyclic;

            
            IF (Steps[0].Execute(THIS, TRUE, '<#LOAD TECHNOLOGY DATA#>')) THEN
                //-------------------------------------------------------               
                    IF(X^.TD.Read('default').IsDone()) THEN                        
                        THIS.MoveNext(); 
                    END_IF;    
                //-------------------------------------------------------
            END_IF;

            IF (Steps[1].Execute(THIS, TRUE, '<#LOAD PROCESS DATA#>')) THEN
                //-------------------------------------------------------                                   
                    IF(X^.PD.Read('').IsDone()) THEN                        
                        THIS.MoveNext(); 
                    END_IF;    
                //-------------------------------------------------------
            END_IF;

            IF (Steps[90].Execute(THIS, TRUE, '<#SAVE DATA#>')) THEN
                //-------------------------------------------------------                                                 
                IF (X^.PD.Data.CreateOrUpdate(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;
                //-------------------------------------------------------
            END_IF;
                                                              
                                           
            // This will close the sequence and will return to the first step.
            THIS.Close(Steps[100]);
        END_METHOD
    END_CLASS

END_NAMESPACE
    
