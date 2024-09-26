using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;
using AXOpen.Core;
using AXOpen;
using AXOpen.Core;
using AXOpen.Data;

namespace axosimple
{
    public partial class Context : AXOpen.Core.AxoContext
    {
        public axosimple.GlobalContextObjects Glob { get; }

        public axosimple.TechnologySafety Safety { get; }

        public AXOpen.S71500.Rtc S71500Rtc { get; }

        public AXOpen.S71500.Rtm S71500Rtm { get; }

        public AXOpen.Logging.AxoLogger ContextLogger { get; }

        public OnlinerBool DoSynchronize { get; }

        public OnlinerLDateTime TimeSynch { get; }

        public OnlinerLDateTime ControllerRtm { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public Context(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Glob = new axosimple.GlobalContextObjects(this, "Glob", "Glob");
            Safety = new axosimple.TechnologySafety(this, "Safety", "Safety");
            S71500Rtc = new AXOpen.S71500.Rtc(this, "S71500Rtc", "S71500Rtc");
            S71500Rtm = new AXOpen.S71500.Rtm(this, "S71500Rtm", "S71500Rtm");
            ContextLogger = new AXOpen.Logging.AxoLogger(this, "ContextLogger", "ContextLogger");
            DoSynchronize = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "DoSynchronize", "DoSynchronize");
            TimeSynch = @Connector.ConnectorAdapter.AdapterFactory.CreateLDATE_AND_TIME(this, "TimeSynch", "TimeSynch");
            ControllerRtm = @Connector.ConnectorAdapter.AdapterFactory.CreateLDATE_AND_TIME(this, "ControllerRtm", "ControllerRtm");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Context> OnlineToPlainAsync()
        {
            Pocos.axosimple.Context plain = new Pocos.axosimple.Context();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Glob = await Glob._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Safety = await Safety._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.S71500Rtc = await S71500Rtc._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.S71500Rtm = await S71500Rtm._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ContextLogger = await ContextLogger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.DoSynchronize = DoSynchronize.LastValue;
            plain.TimeSynch = TimeSynch.LastValue;
            plain.ControllerRtm = ControllerRtm.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.Context> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.Context plain = new Pocos.axosimple.Context();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Glob = await Glob._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Safety = await Safety._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.S71500Rtc = await S71500Rtc._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.S71500Rtm = await S71500Rtm._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ContextLogger = await ContextLogger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.DoSynchronize = DoSynchronize.LastValue;
            plain.TimeSynch = TimeSynch.LastValue;
            plain.ControllerRtm = ControllerRtm.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.Context> _OnlineToPlainNoacAsync(Pocos.axosimple.Context plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Glob = await Glob._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Safety = await Safety._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.S71500Rtc = await S71500Rtc._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.S71500Rtm = await S71500Rtm._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ContextLogger = await ContextLogger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.DoSynchronize = DoSynchronize.LastValue;
            plain.TimeSynch = TimeSynch.LastValue;
            plain.ControllerRtm = ControllerRtm.LastValue;
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.Context plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Glob._PlainToOnlineNoacAsync(plain.Glob);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Safety._PlainToOnlineNoacAsync(plain.Safety);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.S71500Rtc._PlainToOnlineNoacAsync(plain.S71500Rtc);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.S71500Rtm._PlainToOnlineNoacAsync(plain.S71500Rtm);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ContextLogger._PlainToOnlineNoacAsync(plain.ContextLogger);
#pragma warning restore CS0612
#pragma warning disable CS0612
            DoSynchronize.LethargicWrite(plain.DoSynchronize);
#pragma warning restore CS0612
#pragma warning disable CS0612
            TimeSynch.LethargicWrite(plain.TimeSynch);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ControllerRtm.LethargicWrite(plain.ControllerRtm);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Context plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Glob._PlainToOnlineNoacAsync(plain.Glob);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Safety._PlainToOnlineNoacAsync(plain.Safety);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.S71500Rtc._PlainToOnlineNoacAsync(plain.S71500Rtc);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.S71500Rtm._PlainToOnlineNoacAsync(plain.S71500Rtm);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ContextLogger._PlainToOnlineNoacAsync(plain.ContextLogger);
#pragma warning restore CS0612
#pragma warning disable CS0612
            DoSynchronize.LethargicWrite(plain.DoSynchronize);
#pragma warning restore CS0612
#pragma warning disable CS0612
            TimeSynch.LethargicWrite(plain.TimeSynch);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ControllerRtm.LethargicWrite(plain.ControllerRtm);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Context> ShadowToPlainAsync()
        {
            Pocos.axosimple.Context plain = new Pocos.axosimple.Context();
            await base.ShadowToPlainAsync(plain);
            plain.Glob = await Glob.ShadowToPlainAsync();
            plain.Safety = await Safety.ShadowToPlainAsync();
            plain.S71500Rtc = await S71500Rtc.ShadowToPlainAsync();
            plain.S71500Rtm = await S71500Rtm.ShadowToPlainAsync();
            plain.ContextLogger = await ContextLogger.ShadowToPlainAsync();
            plain.DoSynchronize = DoSynchronize.Shadow;
            plain.TimeSynch = TimeSynch.Shadow;
            plain.ControllerRtm = ControllerRtm.Shadow;
            return plain;
        }

        protected async Task<Pocos.axosimple.Context> ShadowToPlainAsync(Pocos.axosimple.Context plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Glob = await Glob.ShadowToPlainAsync();
            plain.Safety = await Safety.ShadowToPlainAsync();
            plain.S71500Rtc = await S71500Rtc.ShadowToPlainAsync();
            plain.S71500Rtm = await S71500Rtm.ShadowToPlainAsync();
            plain.ContextLogger = await ContextLogger.ShadowToPlainAsync();
            plain.DoSynchronize = DoSynchronize.Shadow;
            plain.TimeSynch = TimeSynch.Shadow;
            plain.ControllerRtm = ControllerRtm.Shadow;
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Context plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.Glob.PlainToShadowAsync(plain.Glob);
            await this.Safety.PlainToShadowAsync(plain.Safety);
            await this.S71500Rtc.PlainToShadowAsync(plain.S71500Rtc);
            await this.S71500Rtm.PlainToShadowAsync(plain.S71500Rtm);
            await this.ContextLogger.PlainToShadowAsync(plain.ContextLogger);
            DoSynchronize.Shadow = plain.DoSynchronize;
            TimeSynch.Shadow = plain.TimeSynch;
            ControllerRtm.Shadow = plain.ControllerRtm;
            return this.RetrievePrimitives();
        }

        ///<inheritdoc/>
        public async override Task<bool> AnyChangeAsync<T>(T plain)
        {
            return await this.DetectsAnyChangeAsync((dynamic)plain);
        }

        ///<summary>
        ///Compares if the current plain object has changed from the previous object.This method is used by the framework to determine if the object has changed and needs to be updated.
        ///[!NOTE] Any member in the hierarchy that is ignored by the compilers (e.g. when CompilerOmitAttribute is used) will not be compared, and therefore will not be detected as changed.
        ///</summary>
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.Context plain, Pocos.axosimple.Context latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await Glob.DetectsAnyChangeAsync(plain.Glob, latest.Glob))
                    somethingChanged = true;
                if (await Safety.DetectsAnyChangeAsync(plain.Safety, latest.Safety))
                    somethingChanged = true;
                if (await S71500Rtc.DetectsAnyChangeAsync(plain.S71500Rtc, latest.S71500Rtc))
                    somethingChanged = true;
                if (await S71500Rtm.DetectsAnyChangeAsync(plain.S71500Rtm, latest.S71500Rtm))
                    somethingChanged = true;
                if (await ContextLogger.DetectsAnyChangeAsync(plain.ContextLogger, latest.ContextLogger))
                    somethingChanged = true;
                if (plain.DoSynchronize != DoSynchronize.LastValue)
                    somethingChanged = true;
                if (plain.TimeSynch != TimeSynch.LastValue)
                    somethingChanged = true;
                if (plain.ControllerRtm != ControllerRtm.LastValue)
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.Context CreateEmptyPoco()
        {
            return new Pocos.axosimple.Context();
        }
    }
}