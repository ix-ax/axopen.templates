using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.StarterUnitTemplate
{
    public partial class ProcessData : AXOpen.Data.AxoDataEntity
    {
        public OnlinerULInt CounterDelay { get; }

        public AXOpen.Inspectors.AxoDigitalInspector PartPresence { get; }

        public AXOpen.Inspectors.AxoDataInspector JigDataMatrixCode { get; }

        public AXOpen.Inspectors.AxoAnalogueInspector LoadPosition { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public ProcessData(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            CounterDelay = @Connector.ConnectorAdapter.AdapterFactory.CreateULINT(this, "CounterDelay", "CounterDelay");
            PartPresence = new AXOpen.Inspectors.AxoDigitalInspector(this, "PartPresence", "PartPresence");
            JigDataMatrixCode = new AXOpen.Inspectors.AxoDataInspector(this, "JigDataMatrixCode", "JigDataMatrixCode");
            LoadPosition = new AXOpen.Inspectors.AxoAnalogueInspector(this, "LoadPosition", "LoadPosition");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.StarterUnitTemplate.ProcessData> OnlineToPlainAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.ProcessData plain = new Pocos.axosimple.StarterUnitTemplate.ProcessData();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.CounterDelay = CounterDelay.LastValue;
#pragma warning disable CS0612
            plain.PartPresence = await PartPresence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.JigDataMatrixCode = await JigDataMatrixCode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LoadPosition = await LoadPosition._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.StarterUnitTemplate.ProcessData> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.ProcessData plain = new Pocos.axosimple.StarterUnitTemplate.ProcessData();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.CounterDelay = CounterDelay.LastValue;
#pragma warning disable CS0612
            plain.PartPresence = await PartPresence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.JigDataMatrixCode = await JigDataMatrixCode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LoadPosition = await LoadPosition._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.StarterUnitTemplate.ProcessData> _OnlineToPlainNoacAsync(Pocos.axosimple.StarterUnitTemplate.ProcessData plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.CounterDelay = CounterDelay.LastValue;
#pragma warning disable CS0612
            plain.PartPresence = await PartPresence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.JigDataMatrixCode = await JigDataMatrixCode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LoadPosition = await LoadPosition._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.StarterUnitTemplate.ProcessData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            CounterDelay.LethargicWrite(plain.CounterDelay);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PartPresence._PlainToOnlineNoacAsync(plain.PartPresence);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.JigDataMatrixCode._PlainToOnlineNoacAsync(plain.JigDataMatrixCode);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.LoadPosition._PlainToOnlineNoacAsync(plain.LoadPosition);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.StarterUnitTemplate.ProcessData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            CounterDelay.LethargicWrite(plain.CounterDelay);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PartPresence._PlainToOnlineNoacAsync(plain.PartPresence);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.JigDataMatrixCode._PlainToOnlineNoacAsync(plain.JigDataMatrixCode);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.LoadPosition._PlainToOnlineNoacAsync(plain.LoadPosition);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.StarterUnitTemplate.ProcessData> ShadowToPlainAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.ProcessData plain = new Pocos.axosimple.StarterUnitTemplate.ProcessData();
            await base.ShadowToPlainAsync(plain);
            plain.CounterDelay = CounterDelay.Shadow;
            plain.PartPresence = await PartPresence.ShadowToPlainAsync();
            plain.JigDataMatrixCode = await JigDataMatrixCode.ShadowToPlainAsync();
            plain.LoadPosition = await LoadPosition.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.StarterUnitTemplate.ProcessData> ShadowToPlainAsync(Pocos.axosimple.StarterUnitTemplate.ProcessData plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.CounterDelay = CounterDelay.Shadow;
            plain.PartPresence = await PartPresence.ShadowToPlainAsync();
            plain.JigDataMatrixCode = await JigDataMatrixCode.ShadowToPlainAsync();
            plain.LoadPosition = await LoadPosition.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.StarterUnitTemplate.ProcessData plain)
        {
            await base.PlainToShadowAsync(plain);
            CounterDelay.Shadow = plain.CounterDelay;
            await this.PartPresence.PlainToShadowAsync(plain.PartPresence);
            await this.JigDataMatrixCode.PlainToShadowAsync(plain.JigDataMatrixCode);
            await this.LoadPosition.PlainToShadowAsync(plain.LoadPosition);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.StarterUnitTemplate.ProcessData plain, Pocos.axosimple.StarterUnitTemplate.ProcessData latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (plain.CounterDelay != CounterDelay.LastValue)
                    somethingChanged = true;
                if (await PartPresence.DetectsAnyChangeAsync(plain.PartPresence, latest.PartPresence))
                    somethingChanged = true;
                if (await JigDataMatrixCode.DetectsAnyChangeAsync(plain.JigDataMatrixCode, latest.JigDataMatrixCode))
                    somethingChanged = true;
                if (await LoadPosition.DetectsAnyChangeAsync(plain.LoadPosition, latest.LoadPosition))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.StarterUnitTemplate.ProcessData CreateEmptyPoco()
        {
            return new Pocos.axosimple.StarterUnitTemplate.ProcessData();
        }
    }
}