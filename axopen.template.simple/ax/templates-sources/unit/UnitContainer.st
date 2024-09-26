NAMESPACE axosimple.UnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
           
    ///<summary>
    /// Represents controlled units and high level task coordination.
    ///</summary>
    {S7.extern=ReadWrite}
    CLASS UnitContainer
        EXTENDS axosimple.BaseUnit.UnitContainerBase
        VAR PUBLIC
            ///<summary>
            /// Provide access to unit objets, that are used into sequnces.
            ///</summary>
            X  : axosimple.UnitTemplate.Unit;
            
            ///<summary>
            /// Ground sequence. Contains logic that brings the unit into initial state.
            ///</summary>
            Ground : axosimple.UnitTemplate.GroundSequence;

            ///<summary>
            /// Automatic sequence. Contains logic for automatic operations of this unit.
            ///</summary>
            Auto : axosimple.UnitTemplate.AutomatSequence;
            
            ///<summary>
            /// Service mode contains logic for service/manual operations.
            ///</summary>
            Service : axosimple.UnitTemplate.ServiceMode;
        END_VAR
        ///<summary>
        /// Runs this unit.
        ///</summary>

        METHOD PUBLIC Run
            VAR_INPUT
                inParent : IAxoContext;
            END_VAR
            VAR_IN_OUT
                ///<summary>
                /// Hardware input structure
                ///</summary>
                inoInputs : axosimple.Inputs;
                ///<summary>
                /// Hardware output structure
                ///</summary>
                inoOutputs : axosimple.Outputs;                
            END_VAR
            VAR_INPUT                
                inGlobal : REF_TO axosimple.GlobalContextObjects;             
            END_VAR    
            THIS.Initialize(inParent);           
            X.G := inGlobal;
            THIS.Execute(inoInputs, inoOutputs);                         
        END_METHOD

        ///<summary>
        ///     Exectute for this unit.
        ///     Execute runs cyclicaly you should place any call of this unit in this or underlying methods. 
        ///</summary>
        METHOD PRIVATE Execute
            VAR_IN_OUT
                inoInputs : axosimple.Inputs;
                inoOutputs : axosimple.Outputs;
            END_VAR
           
            // Component I/O immange and management handling.
             X.C.Update(THIS, inoInputs, inoOutputs);
             
             // Run process data manager of this unit.
             X.PD.Run(THIS);
             
             // Run technology data manger of this unit.
             X.TS.Run(THIS);
                         
            /* 

                    Ground mode handling

            */

             Ground.Run(THIS, REF(X));

             // Restores other states when Ground executes
             IF (Ground.IsBusy()) THEN
                 Auto.Restore();
                 Service.Restore();
             END_IF;

             /*
             
                    Automatic mode handling 
                    NOTE: Ground must be previously done.           

             */
             
             Auto.IsDisabled := Ground.Status <> eAxoTaskState#Done;
             Auto.Run(THIS, REF(X));


            /*
             
                Service/manual mode hadnling                

             */


             Service.Run(THIS, X);
 
             IF Service.IsBusy() THEN
                 Ground.Restore();
                 Auto.Restore();
             END_IF;
                                                  
        END_METHOD
    END_CLASS     
END_NAMESPACE
