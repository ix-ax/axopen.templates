
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
            Objs : REF_TO axosimple.UnitTemplate.UnitObjects;
            Components : REF_TO axosimple.UnitTemplate.Components;
            ProcessDataManager : REF_TO axosimple.UnitTemplate.ProcessDataManager;
            ProcessSettingsManager : REF_TO axosimple.UnitTemplate.FragmentProcessDataManger;
            TechnologySettingsManager : REF_TO axosimple.UnitTemplate.TechnologyDataManager;
            
            EntityHeader : REF_TO axosimple.EntityData;
            ProcessData : REF_TO axosimple.UnitTemplate.ProcessData;
            ProcessSettings : REF_TO axosimple.UnitTemplate.ProcessData;
            TechnologySettings : REF_TO axosimple.UnitTemplate.TechnologyData;

            _currentId : STRING;
        END_VAR

        METHOD INTERNAL Run
            VAR_INPUT
                _parent :  AXOpen.Core.IAxoObject;
                _unitObjects : REF_TO axosimple.UnitTemplate.UnitObjects;
            END_VAR     

            IF Objs = NULL THEN 
                Objs := _unitObjects;
                
                Components := Objs^.Components;
                ProcessDataManager := Objs^.ProcessData;
                ProcessSettingsManager := Objs^.ProcessSettings;
                TechnologySettingsManager := Objs^.TechnologySettings;

                EntityHeader := REF(ProcessDataManager^.Shared.Entity);
                ProcessData :=  REF(ProcessDataManager^.DataManger.Payload);
                ProcessSettings :=  REF(ProcessSettingsManager^.Payload);
                TechnologySettings :=  REF(TechnologySettingsManager^.DataManger.Payload);

            END_IF;

            SUPER.Run(_parent);
        END_METHOD
        ///<summary>
        /// Contains logic of the steps of this sequence
        ///</summary>

        METHOD OVERRIDE Main
            IF (Components = NULL OR ProcessDataManager = NULL) THEN
                RETURN;
            END_IF;
            
            // This sequecner executes the steps in cycles from top to bottom
            // in the same order they are written in the program
            // Each step in the sequence must can be used only once.
            // This sets the sequence to run in cycles (top-botton-top and again).
            THIS.SequenceMode := eAxoSequenceMode#Cyclic;
            
            IF (Steps[0].Execute(THIS, TRUE, '<#GET ID#>')) THEN
                //-------------------------------------------------------
                 IF(ProcessSettingsManager^.Read('default').IsDone()) THEN
                    ProcessDataManager^.DataManger.Payload := ProcessSettingsManager^.Payload;
                    _currentId := 'newProducedPart';
                    THIS.MoveNext(); 
                END_IF;                                    
                //-------------------------------------------------------
            END_IF;

            IF (Steps[10].Execute(THIS, TRUE, '<#GET DATA#>')) THEN
                //-------------------------------------------------------                  
                IF (ProcessDataManager^.CreateOrUpdate(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;
                //-------------------------------------------------------
            END_IF;
           
            // IF (Steps[15].Execute(THIS, TRUE, '<#MOVE HORIZONTAL CYLINDER TO WORK POSITION#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.Components^.HorizontalCylinder.MoveToWork().IsDone()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                  
            //     //-------------------------------------------------------
            // END_IF;
            
            // IF (Steps[20].Execute(THIS, TRUE, '<#MOVE VERTICAL CYLINDER TO WORK POSITION#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.Components^.VerticalCylinder.MoveToWork().IsDone()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                  
            //     //-------------------------------------------------------
            // END_IF;
           
            // IF (Steps[30].Execute(THIS, TRUE, '<#CLOSE GRIPPER#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.Components^.GripperCylinder.MoveToWork().IsDone()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                  
            //     //-------------------------------------------------------
            // END_IF;
          

            // IF (Steps[50].Execute(THIS, TRUE, '<#CHECK DIM X#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.ProcessDataManager^.DataManger.Payload.DimX.Inspect(THIS, 10.0).Done()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                  
            //     //-------------------------------------------------------
            // END_IF;

            
            // IF (Steps[60].Execute(THIS, TRUE, '<#CHECK DIM Y#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.ProcessDataManager^.DataManger.Payload.DimY.Inspect(THIS, 10.0).Done()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                   
            //     //-------------------------------------------------------
            // END_IF;
                      

            // IF (Steps[70].Execute(THIS, TRUE, '<#CHECK DIM Z#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.ProcessDataManager^.DataManger.Payload.DimZ.Inspect(THIS, 10.0).Done()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                  
            //     //-------------------------------------------------------
            // END_IF;
            
            // IF (Steps[110].Execute(THIS, TRUE, '<#MOVE VERTICAL CYLINDER TO WORK POSITION#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.Components^.VerticalCylinder.MoveToHome().IsDone()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                  
            //     //-------------------------------------------------------
            // END_IF;

            // IF (Steps[120].Execute(THIS, TRUE, '<#MOVE HORIZONTAL CYLINDER TO HOME POSITION#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.Components^.HorizontalCylinder.MoveToHome().IsDone()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                  
            //     //-------------------------------------------------------
            // END_IF;

            // IF (Steps[130].Execute(THIS, TRUE, '<#CLOSE GRIPPER#>')) THEN
            //     //-------------------------------------------------------                   
            //     IF(THIS.Components^.GripperCylinder.MoveToHome().IsDone()) THEN
            //         THIS.MoveNext();
            //     END_IF;                                  
            //     //-------------------------------------------------------
            // END_IF;


            IF (Steps[149].Execute(THIS, TRUE, '<#UPDATE DATA#>')) THEN
                //-------------------------------------------------------
                IF (ProcessDataManager^.Update(_currentId).IsDone()) THEN 
                    THIS.MoveNext(); 
                END_IF;
                //-------------------------------------------------------
            END_IF;

            // This will close the sequence and will return to the first step.
            THIS.Close(Steps[150]);
        END_METHOD
    END_CLASS
END_NAMESPACE
    
