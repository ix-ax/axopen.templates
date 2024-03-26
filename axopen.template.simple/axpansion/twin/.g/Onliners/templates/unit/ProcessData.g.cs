using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.UnitTemplate
{
    public partial class ProcessData : AXOpen.Data.AxoDataEntity
    {
        public axosimple.UnitHeader Header { get; }

        public AXOpen.Inspectors.AxoDataInspector JigDataMatrixCode { get; }

        public AXOpen.Inspectors.AxoDigitalInspector PartPresence { get; }

        public AXOpen.Inspectors.AxoAnalogueInspector RivetingPreasure { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public ProcessData(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Header = new axosimple.UnitHeader(this, "Header", "Header");
            JigDataMatrixCode = new AXOpen.Inspectors.AxoDataInspector(this, "JigDataMatrixCode", "JigDataMatrixCode");
            PartPresence = new AXOpen.Inspectors.AxoDigitalInspector(this, "PartPresence", "PartPresence");
            RivetingPreasure = new AXOpen.Inspectors.AxoAnalogueInspector(this, "RivetingPreasure", "RivetingPreasure");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.UnitTemplate.ProcessData> OnlineToPlainAsync()
        {
            Pocos.axosimple.UnitTemplate.ProcessData plain = new Pocos.axosimple.UnitTemplate.ProcessData();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Header = await Header._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.JigDataMatrixCode = await JigDataMatrixCode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PartPresence = await PartPresence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.RivetingPreasure = await RivetingPreasure._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.UnitTemplate.ProcessData> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.UnitTemplate.ProcessData plain = new Pocos.axosimple.UnitTemplate.ProcessData();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Header = await Header._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.JigDataMatrixCode = await JigDataMatrixCode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PartPresence = await PartPresence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.RivetingPreasure = await RivetingPreasure._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.UnitTemplate.ProcessData> _OnlineToPlainNoacAsync(Pocos.axosimple.UnitTemplate.ProcessData plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Header = await Header._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.JigDataMatrixCode = await JigDataMatrixCode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PartPresence = await PartPresence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.RivetingPreasure = await RivetingPreasure._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.UnitTemplate.ProcessData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Header._PlainToOnlineNoacAsync(plain.Header);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.JigDataMatrixCode._PlainToOnlineNoacAsync(plain.JigDataMatrixCode);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PartPresence._PlainToOnlineNoacAsync(plain.PartPresence);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.RivetingPreasure._PlainToOnlineNoacAsync(plain.RivetingPreasure);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.UnitTemplate.ProcessData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Header._PlainToOnlineNoacAsync(plain.Header);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.JigDataMatrixCode._PlainToOnlineNoacAsync(plain.JigDataMatrixCode);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PartPresence._PlainToOnlineNoacAsync(plain.PartPresence);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.RivetingPreasure._PlainToOnlineNoacAsync(plain.RivetingPreasure);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.UnitTemplate.ProcessData> ShadowToPlainAsync()
        {
            Pocos.axosimple.UnitTemplate.ProcessData plain = new Pocos.axosimple.UnitTemplate.ProcessData();
            await base.ShadowToPlainAsync(plain);
            plain.Header = await Header.ShadowToPlainAsync();
            plain.JigDataMatrixCode = await JigDataMatrixCode.ShadowToPlainAsync();
            plain.PartPresence = await PartPresence.ShadowToPlainAsync();
            plain.RivetingPreasure = await RivetingPreasure.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.UnitTemplate.ProcessData> ShadowToPlainAsync(Pocos.axosimple.UnitTemplate.ProcessData plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Header = await Header.ShadowToPlainAsync();
            plain.JigDataMatrixCode = await JigDataMatrixCode.ShadowToPlainAsync();
            plain.PartPresence = await PartPresence.ShadowToPlainAsync();
            plain.RivetingPreasure = await RivetingPreasure.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.UnitTemplate.ProcessData plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.Header.PlainToShadowAsync(plain.Header);
            await this.JigDataMatrixCode.PlainToShadowAsync(plain.JigDataMatrixCode);
            await this.PartPresence.PlainToShadowAsync(plain.PartPresence);
            await this.RivetingPreasure.PlainToShadowAsync(plain.RivetingPreasure);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.UnitTemplate.ProcessData plain, Pocos.axosimple.UnitTemplate.ProcessData latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await Header.DetectsAnyChangeAsync(plain.Header, latest.Header))
                    somethingChanged = true;
                if (await JigDataMatrixCode.DetectsAnyChangeAsync(plain.JigDataMatrixCode, latest.JigDataMatrixCode))
                    somethingChanged = true;
                if (await PartPresence.DetectsAnyChangeAsync(plain.PartPresence, latest.PartPresence))
                    somethingChanged = true;
                if (await RivetingPreasure.DetectsAnyChangeAsync(plain.RivetingPreasure, latest.RivetingPreasure))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.UnitTemplate.ProcessData CreateEmptyPoco()
        {
            return new Pocos.axosimple.UnitTemplate.ProcessData();
        }
    }
}