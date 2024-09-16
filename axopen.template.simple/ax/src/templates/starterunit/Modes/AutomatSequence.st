
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
    
            _inspectionResult: BOOL;
            _inspectionValue: LREAL;
            _inspectionData: STRING;
    
            _comprehensiveResult: AXOpen.Inspectors.AxoComprehensiveResult;
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
            X^._inspectorDialog.Restore(); 
            X^.PD.Restore();
            X^.TD.Restore(); 
        END_METHOD

        ///<summary>
        ///     Contains logic of the steps of this sequence
        ///</summary>
        METHOD OVERRIDE Main
            VAR                
                
            END_VAR

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
                    IF(X^.PD.Read('default').IsDone()) THEN                        
                        _currentId := ToString(THIS.GetContext().GetRtc().NowUTC());
                        THIS.MoveNext(); 
                    END_IF;    
                //-------------------------------------------------------
            END_IF;

            IF (Steps[2].Execute(THIS, TRUE, CONCAT('CREATE ITEM: ',_currentId))) THEN
                //-------------------------------------------------------

                IF (X^.PD.CreateOrUpdate(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;
                //-------------------------------------------------------
            END_IF;
            
            IF (Steps[3].Execute(THIS, TRUE, '<#Dialog notify#>')) THEN
                //-------------------------------------------------------
                //_externalCloseOkSignal := CurrentStep.Duration > dialogTimeOut;
                
                _dialogAnswer := X^._dialog.ShowWithExternalClose(THIS, _externalCloseOkSignal)
                .WithOK()
                .WithType(eDialogType#Info)
                .WithCaption('Info caption!')
                .WithText('Info - dialog will be closed by external timeout 2s!').Answer();
                    
                IF( _dialogAnswer = eDialogAnswer#Ok) THEN
                    THIS.MoveNext();
                END_IF;
                //-------------------------------------------------------
            END_IF;

                         
            IF (Steps[4].Execute(THIS, TRUE, '<#Dialog success#>')) THEN
                //-------------------------------------------------------
                //_externalCloseOkSignal := CurrentStep.Duration > dialogTimeOut;

                    _dialogAnswer := X^._dialog.ShowWithExternalClose(THIS, _externalCloseOkSignal)
                    .WithOK()
                    .WithType(eDialogType#Success)
                    .WithCaption('Success caption!')
                    .WithText('Success - dialog will be closed by external timeout 2s!').Answer();
                    
                    IF( _dialogAnswer = eDialogAnswer#Ok) THEN
                        THIS.MoveNext();
                    END_IF;
                //-------------------------------------------------------
            END_IF;

            IF (Steps[5].Execute(THIS, TRUE, '<#Dialog Warning#>')) THEN
                //-------------------------------------------------------
                //_externalCloseOkSignal := CurrentStep.Duration > dialogTimeOut;

                    _dialogAnswer := X^._dialog.ShowWithExternalClose(THIS, _externalCloseOkSignal)
                    .WithYesNo()
                    .WithType(eDialogType#Warning)
                    .WithCaption('Warning caption!')
                    .WithText('Warning - dialog will be closed by external timeout 2s!').Answer();
                    
                    IF( _dialogAnswer = eDialogAnswer#Yes) THEN
                        THIS.MoveNext();
                    END_IF;
                //-------------------------------------------------------
            END_IF;

            IF (Steps[6].Execute(THIS, TRUE, '<#Dialog danger#>')) THEN
                //-------------------------------------------------------
                //_externalCloseOkSignal := CurrentStep.Duration > dialogTimeOut;

                    _dialogAnswer := X^._dialog.ShowWithExternalClose(THIS, _externalCloseOkSignal)
                    .WithYesNoCancel()
                    .WithType(eDialogType#Warning)
                    .WithCaption('Danger caption!')
                    .WithText('Danger - dialog will be closed by external timeout 2s!').Answer();
                    
                    IF( _dialogAnswer = eDialogAnswer#Yes) THEN
                        THIS.MoveNext();
                    END_IF;
                //-------------------------------------------------------
            END_IF;

            IF (Steps[7].Execute(THIS, TRUE, 'Example Digital inspection')) THEN
                //-------------------------------------------------------
                X^.PD.Data.Payload.PartPresence.WithCoordinator(THIS).Inspect(THIS,_inspectionResult)
                .UpdateComprehensiveResult(_comprehensiveResult)
                .OnFail()
                .CarryOn();
                //-------------------------------------------------------
            END_IF;

            IF (Steps[8].Execute(THIS, TRUE, 'Example Analog inspection')) THEN         
                //-------------------------------------------------------
                _inspectionValue := -5500;

                X^.PD.Data.Payload.LoadPosition.WithCoordinator(THIS)
                .Inspect(THIS,_inspectionValue)
                .UpdateComprehensiveResult(_comprehensiveResult)
                .OnFail()
                .Dialog( inRetryStep := Steps[50], inTerminateStep := Steps[60], inoDialog := X^._inspectorDialog);
                //-------------------------------------------------------
            END_IF;
            
            IF (Steps[9].Execute(THIS, TRUE, 'Example Data inspection')) THEN
                //-------------------------------------------------------
                _inspectionData := 'tempCode';

                X^.PD.Data.Payload.JigDataMatrixCode.WithCoordinator(THIS)
                .Inspect(THIS,_inspectionData)
                .UpdateComprehensiveResult(_comprehensiveResult)
                .OnFail()
                .Dialog( inRetryStep := Steps[70], inTerminateStep := Steps[80], inoDialog := X^._inspectorDialog);
                //-------------------------------------------------------
            END_IF;
                       

            IF (Steps[99].Execute(THIS, TRUE,CONCAT('UPDATE ITEM: ', _currentId))) THEN
                //-------------------------------------------------------
                IF (X^.PD.Update(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;
                //-------------------------------------------------------
            END_IF;  
         
                      
            // This will close the sequence and will return to the first step.
            THIS.Close(Steps[100]);
        END_METHOD
    END_CLASS

END_NAMESPACE
    
