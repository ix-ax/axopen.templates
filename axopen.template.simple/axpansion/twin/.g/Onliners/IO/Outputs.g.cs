using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple
{
    [Container(Layout.Wrap)]
    public partial class Outputs : AXSharp.Connector.ITwinObject
    {
        public OnlinerBool[] P0 { get; }

        public OnlinerBool[] P1 { get; }

        public OnlinerDInt[] A0 { get; }

        public OnlinerDInt[] A1 { get; }

        public OnlinerBool[] D0 { get; }

        public OnlinerBool[] D1 { get; }

        public Outputs(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail)
        {
            this.@SymbolTail = symbolTail;
            this.@Connector = parent.GetConnector();
            this.@Parent = parent;
            HumanReadable = AXSharp.Connector.Connector.CreateHumanReadable(parent.HumanReadable, readableTail);
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            P0 = new OnlinerBool[8];
            AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(P0, this, "P0", "P0", (p, rt, st) => @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(p, rt, st), new[] { (0, 7) });
            P1 = new OnlinerBool[8];
            AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(P1, this, "P1", "P1", (p, rt, st) => @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(p, rt, st), new[] { (0, 7) });
            A0 = new OnlinerDInt[8];
            AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(A0, this, "A0", "A0", (p, rt, st) => @Connector.ConnectorAdapter.AdapterFactory.CreateDINT(p, rt, st), new[] { (0, 7) });
            A1 = new OnlinerDInt[8];
            AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(A1, this, "A1", "A1", (p, rt, st) => @Connector.ConnectorAdapter.AdapterFactory.CreateDINT(p, rt, st), new[] { (0, 7) });
            D0 = new OnlinerBool[8];
            AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(D0, this, "D0", "D0", (p, rt, st) => @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(p, rt, st), new[] { (0, 7) });
            D1 = new OnlinerBool[8];
            AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(D1, this, "D1", "D1", (p, rt, st) => @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(p, rt, st), new[] { (0, 7) });
            parent.AddChild(this);
            parent.AddKid(this);
        }

        public async virtual Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public async Task<Pocos.axosimple.Outputs> OnlineToPlainAsync()
        {
            Pocos.axosimple.Outputs plain = new Pocos.axosimple.Outputs();
            await this.ReadAsync<IgnoreOnPocoOperation>();
            plain.P0 = P0.Select(p => p.LastValue).ToArray();
            plain.P1 = P1.Select(p => p.LastValue).ToArray();
            plain.A0 = A0.Select(p => p.LastValue).ToArray();
            plain.A1 = A1.Select(p => p.LastValue).ToArray();
            plain.D0 = D0.Select(p => p.LastValue).ToArray();
            plain.D1 = D1.Select(p => p.LastValue).ToArray();
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task<Pocos.axosimple.Outputs> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.Outputs plain = new Pocos.axosimple.Outputs();
            plain.P0 = P0.Select(p => p.LastValue).ToArray();
            plain.P1 = P1.Select(p => p.LastValue).ToArray();
            plain.A0 = A0.Select(p => p.LastValue).ToArray();
            plain.A1 = A1.Select(p => p.LastValue).ToArray();
            plain.D0 = D0.Select(p => p.LastValue).ToArray();
            plain.D1 = D1.Select(p => p.LastValue).ToArray();
            return plain;
        }

        protected async Task<Pocos.axosimple.Outputs> OnlineToPlainAsync(Pocos.axosimple.Outputs plain)
        {
            plain.P0 = P0.Select(p => p.LastValue).ToArray();
            plain.P1 = P1.Select(p => p.LastValue).ToArray();
            plain.A0 = A0.Select(p => p.LastValue).ToArray();
            plain.A1 = A1.Select(p => p.LastValue).ToArray();
            plain.D0 = D0.Select(p => p.LastValue).ToArray();
            plain.D1 = D1.Select(p => p.LastValue).ToArray();
            return plain;
        }

        public async virtual Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.Outputs plain)
        {
            var _P0_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            P0.Select(p => p.LethargicWrite(plain.P0[_P0_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _P1_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            P1.Select(p => p.LethargicWrite(plain.P1[_P1_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _A0_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            A0.Select(p => p.LethargicWrite(plain.A0[_A0_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _A1_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            A1.Select(p => p.LethargicWrite(plain.A1[_A1_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _D0_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            D0.Select(p => p.LethargicWrite(plain.D0[_D0_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _D1_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            D1.Select(p => p.LethargicWrite(plain.D1[_D1_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Outputs plain)
        {
            var _P0_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            P0.Select(p => p.LethargicWrite(plain.P0[_P0_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _P1_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            P1.Select(p => p.LethargicWrite(plain.P1[_P1_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _A0_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            A0.Select(p => p.LethargicWrite(plain.A0[_A0_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _A1_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            A1.Select(p => p.LethargicWrite(plain.A1[_A1_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _D0_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            D0.Select(p => p.LethargicWrite(plain.D0[_D0_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            var _D1_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            D1.Select(p => p.LethargicWrite(plain.D1[_D1_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
        }

        public async virtual Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public async Task<Pocos.axosimple.Outputs> ShadowToPlainAsync()
        {
            Pocos.axosimple.Outputs plain = new Pocos.axosimple.Outputs();
            plain.P0 = P0.Select(p => p.Shadow).ToArray();
            plain.P1 = P1.Select(p => p.Shadow).ToArray();
            plain.A0 = A0.Select(p => p.Shadow).ToArray();
            plain.A1 = A1.Select(p => p.Shadow).ToArray();
            plain.D0 = D0.Select(p => p.Shadow).ToArray();
            plain.D1 = D1.Select(p => p.Shadow).ToArray();
            return plain;
        }

        protected async Task<Pocos.axosimple.Outputs> ShadowToPlainAsync(Pocos.axosimple.Outputs plain)
        {
            plain.P0 = P0.Select(p => p.Shadow).ToArray();
            plain.P1 = P1.Select(p => p.Shadow).ToArray();
            plain.A0 = A0.Select(p => p.Shadow).ToArray();
            plain.A1 = A1.Select(p => p.Shadow).ToArray();
            plain.D0 = D0.Select(p => p.Shadow).ToArray();
            plain.D1 = D1.Select(p => p.Shadow).ToArray();
            return plain;
        }

        public async virtual Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Outputs plain)
        {
            var _P0_i_FE8484DAB3 = 0;
            P0.Select(p => p.Shadow = plain.P0[_P0_i_FE8484DAB3++]).ToArray();
            var _P1_i_FE8484DAB3 = 0;
            P1.Select(p => p.Shadow = plain.P1[_P1_i_FE8484DAB3++]).ToArray();
            var _A0_i_FE8484DAB3 = 0;
            A0.Select(p => p.Shadow = plain.A0[_A0_i_FE8484DAB3++]).ToArray();
            var _A1_i_FE8484DAB3 = 0;
            A1.Select(p => p.Shadow = plain.A1[_A1_i_FE8484DAB3++]).ToArray();
            var _D0_i_FE8484DAB3 = 0;
            D0.Select(p => p.Shadow = plain.D0[_D0_i_FE8484DAB3++]).ToArray();
            var _D1_i_FE8484DAB3 = 0;
            D1.Select(p => p.Shadow = plain.D1[_D1_i_FE8484DAB3++]).ToArray();
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
        public async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.Outputs plain, Pocos.axosimple.Outputs latest = null)
        {
            var somethingChanged = false;
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            return await Task.Run(async () =>
            {
                for (int i760901_3001_mimi = 0; i760901_3001_mimi < latest.P0.Length; i760901_3001_mimi++)
                {
                    if (latest.P0.ElementAt(i760901_3001_mimi) != plain.P0[i760901_3001_mimi])
                        somethingChanged = true;
                }

                for (int i760901_3001_mimi = 0; i760901_3001_mimi < latest.P1.Length; i760901_3001_mimi++)
                {
                    if (latest.P1.ElementAt(i760901_3001_mimi) != plain.P1[i760901_3001_mimi])
                        somethingChanged = true;
                }

                for (int i760901_3001_mimi = 0; i760901_3001_mimi < latest.A0.Length; i760901_3001_mimi++)
                {
                    if (latest.A0.ElementAt(i760901_3001_mimi) != plain.A0[i760901_3001_mimi])
                        somethingChanged = true;
                }

                for (int i760901_3001_mimi = 0; i760901_3001_mimi < latest.A1.Length; i760901_3001_mimi++)
                {
                    if (latest.A1.ElementAt(i760901_3001_mimi) != plain.A1[i760901_3001_mimi])
                        somethingChanged = true;
                }

                for (int i760901_3001_mimi = 0; i760901_3001_mimi < latest.D0.Length; i760901_3001_mimi++)
                {
                    if (latest.D0.ElementAt(i760901_3001_mimi) != plain.D0[i760901_3001_mimi])
                        somethingChanged = true;
                }

                for (int i760901_3001_mimi = 0; i760901_3001_mimi < latest.D1.Length; i760901_3001_mimi++)
                {
                    if (latest.D1.ElementAt(i760901_3001_mimi) != plain.D1[i760901_3001_mimi])
                        somethingChanged = true;
                }

                plain = latest;
                return somethingChanged;
            });
        }

        public void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public Pocos.axosimple.Outputs CreateEmptyPoco()
        {
            return new Pocos.axosimple.Outputs();
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