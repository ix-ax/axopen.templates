using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.UnitTemplate
{
    public partial class AutomatSequence : AXOpen.Core.AxoSequencerContainer, IModeContainer
    {
        public AXOpen.Core.AxoStep[] Steps { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public AutomatSequence(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            AttributeName = "<#AUTOMAT#>";
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Steps = new AXOpen.Core.AxoStep[151];
            AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(Steps, this, "Steps", "Steps", (p, rt, st) => new AXOpen.Core.AxoStep(p, rt, st), new[] { (0, 150) });
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.UnitTemplate.AutomatSequence> OnlineToPlainAsync()
        {
            Pocos.axosimple.UnitTemplate.AutomatSequence plain = new Pocos.axosimple.UnitTemplate.AutomatSequence();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Steps = Steps.Select(async p => await p._OnlineToPlainNoacAsync()).Select(p => p.Result).ToArray();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.UnitTemplate.AutomatSequence> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.UnitTemplate.AutomatSequence plain = new Pocos.axosimple.UnitTemplate.AutomatSequence();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Steps = Steps.Select(async p => await p._OnlineToPlainNoacAsync()).Select(p => p.Result).ToArray();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.UnitTemplate.AutomatSequence> _OnlineToPlainNoacAsync(Pocos.axosimple.UnitTemplate.AutomatSequence plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Steps = Steps.Select(async p => await p._OnlineToPlainNoacAsync()).Select(p => p.Result).ToArray();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.UnitTemplate.AutomatSequence plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
            var _Steps_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            Steps.Select(p => p._PlainToOnlineNoacAsync(plain.Steps[_Steps_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.UnitTemplate.AutomatSequence plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
            var _Steps_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
            Steps.Select(p => p._PlainToOnlineNoacAsync(plain.Steps[_Steps_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.UnitTemplate.AutomatSequence> ShadowToPlainAsync()
        {
            Pocos.axosimple.UnitTemplate.AutomatSequence plain = new Pocos.axosimple.UnitTemplate.AutomatSequence();
            await base.ShadowToPlainAsync(plain);
            plain.Steps = Steps.Select(async p => await p.ShadowToPlainAsync()).Select(p => p.Result).ToArray();
            return plain;
        }

        protected async Task<Pocos.axosimple.UnitTemplate.AutomatSequence> ShadowToPlainAsync(Pocos.axosimple.UnitTemplate.AutomatSequence plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Steps = Steps.Select(async p => await p.ShadowToPlainAsync()).Select(p => p.Result).ToArray();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.UnitTemplate.AutomatSequence plain)
        {
            await base.PlainToShadowAsync(plain);
            var _Steps_i_FE8484DAB3 = 0;
            Steps.Select(p => p.PlainToShadowAsync(plain.Steps[_Steps_i_FE8484DAB3++])).ToArray();
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.UnitTemplate.AutomatSequence plain, Pocos.axosimple.UnitTemplate.AutomatSequence latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                for (int i760901_3001_mimi = 0; i760901_3001_mimi < latest.Steps.Length; i760901_3001_mimi++)
                {
                    if (await Steps.ElementAt(i760901_3001_mimi).DetectsAnyChangeAsync(plain.Steps[i760901_3001_mimi], latest.Steps[i760901_3001_mimi]))
                        somethingChanged = true;
                }

                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.UnitTemplate.AutomatSequence CreateEmptyPoco()
        {
            return new Pocos.axosimple.UnitTemplate.AutomatSequence();
        }
    }
}