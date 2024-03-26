using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.StarterUnitTemplate
{
    public partial class ProcessDataManager : AXOpen.Data.AxoDataFragmentExchange
    {
        [AXOpen.Data.AxoDataFragmentAttribute]
        public axosimple.EntityHeaderDataManager Shared { get; }

        [AXOpen.Data.AxoDataFragmentAttribute]
        public axosimple.StarterUnitTemplate.FragmentProcessDataManger DataManger { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public ProcessDataManager(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Shared = new axosimple.EntityHeaderDataManager(this, "Shared", "Shared");
            DataManger = new axosimple.StarterUnitTemplate.FragmentProcessDataManger(this, "DataManger", "DataManger");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.StarterUnitTemplate.ProcessDataManager> OnlineToPlainAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain = new Pocos.axosimple.StarterUnitTemplate.ProcessDataManager();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Shared = await Shared._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DataManger = await DataManger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.StarterUnitTemplate.ProcessDataManager> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain = new Pocos.axosimple.StarterUnitTemplate.ProcessDataManager();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Shared = await Shared._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DataManger = await DataManger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.StarterUnitTemplate.ProcessDataManager> _OnlineToPlainNoacAsync(Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Shared = await Shared._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DataManger = await DataManger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Shared._PlainToOnlineNoacAsync(plain.Shared);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DataManger._PlainToOnlineNoacAsync(plain.DataManger);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Shared._PlainToOnlineNoacAsync(plain.Shared);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DataManger._PlainToOnlineNoacAsync(plain.DataManger);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.StarterUnitTemplate.ProcessDataManager> ShadowToPlainAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain = new Pocos.axosimple.StarterUnitTemplate.ProcessDataManager();
            await base.ShadowToPlainAsync(plain);
            plain.Shared = await Shared.ShadowToPlainAsync();
            plain.DataManger = await DataManger.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.StarterUnitTemplate.ProcessDataManager> ShadowToPlainAsync(Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Shared = await Shared.ShadowToPlainAsync();
            plain.DataManger = await DataManger.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.Shared.PlainToShadowAsync(plain.Shared);
            await this.DataManger.PlainToShadowAsync(plain.DataManger);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.StarterUnitTemplate.ProcessDataManager plain, Pocos.axosimple.StarterUnitTemplate.ProcessDataManager latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await Shared.DetectsAnyChangeAsync(plain.Shared, latest.Shared))
                    somethingChanged = true;
                if (await DataManger.DetectsAnyChangeAsync(plain.DataManger, latest.DataManger))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.StarterUnitTemplate.ProcessDataManager CreateEmptyPoco()
        {
            return new Pocos.axosimple.StarterUnitTemplate.ProcessDataManager();
        }
    }
}