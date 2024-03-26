using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;
using axosimple;

public partial class axosimpleTwinController : ITwinController
{
    public AXSharp.Connector.Connector Connector { get; }

    public axosimple.Inputs Inputs { get; }

    public axosimple.Outputs Outputs { get; }

    public axosimple.Context Context { get; }

    public AXOpen.S71500.Rtc S71500Rtc { get; }

    public AXOpen.Logging.AxoLogger ContextLogger { get; }

    public axosimpleTwinController(AXSharp.Connector.ConnectorAdapter adapter, object[] parameters)
    {
        this.Connector = adapter.GetConnector(parameters);
        Inputs = new axosimple.Inputs(this.Connector, "", "Inputs");
        Outputs = new axosimple.Outputs(this.Connector, "", "Outputs");
        Context = new axosimple.Context(this.Connector, "", "Context");
        S71500Rtc = new AXOpen.S71500.Rtc(this.Connector, "", "S71500Rtc");
        ContextLogger = new AXOpen.Logging.AxoLogger(this.Connector, "", "ContextLogger");
    }

    public axosimpleTwinController(AXSharp.Connector.ConnectorAdapter adapter)
    {
        this.Connector = adapter.GetConnector(adapter.Parameters);
        Inputs = new axosimple.Inputs(this.Connector, "", "Inputs");
        Outputs = new axosimple.Outputs(this.Connector, "", "Outputs");
        Context = new axosimple.Context(this.Connector, "", "Context");
        S71500Rtc = new AXOpen.S71500.Rtc(this.Connector, "", "S71500Rtc");
        ContextLogger = new AXOpen.Logging.AxoLogger(this.Connector, "", "ContextLogger");
    }
}