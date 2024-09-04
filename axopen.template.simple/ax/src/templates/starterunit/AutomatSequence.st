
NAMESPACE axosimple.StarterUnitTemplate
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
        EXTENDS AXOpen.Core.AxoSequencerContainer IMPLEMENTS IModeContainer
        VAR PUBLIC
            Steps : ARRAY[0..100] OF AxoStep;    
    
            _inspectionResult: BOOL;
            _inspectionValue: LREAL;
            _inspectionData: STRING;
    
            _comprehensiveResult: AXOpen.Inspectors.AxoComprehensiveResult;
        END_VAR

        VAR PRIVATE
            Objs : REF_TO axosimple.StarterUnitTemplate.UnitObjects;
           
            _currentId : STRING;

            _dialogAnswer : eDialogAnswer;
            _externalCloseOkSignal : BOOL;
            resutl : IAxoTaskState;
        END_VAR

        METHOD INTERNAL Run
            VAR_INPUT
                inParent : AXOpen.Core.IAxoObject;
                inUnitObjects : REF_TO UnitObjects;
            END_VAR     

            IF Objs = NULL THEN 
                Objs := inUnitObjects;                                             
            END_IF;

            resutl := Objs^.ProcessData.DataManger.CreateOrUpdate('fasdfa');  

            // Result is null!
            resutl.IsDone();

            SUPER.Run(inParent);
        END_METHOD
        ///<summary>
        /// Contains logic of the steps of this sequence
        ///</summary>

        VAR           
            _isDone : BOOL;
        END_VAR        
        METHOD OVERRIDE Main
            VAR
                forIterator : INT := 0;  
                dialogTimeOut : TIME:= t#3000ms;         
            END_VAR


            


            IF (Objs = NULL) THEN
                RETURN;
            END_IF;
            // This sequecner executes the steps in cycles from top to bottom
            // in the same order they are written in the program
            // Each step in the sequence must can be used only once.
            // This sets the sequence to run in cycles (top-botton-top and again).
            THIS.SequenceMode := eAxoSequenceMode#Cyclic;

            
            IF (Steps[0].Execute(THIS, TRUE, '<#GET ID#>')) THEN
                //-------------------------------------------------------
                Objs^._inspectorDialog.Restore();  

                // copy data from setting to station data -> it's a problem with override checks identity
                //ProcessData^ :=  ProcessSettings^;

                Objs^.ProcessData.DataManger.Payload.PartPresence.Data()^.FailTime := TIME#3s;
                Objs^.ProcessData.DataManger.Payload.LoadPosition.Data()^.FailTime := TIME#3s;
                Objs^.ProcessData.DataManger.Payload.JigDataMatrixCode.Data()^.FailTime := TIME#3s;
    
                Objs^.ProcessData.DataManger.Payload.PartPresence.Data()^.PassTime := TIME#2.5s;
                Objs^.ProcessData.DataManger.Payload.LoadPosition.Data()^.PassTime := TIME#2s;
                Objs^.ProcessData.DataManger.Payload.JigDataMatrixCode.Data()^.PassTime := TIME#2s;

                Objs^.ProcessData.DataManger.Payload.PartPresence.Data()^.RequiredStatus := TRUE;
                Objs^.ProcessData.DataManger.Payload.LoadPosition.Data()^.RequiredMin := 1000.0;
                Objs^.ProcessData.DataManger.Payload.LoadPosition.Data()^.RequiredMax := 2000.0;
                Objs^.ProcessData.DataManger.Payload.JigDataMatrixCode.Data()^.RequiredStatus := 'passCode';

                _currentId := 'newProducedPart';
                THIS.MoveNext(); 
                //-------------------------------------------------------
            END_IF;

            IF (Steps[1].Execute(THIS, TRUE, '<#GET DATA#>')) THEN
                //-------------------------------------------------------
                
                resutl := Objs^.ProcessData.DataManger.CreateOrUpdate('fasdfa');  
                //resutl.IsDone();                 
                RETURN;    
                
                IF (Objs^.ProcessData.DataManger.CreateOrUpdate(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;
                //-------------------------------------------------------
            END_IF;
            
           
            
            IF (Steps[2].Execute(THIS, TRUE, '<#Dialog notify#>')) THEN
                //-------------------------------------------------------
                _externalCloseOkSignal := CurrentStep.Duration > dialogTimeOut;
                
                _dialogAnswer := Objs^._dialog.ShowWithExternalClose(THIS, _externalCloseOkSignal)
                .WithOK()
                .WithType(eDialogType#Info)
                .WithCaption('Info caption!')
                .WithText('Info - dialog will be closed by external timeout 2s!').Answer();
                    
                IF( _dialogAnswer = eDialogAnswer#Ok) THEN
                    THIS.MoveNext();
                END_IF;
                //-------------------------------------------------------
            END_IF;

                         
            IF (Steps[3].Execute(THIS, TRUE, '<#Dialog success#>')) THEN
                //-------------------------------------------------------
                _externalCloseOkSignal := CurrentStep.Duration > dialogTimeOut;

                    _dialogAnswer := Objs^._dialog.ShowWithExternalClose(THIS, _externalCloseOkSignal)
                    .WithOK()
                    .WithType(eDialogType#Success)
                    .WithCaption('Success caption!')
                    .WithText('Success - dialog will be closed by external timeout 2s!').Answer();
                    
                    IF( _dialogAnswer = eDialogAnswer#Ok) THEN
                        THIS.MoveNext();
                    END_IF;
                //-------------------------------------------------------
            END_IF;

            IF (Steps[4].Execute(THIS, TRUE, '<#Dialog Warning#>')) THEN
                //-------------------------------------------------------
                _externalCloseOkSignal := CurrentStep.Duration > dialogTimeOut;

                    _dialogAnswer := Objs^._dialog.ShowWithExternalClose(THIS, _externalCloseOkSignal)
                    .WithYesNo()
                    .WithType(eDialogType#Warning)
                    .WithCaption('Warning caption!')
                    .WithText('Warning - dialog will be closed by external timeout 2s!').Answer();
                    
                    IF( _dialogAnswer = eDialogAnswer#Ok) THEN
                        THIS.MoveNext();
                    END_IF;
                //-------------------------------------------------------
            END_IF;

            IF (Steps[5].Execute(THIS, TRUE, '<#Dialog danger#>')) THEN
                //-------------------------------------------------------
                _externalCloseOkSignal := CurrentStep.Duration > dialogTimeOut;

                    _dialogAnswer := Objs^._dialog.ShowWithExternalClose(THIS, _externalCloseOkSignal)
                    .WithYesNoCancel()
                    .WithType(eDialogType#Warning)
                    .WithCaption('Danger caption!')
                    .WithText('Danger - dialog will be closed by external timeout 2s!').Answer();
                    
                    IF( _dialogAnswer = eDialogAnswer#Ok) THEN
                        THIS.MoveNext();
                    END_IF;
                //-------------------------------------------------------
            END_IF;

            IF (Steps[6].Execute(THIS, TRUE, 'Example Digital inspection')) THEN
                //-------------------------------------------------------
                Objs^.ProcessData.DataManger.Payload.PartPresence.WithCoordinator(THIS).Inspect(THIS,_inspectionResult)
                .UpdateComprehensiveResult(_comprehensiveResult)
                .OnFail()
                .CarryOn();
                //-------------------------------------------------------
            END_IF;

            IF (Steps[7].Execute(THIS, TRUE, 'Example Analog inspection')) THEN         
                //-------------------------------------------------------
                _inspectionValue := -5500;

                Objs^.ProcessData.DataManger.Payload.LoadPosition.WithCoordinator(THIS)
                .Inspect(THIS,_inspectionValue)
                .UpdateComprehensiveResult(_comprehensiveResult)
                .OnFail()
                .Dialog( inRetryStep := Steps[50], inTerminateStep := Steps[60], inoDialog := Objs^._inspectorDialog);
                //-------------------------------------------------------
            END_IF;
            
            IF (Steps[8].Execute(THIS, TRUE, 'Example Data inspection')) THEN
                //-------------------------------------------------------
                _inspectionData := 'tempCode';

                Objs^.ProcessData.DataManger.Payload.JigDataMatrixCode.WithCoordinator(THIS)
                .Inspect(THIS,_inspectionData)
                .UpdateComprehensiveResult(_comprehensiveResult)
                .OnFail()
                .Dialog( inRetryStep := Steps[70], inTerminateStep := Steps[80], inoDialog := Objs^._inspectorDialog);
                //-------------------------------------------------------
            END_IF;

            
            FOR forIterator := 10 TO 89 BY 1 DO
                IF (Steps[forIterator].Execute(THIS, TRUE,Concat('DO SOMETHING -A-',ToString(forIterator)) )) THEN
                    //-------------------------------------------------------                
                    IF CurrentStep.Duration > TIME#50ms THEN                         
                        THIS.MoveNext();
                    END_IF;                
                    //-------------------------------------------------------
                END_IF;
            END_FOR;




            IF (Steps[99].Execute(THIS, TRUE,'<#UPDATE DATA#>')) THEN
                //-------------------------------------------------------
                IF (Objs^.ProcessData.DataManger.Update(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;
                //-------------------------------------------------------
            END_IF;  
         
                      
            // This will close the sequence and will return to the first step.
            THIS.Close(Steps[100]);
        END_METHOD
    END_CLASS

END_NAMESPACE
    
