using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple
{
    public partial class GlobalContextObjects : AXSharp.Connector.ITwinObject
    {
        [AXOpen.Data.PersistentAttribute("")]
        public OnlinerString LastTechnologySettings { get; }

        public AXOpen.Data.AxoDataPersistentExchange Persits { get; }

        public axosimple.ProcessData PS { get; }

        public axosimple.TechnologyData TS { get; }

        public axosimple.ProcessData PD { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public GlobalContextObjects(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            this.@SymbolTail = symbolTail;
            this.@Connector = parent.GetConnector();
            this.@Parent = parent;
            HumanReadable = AXSharp.Connector.Connector.CreateHumanReadable(parent.HumanReadable, readableTail);
            PreConstruct(parent, readableTail, symbolTail);
            LastTechnologySettings = @Connector.ConnectorAdapter.AdapterFactory.CreateSTRING(this, "LastTechnologySettings", "LastTechnologySettings");
            Persits = new AXOpen.Data.AxoDataPersistentExchange(this, "Persits", "Persits");
            PS = new axosimple.ProcessData(this, "PS", "PS");
            TS = new axosimple.TechnologyData(this, "TS", "TS");
            PD = new axosimple.ProcessData(this, "PD", "PD");
            parent.AddChild(this);
            parent.AddKid(this);
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async virtual Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public async Task<Pocos.axosimple.GlobalContextObjects> OnlineToPlainAsync()
        {
            Pocos.axosimple.GlobalContextObjects plain = new Pocos.axosimple.GlobalContextObjects();
            await this.ReadAsync<IgnoreOnPocoOperation>();
            plain.LastTechnologySettings = LastTechnologySettings.LastValue;
#pragma warning disable CS0612
            plain.Persits = await Persits._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PS = await PS._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TS = await TS._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PD = await PD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task<Pocos.axosimple.GlobalContextObjects> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.GlobalContextObjects plain = new Pocos.axosimple.GlobalContextObjects();
            plain.LastTechnologySettings = LastTechnologySettings.LastValue;
#pragma warning disable CS0612
            plain.Persits = await Persits._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PS = await PS._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TS = await TS._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PD = await PD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.GlobalContextObjects> _OnlineToPlainNoacAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
            plain.LastTechnologySettings = LastTechnologySettings.LastValue;
#pragma warning disable CS0612
            plain.Persits = await Persits._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PS = await PS._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TS = await TS._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PD = await PD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async virtual Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
#pragma warning disable CS0612
            LastTechnologySettings.LethargicWrite(plain.LastTechnologySettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Persits._PlainToOnlineNoacAsync(plain.Persits);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PS._PlainToOnlineNoacAsync(plain.PS);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TS._PlainToOnlineNoacAsync(plain.TS);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PD._PlainToOnlineNoacAsync(plain.PD);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
#pragma warning disable CS0612
            LastTechnologySettings.LethargicWrite(plain.LastTechnologySettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Persits._PlainToOnlineNoacAsync(plain.Persits);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PS._PlainToOnlineNoacAsync(plain.PS);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TS._PlainToOnlineNoacAsync(plain.TS);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PD._PlainToOnlineNoacAsync(plain.PD);
#pragma warning restore CS0612
        }

        public async virtual Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public async Task<Pocos.axosimple.GlobalContextObjects> ShadowToPlainAsync()
        {
            Pocos.axosimple.GlobalContextObjects plain = new Pocos.axosimple.GlobalContextObjects();
            plain.LastTechnologySettings = LastTechnologySettings.Shadow;
            plain.Persits = await Persits.ShadowToPlainAsync();
            plain.PS = await PS.ShadowToPlainAsync();
            plain.TS = await TS.ShadowToPlainAsync();
            plain.PD = await PD.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.GlobalContextObjects> ShadowToPlainAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
            plain.LastTechnologySettings = LastTechnologySettings.Shadow;
            plain.Persits = await Persits.ShadowToPlainAsync();
            plain.PS = await PS.ShadowToPlainAsync();
            plain.TS = await TS.ShadowToPlainAsync();
            plain.PD = await PD.ShadowToPlainAsync();
            return plain;
        }

        public async virtual Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
            LastTechnologySettings.Shadow = plain.LastTechnologySettings;
            await this.Persits.PlainToShadowAsync(plain.Persits);
            await this.PS.PlainToShadowAsync(plain.PS);
            await this.TS.PlainToShadowAsync(plain.TS);
            await this.PD.PlainToShadowAsync(plain.PD);
            return this.RetrievePrimitives();
        }

        ///<inheritdoc/>
        public async virtual Task<bool> AnyChangeAsync<T>(T plain)
        {
            return await this.DetectsAnyChangeAsync((dynamic)plain);
        }

        ///<summary>
        ///Compares if the current plain object has changed from the previous object.This method is used by the framework to determine if the object has changed and needs to be updated.
        ///[!NOTE] Any member in the hierarchy that is ignored by the compilers (e.g. when CompilerOmitAttribute is used) will not be compared, and therefore will not be detected as changed.
        ///</summary>
        public async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.GlobalContextObjects plain, Pocos.axosimple.GlobalContextObjects latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (plain.LastTechnologySettings != LastTechnologySettings.LastValue)
                    somethingChanged = true;
                if (await Persits.DetectsAnyChangeAsync(plain.Persits, latest.Persits))
                    somethingChanged = true;
                if (await PS.DetectsAnyChangeAsync(plain.PS, latest.PS))
                    somethingChanged = true;
                if (await TS.DetectsAnyChangeAsync(plain.TS, latest.TS))
                    somethingChanged = true;
                if (await PD.DetectsAnyChangeAsync(plain.PD, latest.PD))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public Pocos.axosimple.GlobalContextObjects CreateEmptyPoco()
        {
            return new Pocos.axosimple.GlobalContextObjects();
        }

        private IList<AXSharp.Connector.ITwinObject> Children { get; } = new List<AXSharp.Connector.ITwinObject>();
        public IEnumerable<AXSharp.Connector.ITwinObject> GetChildren()
        {
            return Children;
        }

        private IList<AXSharp.Connector.ITwinElement> Kids { get; } = new List<AXSharp.Connector.ITwinElement>();
        public IEnumerable<AXSharp.Connector.ITwinElement> GetKids()
        {
            return Kids;
        }

        private IList<AXSharp.Connector.ITwinPrimitive> ValueTags { get; } = new List<AXSharp.Connector.ITwinPrimitive>();
        public IEnumerable<AXSharp.Connector.ITwinPrimitive> GetValueTags()
        {
            return ValueTags;
        }

        public void AddValueTag(AXSharp.Connector.ITwinPrimitive valueTag)
        {
            ValueTags.Add(valueTag);
        }

        public void AddKid(AXSharp.Connector.ITwinElement kid)
        {
            Kids.Add(kid);
        }

        public void AddChild(AXSharp.Connector.ITwinObject twinObject)
        {
            Children.Add(twinObject);
        }

        protected AXSharp.Connector.Connector @Connector { get; }

        public AXSharp.Connector.Connector GetConnector()
        {
            return this.@Connector;
        }

        public string GetSymbolTail()
        {
            return this.SymbolTail;
        }

        public AXSharp.Connector.ITwinObject GetParent()
        {
            return this.@Parent;
        }

        public string Symbol { get; protected set; }

        private string _attributeName;
        public System.String AttributeName { get => string.IsNullOrEmpty(_attributeName) ? SymbolTail : _attributeName.Interpolate(this).CleanUpLocalizationTokens(); set => _attributeName = value; }

        public System.String GetAttributeName(System.Globalization.CultureInfo culture)
        {
            return this.Translate(_attributeName, culture).Interpolate(this);
        }

        private string _humanReadable;
        public string HumanReadable { get => string.IsNullOrEmpty(_humanReadable) ? SymbolTail : _humanReadable.Interpolate(this).CleanUpLocalizationTokens(); set => _humanReadable = value; }

        public System.String GetHumanReadable(System.Globalization.CultureInfo culture)
        {
            return this.Translate(_humanReadable, culture);
        }

        protected System.String @SymbolTail { get; set; }

        protected AXSharp.Connector.ITwinObject @Parent { get; set; }

        public AXSharp.Connector.Localizations.Translator Interpreter => global::axosimple.PlcTranslator.Instance;
    }
}