
NAMESPACE axosimple.UnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
    
    ///<summary>
    /// Provides automatic mode sequence.
    ///</summary>
    {#ix-set:AttributeName = "<#AUTOMAT#>"}
    {S7.extern=ReadWrite}
    CLASS PUBLIC AutomatSequence
        EXTENDS AXOpen.Core.AxoSequencerContainer
        IMPLEMENTS IModeContainer
        VAR PUBLIC
            Steps : ARRAY[0..150] OF AXOpen.Core.AxoStep;            
        END_VAR
        VAR PRIVATE
            Objs : axosimple.UnitTemplate.UnitObjects;        
            _currentId : STRING;
        END_VAR

        METHOD INTERNAL Run
            VAR_INPUT
                _parent :  AXOpen.Core.IAxoObject;
                _unitObjects : REF_TO axosimple.UnitTemplate.UnitObjects;
            END_VAR     
            
            SUPER.Run(_parent);
        END_METHOD
        ///<summary>
        /// Contains logic of the steps of this sequence
        ///</summary>

        METHOD OVERRIDE Main                        
            // This sequecner executes the steps in cycles from top to bottom
            // in the same order they are written in the program
            // Each step in the sequence must can be used only once.
            // This sets the sequence to run in cycles (top-botton-top and again).
            THIS.SequenceMode := eAxoSequenceMode#Cyclic;
            
            IF (Steps[0].Execute(THIS, TRUE, '<#GET ID#>')) THEN
                //-------------------------------------------------------
                _currentId := 'newProducedPart';
                THIS.MoveNext(); 
                //-------------------------------------------------------
            END_IF;

            IF (Steps[10].Execute(THIS, TRUE, '<#GET DATA#>')) THEN
                //-------------------------------------------------------
                // IF(ProcessSettingsManager^.Read('MODEL_S').IsDone()) THEN
                //     ProcessDataManager^.DataManger.Payload := ProcessSettingsManager^.Payload;
                //     THIS.MoveNext(); 
                // END_IF;    

                RETURN;

                IF (Objs.ProcessData.CreateOrUpdate(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;

                //-------------------------------------------------------
            END_IF;
            
            IF (Steps[20].Execute(THIS, TRUE, '<#DO SOMETHING#>')) THEN
                //-------------------------------------------------------   
                
                IF(Objs.ProcessData.DataManger.Payload.JigDataMatrixCode.Inspect(THIS, '').Done()) THEN
                    THIS.MoveNext();
                END_IF;                                  
                //-------------------------------------------------------
            END_IF;

            IF (Steps[30].Execute(THIS, TRUE, '<#DO SOMETHING#>')) THEN
                //-------------------------------------------------------                   
                IF(Objs.ProcessData.DataManger.Payload.PartPresence.Inspect(THIS, TRUE).Done()) THEN
                    THIS.MoveNext();
                END_IF;                                  
                //-------------------------------------------------------
            END_IF;

            IF (Steps[4].Execute(THIS, TRUE, '<#DO SOMETHING#>')) THEN
                //-------------------------------------------------------                   
                IF(Objs.ProcessData.DataManger.Payload.RivetingPreasure.Inspect(THIS, 1.5).Done()) THEN
                    THIS.MoveNext();
                END_IF;                                  
                //-------------------------------------------------------
            END_IF;

            IF (Steps[149].Execute(THIS, TRUE, '<#UPDATE DATA#>')) THEN
                //-------------------------------------------------------
                IF (Objs.ProcessData.Update(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;
                //-------------------------------------------------------
            END_IF;

            // This will close the sequence and will return to the first step.
            THIS.Close(Steps[150]);
        END_METHOD
    END_CLASS
END_NAMESPACE
    
