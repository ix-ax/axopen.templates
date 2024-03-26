using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple
{
    public partial class EntityData : AXOpen.Data.AxoDataEntity
    {
        [AXSharp.Connector.EnumeratorDiscriminatorAttribute(typeof(axosimple.eStations))]
        public OnlinerInt LastStation { get; }

        [AXSharp.Connector.EnumeratorDiscriminatorAttribute(typeof(axosimple.eStations))]
        public OnlinerInt NextStation { get; }

        [AXSharp.Connector.EnumeratorDiscriminatorAttribute(typeof(axosimple.eStations))]
        public OnlinerInt OpenOn { get; }

        public AXOpen.Inspectors.AxoComprehensiveResult Results { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerString Carrier { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerBool IsEmpty { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerBool IsMaster { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerBool WasReset { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public EntityData(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            LastStation = @Connector.ConnectorAdapter.AdapterFactory.CreateINT(this, "<#Last station#>", "LastStation");
            LastStation.AttributeName = "<#Last station#>";
            NextStation = @Connector.ConnectorAdapter.AdapterFactory.CreateINT(this, "<#Next station#>", "NextStation");
            NextStation.AttributeName = "<#Next station#>";
            OpenOn = @Connector.ConnectorAdapter.AdapterFactory.CreateINT(this, "<#Operations Opened#>", "OpenOn");
            OpenOn.AttributeName = "<#Operations Opened#>";
            Results = new AXOpen.Inspectors.AxoComprehensiveResult(this, "<#Results#>", "Results");
            Results.AttributeName = "<#Results#>";
            Carrier = @Connector.ConnectorAdapter.AdapterFactory.CreateSTRING(this, "<#Carrier#>", "Carrier");
            Carrier.AttributeName = "<#Carrier#>";
            IsEmpty = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "<#Is empty#>", "IsEmpty");
            IsEmpty.AttributeName = "<#Is empty#>";
            IsMaster = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "<#Is Master#>", "IsMaster");
            IsMaster.AttributeName = "<#Is Master#>";
            WasReset = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "<#Reset or ground position performed#>", "WasReset");
            WasReset.AttributeName = "<#Reset or ground position performed#>";
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.EntityData> OnlineToPlainAsync()
        {
            Pocos.axosimple.EntityData plain = new Pocos.axosimple.EntityData();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.LastStation = LastStation.LastValue;
            plain.NextStation = NextStation.LastValue;
            plain.OpenOn = OpenOn.LastValue;
#pragma warning disable CS0612
            plain.Results = await Results._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.Carrier = Carrier.LastValue;
            plain.IsEmpty = IsEmpty.LastValue;
            plain.IsMaster = IsMaster.LastValue;
            plain.WasReset = WasReset.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.EntityData> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.EntityData plain = new Pocos.axosimple.EntityData();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.LastStation = LastStation.LastValue;
            plain.NextStation = NextStation.LastValue;
            plain.OpenOn = OpenOn.LastValue;
#pragma warning disable CS0612
            plain.Results = await Results._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.Carrier = Carrier.LastValue;
            plain.IsEmpty = IsEmpty.LastValue;
            plain.IsMaster = IsMaster.LastValue;
            plain.WasReset = WasReset.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.EntityData> _OnlineToPlainNoacAsync(Pocos.axosimple.EntityData plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.LastStation = LastStation.LastValue;
            plain.NextStation = NextStation.LastValue;
            plain.OpenOn = OpenOn.LastValue;
#pragma warning disable CS0612
            plain.Results = await Results._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.Carrier = Carrier.LastValue;
            plain.IsEmpty = IsEmpty.LastValue;
            plain.IsMaster = IsMaster.LastValue;
            plain.WasReset = WasReset.LastValue;
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.EntityData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            LastStation.LethargicWrite(plain.LastStation);
#pragma warning restore CS0612
#pragma warning disable CS0612
            NextStation.LethargicWrite(plain.NextStation);
#pragma warning restore CS0612
#pragma warning disable CS0612
            OpenOn.LethargicWrite(plain.OpenOn);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Results._PlainToOnlineNoacAsync(plain.Results);
#pragma warning restore CS0612
#pragma warning disable CS0612
            Carrier.LethargicWrite(plain.Carrier);
#pragma warning restore CS0612
#pragma warning disable CS0612
            IsEmpty.LethargicWrite(plain.IsEmpty);
#pragma warning restore CS0612
#pragma warning disable CS0612
            IsMaster.LethargicWrite(plain.IsMaster);
#pragma warning restore CS0612
#pragma warning disable CS0612
            WasReset.LethargicWrite(plain.WasReset);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.EntityData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            LastStation.LethargicWrite(plain.LastStation);
#pragma warning restore CS0612
#pragma warning disable CS0612
            NextStation.LethargicWrite(plain.NextStation);
#pragma warning restore CS0612
#pragma warning disable CS0612
            OpenOn.LethargicWrite(plain.OpenOn);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Results._PlainToOnlineNoacAsync(plain.Results);
#pragma warning restore CS0612
#pragma warning disable CS0612
            Carrier.LethargicWrite(plain.Carrier);
#pragma warning restore CS0612
#pragma warning disable CS0612
            IsEmpty.LethargicWrite(plain.IsEmpty);
#pragma warning restore CS0612
#pragma warning disable CS0612
            IsMaster.LethargicWrite(plain.IsMaster);
#pragma warning restore CS0612
#pragma warning disable CS0612
            WasReset.LethargicWrite(plain.WasReset);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.EntityData> ShadowToPlainAsync()
        {
            Pocos.axosimple.EntityData plain = new Pocos.axosimple.EntityData();
            await base.ShadowToPlainAsync(plain);
            plain.LastStation = LastStation.Shadow;
            plain.NextStation = NextStation.Shadow;
            plain.OpenOn = OpenOn.Shadow;
            plain.Results = await Results.ShadowToPlainAsync();
            plain.Carrier = Carrier.Shadow;
            plain.IsEmpty = IsEmpty.Shadow;
            plain.IsMaster = IsMaster.Shadow;
            plain.WasReset = WasReset.Shadow;
            return plain;
        }

        protected async Task<Pocos.axosimple.EntityData> ShadowToPlainAsync(Pocos.axosimple.EntityData plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.LastStation = LastStation.Shadow;
            plain.NextStation = NextStation.Shadow;
            plain.OpenOn = OpenOn.Shadow;
            plain.Results = await Results.ShadowToPlainAsync();
            plain.Carrier = Carrier.Shadow;
            plain.IsEmpty = IsEmpty.Shadow;
            plain.IsMaster = IsMaster.Shadow;
            plain.WasReset = WasReset.Shadow;
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.EntityData plain)
        {
            await base.PlainToShadowAsync(plain);
            LastStation.Shadow = plain.LastStation;
            NextStation.Shadow = plain.NextStation;
            OpenOn.Shadow = plain.OpenOn;
            await this.Results.PlainToShadowAsync(plain.Results);
            Carrier.Shadow = plain.Carrier;
            IsEmpty.Shadow = plain.IsEmpty;
            IsMaster.Shadow = plain.IsMaster;
            WasReset.Shadow = plain.WasReset;
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.EntityData plain, Pocos.axosimple.EntityData latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (plain.LastStation != LastStation.LastValue)
                    somethingChanged = true;
                if (plain.NextStation != NextStation.LastValue)
                    somethingChanged = true;
                if (plain.OpenOn != OpenOn.LastValue)
                    somethingChanged = true;
                if (await Results.DetectsAnyChangeAsync(plain.Results, latest.Results))
                    somethingChanged = true;
                if (plain.Carrier != Carrier.LastValue)
                    somethingChanged = true;
                if (plain.IsEmpty != IsEmpty.LastValue)
                    somethingChanged = true;
                if (plain.IsMaster != IsMaster.LastValue)
                    somethingChanged = true;
                if (plain.WasReset != WasReset.LastValue)
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.EntityData CreateEmptyPoco()
        {
            return new Pocos.axosimple.EntityData();
        }
    }
}