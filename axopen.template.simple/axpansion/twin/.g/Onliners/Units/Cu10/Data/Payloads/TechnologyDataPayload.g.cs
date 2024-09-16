using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.Cu10
{
    public partial class TechnologyDataPayload : AXOpen.Data.AxoDataEntity
    {
        public axosimple.TechnologyUnitHeader Header { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public TechnologyDataPayload(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Header = new axosimple.TechnologyUnitHeader(this, "Header", "Header");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Cu10.TechnologyDataPayload> OnlineToPlainAsync()
        {
            Pocos.axosimple.Cu10.TechnologyDataPayload plain = new Pocos.axosimple.Cu10.TechnologyDataPayload();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Header = await Header._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.Cu10.TechnologyDataPayload> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.Cu10.TechnologyDataPayload plain = new Pocos.axosimple.Cu10.TechnologyDataPayload();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Header = await Header._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.Cu10.TechnologyDataPayload> _OnlineToPlainNoacAsync(Pocos.axosimple.Cu10.TechnologyDataPayload plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Header = await Header._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.Cu10.TechnologyDataPayload plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Header._PlainToOnlineNoacAsync(plain.Header);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Cu10.TechnologyDataPayload plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Header._PlainToOnlineNoacAsync(plain.Header);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Cu10.TechnologyDataPayload> ShadowToPlainAsync()
        {
            Pocos.axosimple.Cu10.TechnologyDataPayload plain = new Pocos.axosimple.Cu10.TechnologyDataPayload();
            await base.ShadowToPlainAsync(plain);
            plain.Header = await Header.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.Cu10.TechnologyDataPayload> ShadowToPlainAsync(Pocos.axosimple.Cu10.TechnologyDataPayload plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Header = await Header.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Cu10.TechnologyDataPayload plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.Header.PlainToShadowAsync(plain.Header);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.Cu10.TechnologyDataPayload plain, Pocos.axosimple.Cu10.TechnologyDataPayload latest = null)
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
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.Cu10.TechnologyDataPayload CreateEmptyPoco()
        {
            return new Pocos.axosimple.Cu10.TechnologyDataPayload();
        }
    }
}