using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.MyUnit
{
    public partial class Unit : axosimple.BaseUnit.UnitBase
    {
        public axosimple.MyUnit.UnitObjects X { get; }

        public axosimple.MyUnit.GroundSequence Ground { get; }

        public axosimple.MyUnit.AutomatSequence Auto { get; }

        public axosimple.MyUnit.ServiceMode Service { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public Unit(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            X = new axosimple.MyUnit.UnitObjects(this, "X", "X");
            Ground = new axosimple.MyUnit.GroundSequence(this, "Ground", "Ground");
            Auto = new axosimple.MyUnit.AutomatSequence(this, "Auto", "Auto");
            Service = new axosimple.MyUnit.ServiceMode(this, "Service", "Service");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.MyUnit.Unit> OnlineToPlainAsync()
        {
            Pocos.axosimple.MyUnit.Unit plain = new Pocos.axosimple.MyUnit.Unit();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.X = await X._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Ground = await Ground._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Auto = await Auto._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Service = await Service._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.MyUnit.Unit> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.MyUnit.Unit plain = new Pocos.axosimple.MyUnit.Unit();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.X = await X._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Ground = await Ground._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Auto = await Auto._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Service = await Service._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.MyUnit.Unit> _OnlineToPlainNoacAsync(Pocos.axosimple.MyUnit.Unit plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.X = await X._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Ground = await Ground._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Auto = await Auto._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Service = await Service._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.MyUnit.Unit plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.X._PlainToOnlineNoacAsync(plain.X);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Ground._PlainToOnlineNoacAsync(plain.Ground);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Auto._PlainToOnlineNoacAsync(plain.Auto);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Service._PlainToOnlineNoacAsync(plain.Service);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.MyUnit.Unit plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.X._PlainToOnlineNoacAsync(plain.X);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Ground._PlainToOnlineNoacAsync(plain.Ground);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Auto._PlainToOnlineNoacAsync(plain.Auto);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Service._PlainToOnlineNoacAsync(plain.Service);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.MyUnit.Unit> ShadowToPlainAsync()
        {
            Pocos.axosimple.MyUnit.Unit plain = new Pocos.axosimple.MyUnit.Unit();
            await base.ShadowToPlainAsync(plain);
            plain.X = await X.ShadowToPlainAsync();
            plain.Ground = await Ground.ShadowToPlainAsync();
            plain.Auto = await Auto.ShadowToPlainAsync();
            plain.Service = await Service.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.MyUnit.Unit> ShadowToPlainAsync(Pocos.axosimple.MyUnit.Unit plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.X = await X.ShadowToPlainAsync();
            plain.Ground = await Ground.ShadowToPlainAsync();
            plain.Auto = await Auto.ShadowToPlainAsync();
            plain.Service = await Service.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.MyUnit.Unit plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.X.PlainToShadowAsync(plain.X);
            await this.Ground.PlainToShadowAsync(plain.Ground);
            await this.Auto.PlainToShadowAsync(plain.Auto);
            await this.Service.PlainToShadowAsync(plain.Service);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.MyUnit.Unit plain, Pocos.axosimple.MyUnit.Unit latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await X.DetectsAnyChangeAsync(plain.X, latest.X))
                    somethingChanged = true;
                if (await Ground.DetectsAnyChangeAsync(plain.Ground, latest.Ground))
                    somethingChanged = true;
                if (await Auto.DetectsAnyChangeAsync(plain.Auto, latest.Auto))
                    somethingChanged = true;
                if (await Service.DetectsAnyChangeAsync(plain.Service, latest.Service))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.MyUnit.Unit CreateEmptyPoco()
        {
            return new Pocos.axosimple.MyUnit.Unit();
        }
    }
}