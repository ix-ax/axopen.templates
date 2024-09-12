using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;
using AXOpen.Core;
using AXOpen.Data;

namespace axosimple
{
    public partial class Context : AXOpen.Core.AxoContext
    {
        public axosimple.TechnologyData TechnologySettings { get; }

        public axosimple.ProcessData ProcessSettings { get; }

        public axosimple.ProcessData ProcessData { get; }

        public AXOpen.Data.AxoDataPersistentExchange PersistentData { get; }

        public axosimple.GlobalContextObjects GlobalObjects { get; }

        public axosimple.TechnologySafety Safety { get; }

        public axosimple.StarterUnitTemplate.Unit StarterUnitTemplate { get; }

        public axosimple.UnitTemplate.Unit UnitTemplate { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public Context(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            TechnologySettings = new axosimple.TechnologyData(this, "TechnologySettings", "TechnologySettings");
            ProcessSettings = new axosimple.ProcessData(this, "ProcessSettings", "ProcessSettings");
            ProcessData = new axosimple.ProcessData(this, "ProcessData", "ProcessData");
            PersistentData = new AXOpen.Data.AxoDataPersistentExchange(this, "PersistentData", "PersistentData");
            GlobalObjects = new axosimple.GlobalContextObjects(this, "GlobalObjects", "GlobalObjects");
            Safety = new axosimple.TechnologySafety(this, "Safety", "Safety");
            StarterUnitTemplate = new axosimple.StarterUnitTemplate.Unit(this, "StarterUnitTemplate", "StarterUnitTemplate");
            UnitTemplate = new axosimple.UnitTemplate.Unit(this, "UnitTemplate", "UnitTemplate");
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
            plain.TechnologySettings = await TechnologySettings._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ProcessSettings = await ProcessSettings._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ProcessData = await ProcessData._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PersistentData = await PersistentData._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GlobalObjects = await GlobalObjects._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Safety = await Safety._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
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
            plain.TechnologySettings = await TechnologySettings._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ProcessSettings = await ProcessSettings._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ProcessData = await ProcessData._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PersistentData = await PersistentData._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GlobalObjects = await GlobalObjects._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Safety = await Safety._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
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
            plain.TechnologySettings = await TechnologySettings._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ProcessSettings = await ProcessSettings._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ProcessData = await ProcessData._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PersistentData = await PersistentData._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GlobalObjects = await GlobalObjects._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Safety = await Safety._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
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
            await this.TechnologySettings._PlainToOnlineNoacAsync(plain.TechnologySettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ProcessSettings._PlainToOnlineNoacAsync(plain.ProcessSettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ProcessData._PlainToOnlineNoacAsync(plain.ProcessData);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PersistentData._PlainToOnlineNoacAsync(plain.PersistentData);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.GlobalObjects._PlainToOnlineNoacAsync(plain.GlobalObjects);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Safety._PlainToOnlineNoacAsync(plain.Safety);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.StarterUnitTemplate._PlainToOnlineNoacAsync(plain.StarterUnitTemplate);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.UnitTemplate._PlainToOnlineNoacAsync(plain.UnitTemplate);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Context plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.TechnologySettings._PlainToOnlineNoacAsync(plain.TechnologySettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ProcessSettings._PlainToOnlineNoacAsync(plain.ProcessSettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ProcessData._PlainToOnlineNoacAsync(plain.ProcessData);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PersistentData._PlainToOnlineNoacAsync(plain.PersistentData);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.GlobalObjects._PlainToOnlineNoacAsync(plain.GlobalObjects);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Safety._PlainToOnlineNoacAsync(plain.Safety);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.StarterUnitTemplate._PlainToOnlineNoacAsync(plain.StarterUnitTemplate);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.UnitTemplate._PlainToOnlineNoacAsync(plain.UnitTemplate);
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
            plain.TechnologySettings = await TechnologySettings.ShadowToPlainAsync();
            plain.ProcessSettings = await ProcessSettings.ShadowToPlainAsync();
            plain.ProcessData = await ProcessData.ShadowToPlainAsync();
            plain.PersistentData = await PersistentData.ShadowToPlainAsync();
            plain.GlobalObjects = await GlobalObjects.ShadowToPlainAsync();
            plain.Safety = await Safety.ShadowToPlainAsync();
            plain.StarterUnitTemplate = await StarterUnitTemplate.ShadowToPlainAsync();
            plain.UnitTemplate = await UnitTemplate.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.Context> ShadowToPlainAsync(Pocos.axosimple.Context plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.TechnologySettings = await TechnologySettings.ShadowToPlainAsync();
            plain.ProcessSettings = await ProcessSettings.ShadowToPlainAsync();
            plain.ProcessData = await ProcessData.ShadowToPlainAsync();
            plain.PersistentData = await PersistentData.ShadowToPlainAsync();
            plain.GlobalObjects = await GlobalObjects.ShadowToPlainAsync();
            plain.Safety = await Safety.ShadowToPlainAsync();
            plain.StarterUnitTemplate = await StarterUnitTemplate.ShadowToPlainAsync();
            plain.UnitTemplate = await UnitTemplate.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Context plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.TechnologySettings.PlainToShadowAsync(plain.TechnologySettings);
            await this.ProcessSettings.PlainToShadowAsync(plain.ProcessSettings);
            await this.ProcessData.PlainToShadowAsync(plain.ProcessData);
            await this.PersistentData.PlainToShadowAsync(plain.PersistentData);
            await this.GlobalObjects.PlainToShadowAsync(plain.GlobalObjects);
            await this.Safety.PlainToShadowAsync(plain.Safety);
            await this.StarterUnitTemplate.PlainToShadowAsync(plain.StarterUnitTemplate);
            await this.UnitTemplate.PlainToShadowAsync(plain.UnitTemplate);
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
                if (await TechnologySettings.DetectsAnyChangeAsync(plain.TechnologySettings, latest.TechnologySettings))
                    somethingChanged = true;
                if (await ProcessSettings.DetectsAnyChangeAsync(plain.ProcessSettings, latest.ProcessSettings))
                    somethingChanged = true;
                if (await ProcessData.DetectsAnyChangeAsync(plain.ProcessData, latest.ProcessData))
                    somethingChanged = true;
                if (await PersistentData.DetectsAnyChangeAsync(plain.PersistentData, latest.PersistentData))
                    somethingChanged = true;
                if (await GlobalObjects.DetectsAnyChangeAsync(plain.GlobalObjects, latest.GlobalObjects))
                    somethingChanged = true;
                if (await Safety.DetectsAnyChangeAsync(plain.Safety, latest.Safety))
                    somethingChanged = true;
                if (await StarterUnitTemplate.DetectsAnyChangeAsync(plain.StarterUnitTemplate, latest.StarterUnitTemplate))
                    somethingChanged = true;
                if (await UnitTemplate.DetectsAnyChangeAsync(plain.UnitTemplate, latest.UnitTemplate))
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

    public partial class GlobalContextObjects : AXSharp.Connector.ITwinObject
    {
        [AXOpen.Data.PersistentAttribute("")]
        public OnlinerString LastTechnologySettings { get; }

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
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task<Pocos.axosimple.GlobalContextObjects> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.GlobalContextObjects plain = new Pocos.axosimple.GlobalContextObjects();
            plain.LastTechnologySettings = LastTechnologySettings.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.GlobalContextObjects> _OnlineToPlainNoacAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
            plain.LastTechnologySettings = LastTechnologySettings.LastValue;
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
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
#pragma warning disable CS0612
            LastTechnologySettings.LethargicWrite(plain.LastTechnologySettings);
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
            return plain;
        }

        protected async Task<Pocos.axosimple.GlobalContextObjects> ShadowToPlainAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
            plain.LastTechnologySettings = LastTechnologySettings.Shadow;
            return plain;
        }

        public async virtual Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.GlobalContextObjects plain)
        {
            LastTechnologySettings.Shadow = plain.LastTechnologySettings;
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

    public partial class ProcessData : AXOpen.Data.AxoDataFragmentExchange
    {
        [AXOpen.Data.AxoDataFragmentAttribute]
        public axosimple.SharedDataExchange Entity { get; }

        [AXOpen.Data.AxoDataFragmentAttribute]
        public axosimple.UnitTemplate.FragmentProcessDataManger UnitTemplate { get; }

        [AXOpen.Data.AxoDataFragmentAttribute]
        public axosimple.StarterUnitTemplate.ProcessDataExchange StarterUnitTemplate { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public ProcessData(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Entity = new axosimple.SharedDataExchange(this, "Entity", "Entity");
            UnitTemplate = new axosimple.UnitTemplate.FragmentProcessDataManger(this, "UnitTemplate", "UnitTemplate");
            StarterUnitTemplate = new axosimple.StarterUnitTemplate.ProcessDataExchange(this, "StarterUnitTemplate", "StarterUnitTemplate");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.ProcessData> OnlineToPlainAsync()
        {
            Pocos.axosimple.ProcessData plain = new Pocos.axosimple.ProcessData();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Entity = await Entity._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.ProcessData> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.ProcessData plain = new Pocos.axosimple.ProcessData();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Entity = await Entity._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.ProcessData> _OnlineToPlainNoacAsync(Pocos.axosimple.ProcessData plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Entity = await Entity._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.ProcessData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Entity._PlainToOnlineNoacAsync(plain.Entity);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.UnitTemplate._PlainToOnlineNoacAsync(plain.UnitTemplate);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.StarterUnitTemplate._PlainToOnlineNoacAsync(plain.StarterUnitTemplate);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.ProcessData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Entity._PlainToOnlineNoacAsync(plain.Entity);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.UnitTemplate._PlainToOnlineNoacAsync(plain.UnitTemplate);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.StarterUnitTemplate._PlainToOnlineNoacAsync(plain.StarterUnitTemplate);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.ProcessData> ShadowToPlainAsync()
        {
            Pocos.axosimple.ProcessData plain = new Pocos.axosimple.ProcessData();
            await base.ShadowToPlainAsync(plain);
            plain.Entity = await Entity.ShadowToPlainAsync();
            plain.UnitTemplate = await UnitTemplate.ShadowToPlainAsync();
            plain.StarterUnitTemplate = await StarterUnitTemplate.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.ProcessData> ShadowToPlainAsync(Pocos.axosimple.ProcessData plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Entity = await Entity.ShadowToPlainAsync();
            plain.UnitTemplate = await UnitTemplate.ShadowToPlainAsync();
            plain.StarterUnitTemplate = await StarterUnitTemplate.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.ProcessData plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.Entity.PlainToShadowAsync(plain.Entity);
            await this.UnitTemplate.PlainToShadowAsync(plain.UnitTemplate);
            await this.StarterUnitTemplate.PlainToShadowAsync(plain.StarterUnitTemplate);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.ProcessData plain, Pocos.axosimple.ProcessData latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await Entity.DetectsAnyChangeAsync(plain.Entity, latest.Entity))
                    somethingChanged = true;
                if (await UnitTemplate.DetectsAnyChangeAsync(plain.UnitTemplate, latest.UnitTemplate))
                    somethingChanged = true;
                if (await StarterUnitTemplate.DetectsAnyChangeAsync(plain.StarterUnitTemplate, latest.StarterUnitTemplate))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.ProcessData CreateEmptyPoco()
        {
            return new Pocos.axosimple.ProcessData();
        }
    }

    public partial class TechnologyData : AXOpen.Data.AxoDataFragmentExchange
    {
        [AXOpen.Data.AxoDataFragmentAttribute]
        public axosimple.TechnologySharedDataExchange Common { get; }

        [AXOpen.Data.AxoDataFragmentAttribute]
        public axosimple.UnitTemplate.FragmentTechnologyDataManger UnitTemplate { get; }

        [AXOpen.Data.AxoDataFragmentAttribute]
        public axosimple.StarterUnitTemplate.TechnologyDataExchange StarterUnitTemplate { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public TechnologyData(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Common = new axosimple.TechnologySharedDataExchange(this, "Common", "Common");
            UnitTemplate = new axosimple.UnitTemplate.FragmentTechnologyDataManger(this, "UnitTemplate", "UnitTemplate");
            StarterUnitTemplate = new axosimple.StarterUnitTemplate.TechnologyDataExchange(this, "StarterUnitTemplate", "StarterUnitTemplate");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.TechnologyData> OnlineToPlainAsync()
        {
            Pocos.axosimple.TechnologyData plain = new Pocos.axosimple.TechnologyData();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Common = await Common._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.TechnologyData> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.TechnologyData plain = new Pocos.axosimple.TechnologyData();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Common = await Common._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.TechnologyData> _OnlineToPlainNoacAsync(Pocos.axosimple.TechnologyData plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Common = await Common._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitTemplate = await UnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StarterUnitTemplate = await StarterUnitTemplate._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.TechnologyData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Common._PlainToOnlineNoacAsync(plain.Common);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.UnitTemplate._PlainToOnlineNoacAsync(plain.UnitTemplate);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.StarterUnitTemplate._PlainToOnlineNoacAsync(plain.StarterUnitTemplate);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.TechnologyData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Common._PlainToOnlineNoacAsync(plain.Common);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.UnitTemplate._PlainToOnlineNoacAsync(plain.UnitTemplate);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.StarterUnitTemplate._PlainToOnlineNoacAsync(plain.StarterUnitTemplate);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.TechnologyData> ShadowToPlainAsync()
        {
            Pocos.axosimple.TechnologyData plain = new Pocos.axosimple.TechnologyData();
            await base.ShadowToPlainAsync(plain);
            plain.Common = await Common.ShadowToPlainAsync();
            plain.UnitTemplate = await UnitTemplate.ShadowToPlainAsync();
            plain.StarterUnitTemplate = await StarterUnitTemplate.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.TechnologyData> ShadowToPlainAsync(Pocos.axosimple.TechnologyData plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Common = await Common.ShadowToPlainAsync();
            plain.UnitTemplate = await UnitTemplate.ShadowToPlainAsync();
            plain.StarterUnitTemplate = await StarterUnitTemplate.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.TechnologyData plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.Common.PlainToShadowAsync(plain.Common);
            await this.UnitTemplate.PlainToShadowAsync(plain.UnitTemplate);
            await this.StarterUnitTemplate.PlainToShadowAsync(plain.StarterUnitTemplate);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.TechnologyData plain, Pocos.axosimple.TechnologyData latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await Common.DetectsAnyChangeAsync(plain.Common, latest.Common))
                    somethingChanged = true;
                if (await UnitTemplate.DetectsAnyChangeAsync(plain.UnitTemplate, latest.UnitTemplate))
                    somethingChanged = true;
                if (await StarterUnitTemplate.DetectsAnyChangeAsync(plain.StarterUnitTemplate, latest.StarterUnitTemplate))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.TechnologyData CreateEmptyPoco()
        {
            return new Pocos.axosimple.TechnologyData();
        }
    }
}