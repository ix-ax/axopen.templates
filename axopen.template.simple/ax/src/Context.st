USING AXOpen.Core;
USING AXOpen;
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

            S71500Rtc :  AXOpen.S71500.Rtc; 
            S71500Rtm :  AXOpen.S71500.Rtm;  
            ContextLogger : AXOpen.Logging.AxoLogger;    
            
            DoSynchronize : BOOL;
            TimeSynch : LDATE_AND_TIME;
            ControllerRtm : LDATE_AND_TIME;
            
            // Units snippet unitDeclaration
            //{#ix-set:AttributeName = "<#UnitTemplate#>"} 
            //UnitTemplate : axosimple.UnitTemplate.UnitContainer;                                                                                                           
        END_VAR      
                                
        METHOD PROTECTED OVERRIDE Main 
                        
            THIS.SetUp();
            Safety.Run(THIS);                    
            Glob.Run(THIS);

            IF(Inputs = NULL || Outputs = NULL) THEN
                RETURN;
            END_IF;                                                                   
            
            // Unit entry call unitEntryCall
            // UnitTemplate.Run(THIS, Inputs^, Outputs^, REF(Glob));
                        
        END_METHOD        
        
        METHOD PRIVATE SetUp
            
            IF(DoSynchronize) THEN                     
                S71500Rtc.SetUTC(TimeSynch);    
                DoSynchronize := FALSE;
            END_IF;        
        
            ControllerRtm :=  S71500Rtc.NowUTC();  
            ContextLogger.SetMinimumLevel(AXOpen.Logging.eLogLevel#Warning);                
            THIS.InjectRtm(S71500Rtm);
            THIS.InjectRtc(S71500Rtc);    
            THIS.InjectLogger(ContextLogger);

        END_METHOD    
    END_CLASS   
             
   
   
END_NAMESPACE

