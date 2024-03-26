using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple
{
    public partial class UnitHeader : AXSharp.Connector.ITwinObject
    {
        [AXSharp.Connector.EnumeratorDiscriminatorAttribute(typeof(axosimple.eStations))]
        public OnlinerInt OnPassed { get; }

        [AXSharp.Connector.EnumeratorDiscriminatorAttribute(typeof(axosimple.eStations))]
        public OnlinerInt OnFailed { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerTime CycleTime { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerTime CleanLoopTime { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerDateTime OperationsStarted { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerDateTime OperationsEnded { get; }

        [RenderIgnore("Control", "ShadowControl")]
        public OnlinerString Operator { get; }

        public UnitHeader(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail)
        {
            this.@SymbolTail = symbolTail;
            this.@Connector = parent.GetConnector();
            this.@Parent = parent;
            HumanReadable = AXSharp.Connector.Connector.CreateHumanReadable(parent.HumanReadable, readableTail);
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            OnPassed = @Connector.ConnectorAdapter.AdapterFactory.CreateINT(this, "<#Next on Passed#>", "OnPassed");
            OnPassed.AttributeName = "<#Next on Passed#>";
            OnFailed = @Connector.ConnectorAdapter.AdapterFactory.CreateINT(this, "<#Next on Failed#>", "OnFailed");
            OnFailed.AttributeName = "<#Next on Failed#>";
            CycleTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Cycle time#>", "CycleTime");
            CycleTime.AttributeName = "<#Cycle time#>";
            CleanLoopTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Clean loop time#>", "CleanLoopTime");
            CleanLoopTime.AttributeName = "<#Clean loop time#>";
            OperationsStarted = @Connector.ConnectorAdapter.AdapterFactory.CreateDATE_AND_TIME(this, "<#Operation started#>", "OperationsStarted");
            OperationsStarted.AttributeName = "<#Operation started#>";
            OperationsEnded = @Connector.ConnectorAdapter.AdapterFactory.CreateDATE_AND_TIME(this, "<#Operation end#>", "OperationsEnded");
            OperationsEnded.AttributeName = "<#Operation end#>";
            Operator = @Connector.ConnectorAdapter.AdapterFactory.CreateSTRING(this, "<#Operatod id#>", "Operator");
            Operator.AttributeName = "<#Operatod id#>";
            parent.AddChild(this);
            parent.AddKid(this);
        }

        public async virtual Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public async Task<Pocos.axosimple.UnitHeader> OnlineToPlainAsync()
        {
            Pocos.axosimple.UnitHeader plain = new Pocos.axosimple.UnitHeader();
            await this.ReadAsync<IgnoreOnPocoOperation>();
            plain.OnPassed = OnPassed.LastValue;
            plain.OnFailed = OnFailed.LastValue;
            plain.CycleTime = CycleTime.LastValue;
            plain.CleanLoopTime = CleanLoopTime.LastValue;
            plain.OperationsStarted = OperationsStarted.LastValue;
            plain.OperationsEnded = OperationsEnded.LastValue;
            plain.Operator = Operator.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task<Pocos.axosimple.UnitHeader> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.UnitHeader plain = new Pocos.axosimple.UnitHeader();
            plain.OnPassed = OnPassed.LastValue;
            plain.OnFailed = OnFailed.LastValue;
            plain.CycleTime = CycleTime.LastValue;
            plain.CleanLoopTime = CleanLoopTime.LastValue;
            plain.OperationsStarted = OperationsStarted.LastValue;
            plain.OperationsEnded = OperationsEnded.LastValue;
            plain.Operator = Operator.LastValue;
            return plain;
        }

        protected async Task<Pocos.axosimple.UnitHeader> OnlineToPlainAsync(Pocos.axosimple.UnitHeader plain)
        {
            plain.OnPassed = OnPassed.LastValue;
            plain.OnFailed = OnFailed.LastValue;
            plain.CycleTime = CycleTime.LastValue;
            plain.CleanLoopTime = CleanLoopTime.LastValue;
            plain.OperationsStarted = OperationsStarted.LastValue;
            plain.OperationsEnded = OperationsEnded.LastValue;
            plain.Operator = Operator.LastValue;
            return plain;
        }

        public async virtual Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.UnitHeader plain)
        {
#pragma warning disable CS0612
            OnPassed.LethargicWrite(plain.OnPassed);
#pragma warning restore CS0612
#pragma warning disable CS0612
            OnFailed.LethargicWrite(plain.OnFailed);
#pragma warning restore CS0612
#pragma warning disable CS0612
            CycleTime.LethargicWrite(plain.CycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            CleanLoopTime.LethargicWrite(plain.CleanLoopTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            OperationsStarted.LethargicWrite(plain.OperationsStarted);
#pragma warning restore CS0612
#pragma warning disable CS0612
            OperationsEnded.LethargicWrite(plain.OperationsEnded);
#pragma warning restore CS0612
#pragma warning disable CS0612
            Operator.LethargicWrite(plain.Operator);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.UnitHeader plain)
        {
#pragma warning disable CS0612
            OnPassed.LethargicWrite(plain.OnPassed);
#pragma warning restore CS0612
#pragma warning disable CS0612
            OnFailed.LethargicWrite(plain.OnFailed);
#pragma warning restore CS0612
#pragma warning disable CS0612
            CycleTime.LethargicWrite(plain.CycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            CleanLoopTime.LethargicWrite(plain.CleanLoopTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            OperationsStarted.LethargicWrite(plain.OperationsStarted);
#pragma warning restore CS0612
#pragma warning disable CS0612
            OperationsEnded.LethargicWrite(plain.OperationsEnded);
#pragma warning restore CS0612
#pragma warning disable CS0612
            Operator.LethargicWrite(plain.Operator);
#pragma warning restore CS0612
        }

        public async virtual Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public async Task<Pocos.axosimple.UnitHeader> ShadowToPlainAsync()
        {
            Pocos.axosimple.UnitHeader plain = new Pocos.axosimple.UnitHeader();
            plain.OnPassed = OnPassed.Shadow;
            plain.OnFailed = OnFailed.Shadow;
            plain.CycleTime = CycleTime.Shadow;
            plain.CleanLoopTime = CleanLoopTime.Shadow;
            plain.OperationsStarted = OperationsStarted.Shadow;
            plain.OperationsEnded = OperationsEnded.Shadow;
            plain.Operator = Operator.Shadow;
            return plain;
        }

        protected async Task<Pocos.axosimple.UnitHeader> ShadowToPlainAsync(Pocos.axosimple.UnitHeader plain)
        {
            plain.OnPassed = OnPassed.Shadow;
            plain.OnFailed = OnFailed.Shadow;
            plain.CycleTime = CycleTime.Shadow;
            plain.CleanLoopTime = CleanLoopTime.Shadow;
            plain.OperationsStarted = OperationsStarted.Shadow;
            plain.OperationsEnded = OperationsEnded.Shadow;
            plain.Operator = Operator.Shadow;
            return plain;
        }

        public async virtual Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.UnitHeader plain)
        {
            OnPassed.Shadow = plain.OnPassed;
            OnFailed.Shadow = plain.OnFailed;
            CycleTime.Shadow = plain.CycleTime;
            CleanLoopTime.Shadow = plain.CleanLoopTime;
            OperationsStarted.Shadow = plain.OperationsStarted;
            OperationsEnded.Shadow = plain.OperationsEnded;
            Operator.Shadow = plain.Operator;
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
        public async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.UnitHeader plain, Pocos.axosimple.UnitHeader latest = null)
        {
            var somethingChanged = false;
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            return await Task.Run(async () =>
            {
                if (plain.OnPassed != OnPassed.LastValue)
                    somethingChanged = true;
                if (plain.OnFailed != OnFailed.LastValue)
                    somethingChanged = true;
                if (plain.CycleTime != CycleTime.LastValue)
                    somethingChanged = true;
                if (plain.CleanLoopTime != CleanLoopTime.LastValue)
                    somethingChanged = true;
                if (plain.OperationsStarted != OperationsStarted.LastValue)
                    somethingChanged = true;
                if (plain.OperationsEnded != OperationsEnded.LastValue)
                    somethingChanged = true;
                if (plain.Operator != Operator.LastValue)
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public Pocos.axosimple.UnitHeader CreateEmptyPoco()
        {
            return new Pocos.axosimple.UnitHeader();
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