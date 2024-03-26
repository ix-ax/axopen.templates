using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple
{
    public partial class TechnologyUnitHeader : AXSharp.Connector.ITwinObject
    {
        public OnlinerTime IdealCycleTime { get; }

        public OnlinerTime WarningCycleTime { get; }

        public OnlinerTime ErrorCycleTime { get; }

        public OnlinerTime WarningStepAlarmTime { get; }

        public OnlinerTime ErrorStepAlarmTime { get; }

        public OnlinerTime TimeToEntryEnergySavingMode { get; }

        public OnlinerUInt ConsecutiveErrorCount { get; }

        public TechnologyUnitHeader(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail)
        {
            this.@SymbolTail = symbolTail;
            this.@Connector = parent.GetConnector();
            this.@Parent = parent;
            HumanReadable = AXSharp.Connector.Connector.CreateHumanReadable(parent.HumanReadable, readableTail);
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            IdealCycleTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Cycle time#> - <#Nominal#>", "IdealCycleTime");
            IdealCycleTime.AttributeName = "<#Cycle time#> - <#Nominal#>";
            WarningCycleTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Cycle time#> - <#Warning#>", "WarningCycleTime");
            WarningCycleTime.AttributeName = "<#Cycle time#> - <#Warning#>";
            ErrorCycleTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Cycle time#> - <#Error#>", "ErrorCycleTime");
            ErrorCycleTime.AttributeName = "<#Cycle time#> - <#Error#>";
            WarningStepAlarmTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Step time#> - <#Warning#>", "WarningStepAlarmTime");
            WarningStepAlarmTime.AttributeName = "<#Step time#> - <#Warning#>";
            ErrorStepAlarmTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Step time#> - <#Error#>", "ErrorStepAlarmTime");
            ErrorStepAlarmTime.AttributeName = "<#Step time#> - <#Error#>";
            TimeToEntryEnergySavingMode = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Energy saving mode - Inactivity time#>", "TimeToEntryEnergySavingMode");
            TimeToEntryEnergySavingMode.AttributeName = "<#Energy saving mode - Inactivity time#> ";
            ConsecutiveErrorCount = @Connector.ConnectorAdapter.AdapterFactory.CreateUINT(this, "<#Consecutive Error count #>", "ConsecutiveErrorCount");
            ConsecutiveErrorCount.AttributeName = "<#Consecutive Error count #> ";
            parent.AddChild(this);
            parent.AddKid(this);
        }

        public async virtual Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public async Task<Pocos.axosimple.TechnologyUnitHeader> OnlineToPlainAsync()
        {
            Pocos.axosimple.TechnologyUnitHeader plain = new Pocos.axosimple.TechnologyUnitHeader();
            await this.ReadAsync<IgnoreOnPocoOperation>();
            plain.IdealCycleTime = IdealCycleTime.LastValue;
            plain.WarningCycleTime = WarningCycleTime.LastValue;
            plain.ErrorCycleTime = ErrorCycleTime.LastValue;
            plain.WarningStepAlarmTime = WarningStepAlarmTime.LastValue;
            plain.ErrorStepAlarmTime = ErrorStepAlarmTime.LastValue;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.LastValue;
            plain.ConsecutiveErrorCount = ConsecutiveErrorCount.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task<Pocos.axosimple.TechnologyUnitHeader> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.TechnologyUnitHeader plain = new Pocos.axosimple.TechnologyUnitHeader();
            plain.IdealCycleTime = IdealCycleTime.LastValue;
            plain.WarningCycleTime = WarningCycleTime.LastValue;
            plain.ErrorCycleTime = ErrorCycleTime.LastValue;
            plain.WarningStepAlarmTime = WarningStepAlarmTime.LastValue;
            plain.ErrorStepAlarmTime = ErrorStepAlarmTime.LastValue;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.LastValue;
            plain.ConsecutiveErrorCount = ConsecutiveErrorCount.LastValue;
            return plain;
        }

        protected async Task<Pocos.axosimple.TechnologyUnitHeader> OnlineToPlainAsync(Pocos.axosimple.TechnologyUnitHeader plain)
        {
            plain.IdealCycleTime = IdealCycleTime.LastValue;
            plain.WarningCycleTime = WarningCycleTime.LastValue;
            plain.ErrorCycleTime = ErrorCycleTime.LastValue;
            plain.WarningStepAlarmTime = WarningStepAlarmTime.LastValue;
            plain.ErrorStepAlarmTime = ErrorStepAlarmTime.LastValue;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.LastValue;
            plain.ConsecutiveErrorCount = ConsecutiveErrorCount.LastValue;
            return plain;
        }

        public async virtual Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.TechnologyUnitHeader plain)
        {
#pragma warning disable CS0612
            IdealCycleTime.LethargicWrite(plain.IdealCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            WarningCycleTime.LethargicWrite(plain.WarningCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ErrorCycleTime.LethargicWrite(plain.ErrorCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            WarningStepAlarmTime.LethargicWrite(plain.WarningStepAlarmTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ErrorStepAlarmTime.LethargicWrite(plain.ErrorStepAlarmTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            TimeToEntryEnergySavingMode.LethargicWrite(plain.TimeToEntryEnergySavingMode);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ConsecutiveErrorCount.LethargicWrite(plain.ConsecutiveErrorCount);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.TechnologyUnitHeader plain)
        {
#pragma warning disable CS0612
            IdealCycleTime.LethargicWrite(plain.IdealCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            WarningCycleTime.LethargicWrite(plain.WarningCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ErrorCycleTime.LethargicWrite(plain.ErrorCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            WarningStepAlarmTime.LethargicWrite(plain.WarningStepAlarmTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ErrorStepAlarmTime.LethargicWrite(plain.ErrorStepAlarmTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            TimeToEntryEnergySavingMode.LethargicWrite(plain.TimeToEntryEnergySavingMode);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ConsecutiveErrorCount.LethargicWrite(plain.ConsecutiveErrorCount);
#pragma warning restore CS0612
        }

        public async virtual Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public async Task<Pocos.axosimple.TechnologyUnitHeader> ShadowToPlainAsync()
        {
            Pocos.axosimple.TechnologyUnitHeader plain = new Pocos.axosimple.TechnologyUnitHeader();
            plain.IdealCycleTime = IdealCycleTime.Shadow;
            plain.WarningCycleTime = WarningCycleTime.Shadow;
            plain.ErrorCycleTime = ErrorCycleTime.Shadow;
            plain.WarningStepAlarmTime = WarningStepAlarmTime.Shadow;
            plain.ErrorStepAlarmTime = ErrorStepAlarmTime.Shadow;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.Shadow;
            plain.ConsecutiveErrorCount = ConsecutiveErrorCount.Shadow;
            return plain;
        }

        protected async Task<Pocos.axosimple.TechnologyUnitHeader> ShadowToPlainAsync(Pocos.axosimple.TechnologyUnitHeader plain)
        {
            plain.IdealCycleTime = IdealCycleTime.Shadow;
            plain.WarningCycleTime = WarningCycleTime.Shadow;
            plain.ErrorCycleTime = ErrorCycleTime.Shadow;
            plain.WarningStepAlarmTime = WarningStepAlarmTime.Shadow;
            plain.ErrorStepAlarmTime = ErrorStepAlarmTime.Shadow;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.Shadow;
            plain.ConsecutiveErrorCount = ConsecutiveErrorCount.Shadow;
            return plain;
        }

        public async virtual Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.TechnologyUnitHeader plain)
        {
            IdealCycleTime.Shadow = plain.IdealCycleTime;
            WarningCycleTime.Shadow = plain.WarningCycleTime;
            ErrorCycleTime.Shadow = plain.ErrorCycleTime;
            WarningStepAlarmTime.Shadow = plain.WarningStepAlarmTime;
            ErrorStepAlarmTime.Shadow = plain.ErrorStepAlarmTime;
            TimeToEntryEnergySavingMode.Shadow = plain.TimeToEntryEnergySavingMode;
            ConsecutiveErrorCount.Shadow = plain.ConsecutiveErrorCount;
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
        public async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.TechnologyUnitHeader plain, Pocos.axosimple.TechnologyUnitHeader latest = null)
        {
            var somethingChanged = false;
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            return await Task.Run(async () =>
            {
                if (plain.IdealCycleTime != IdealCycleTime.LastValue)
                    somethingChanged = true;
                if (plain.WarningCycleTime != WarningCycleTime.LastValue)
                    somethingChanged = true;
                if (plain.ErrorCycleTime != ErrorCycleTime.LastValue)
                    somethingChanged = true;
                if (plain.WarningStepAlarmTime != WarningStepAlarmTime.LastValue)
                    somethingChanged = true;
                if (plain.ErrorStepAlarmTime != ErrorStepAlarmTime.LastValue)
                    somethingChanged = true;
                if (plain.TimeToEntryEnergySavingMode != TimeToEntryEnergySavingMode.LastValue)
                    somethingChanged = true;
                if (plain.ConsecutiveErrorCount != ConsecutiveErrorCount.LastValue)
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public Pocos.axosimple.TechnologyUnitHeader CreateEmptyPoco()
        {
            return new Pocos.axosimple.TechnologyUnitHeader();
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