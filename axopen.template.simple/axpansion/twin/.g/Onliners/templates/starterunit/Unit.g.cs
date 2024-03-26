using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.StarterUnitTemplate
{
    public partial class Unit : axosimple.BaseUnit.UnitBase
    {
        public axosimple.StarterUnitTemplate.UnitObjects UnitObjects { get; }

        public axosimple.StarterUnitTemplate.GroundSequence GroundSequence { get; }

        public axosimple.StarterUnitTemplate.AutomatSequence AutomatSequence { get; }

        public axosimple.StarterUnitTemplate.ServiceMode ServiceMode { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public Unit(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            UnitObjects = new axosimple.StarterUnitTemplate.UnitObjects(this, "UnitObjects", "UnitObjects");
            GroundSequence = new axosimple.StarterUnitTemplate.GroundSequence(this, "GroundSequence", "GroundSequence");
            AutomatSequence = new axosimple.StarterUnitTemplate.AutomatSequence(this, "AutomatSequence", "AutomatSequence");
            ServiceMode = new axosimple.StarterUnitTemplate.ServiceMode(this, "ServiceMode", "ServiceMode");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.StarterUnitTemplate.Unit> OnlineToPlainAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.Unit plain = new Pocos.axosimple.StarterUnitTemplate.Unit();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitObjects = await UnitObjects._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GroundSequence = await GroundSequence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AutomatSequence = await AutomatSequence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ServiceMode = await ServiceMode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.StarterUnitTemplate.Unit> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.Unit plain = new Pocos.axosimple.StarterUnitTemplate.Unit();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitObjects = await UnitObjects._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GroundSequence = await GroundSequence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AutomatSequence = await AutomatSequence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ServiceMode = await ServiceMode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.StarterUnitTemplate.Unit> _OnlineToPlainNoacAsync(Pocos.axosimple.StarterUnitTemplate.Unit plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.UnitObjects = await UnitObjects._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GroundSequence = await GroundSequence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AutomatSequence = await AutomatSequence._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ServiceMode = await ServiceMode._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.StarterUnitTemplate.Unit plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.UnitObjects._PlainToOnlineNoacAsync(plain.UnitObjects);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.GroundSequence._PlainToOnlineNoacAsync(plain.GroundSequence);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AutomatSequence._PlainToOnlineNoacAsync(plain.AutomatSequence);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ServiceMode._PlainToOnlineNoacAsync(plain.ServiceMode);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.StarterUnitTemplate.Unit plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.UnitObjects._PlainToOnlineNoacAsync(plain.UnitObjects);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.GroundSequence._PlainToOnlineNoacAsync(plain.GroundSequence);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AutomatSequence._PlainToOnlineNoacAsync(plain.AutomatSequence);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ServiceMode._PlainToOnlineNoacAsync(plain.ServiceMode);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.StarterUnitTemplate.Unit> ShadowToPlainAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.Unit plain = new Pocos.axosimple.StarterUnitTemplate.Unit();
            await base.ShadowToPlainAsync(plain);
            plain.UnitObjects = await UnitObjects.ShadowToPlainAsync();
            plain.GroundSequence = await GroundSequence.ShadowToPlainAsync();
            plain.AutomatSequence = await AutomatSequence.ShadowToPlainAsync();
            plain.ServiceMode = await ServiceMode.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.StarterUnitTemplate.Unit> ShadowToPlainAsync(Pocos.axosimple.StarterUnitTemplate.Unit plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.UnitObjects = await UnitObjects.ShadowToPlainAsync();
            plain.GroundSequence = await GroundSequence.ShadowToPlainAsync();
            plain.AutomatSequence = await AutomatSequence.ShadowToPlainAsync();
            plain.ServiceMode = await ServiceMode.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.StarterUnitTemplate.Unit plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.UnitObjects.PlainToShadowAsync(plain.UnitObjects);
            await this.GroundSequence.PlainToShadowAsync(plain.GroundSequence);
            await this.AutomatSequence.PlainToShadowAsync(plain.AutomatSequence);
            await this.ServiceMode.PlainToShadowAsync(plain.ServiceMode);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.StarterUnitTemplate.Unit plain, Pocos.axosimple.StarterUnitTemplate.Unit latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await UnitObjects.DetectsAnyChangeAsync(plain.UnitObjects, latest.UnitObjects))
                    somethingChanged = true;
                if (await GroundSequence.DetectsAnyChangeAsync(plain.GroundSequence, latest.GroundSequence))
                    somethingChanged = true;
                if (await AutomatSequence.DetectsAnyChangeAsync(plain.AutomatSequence, latest.AutomatSequence))
                    somethingChanged = true;
                if (await ServiceMode.DetectsAnyChangeAsync(plain.ServiceMode, latest.ServiceMode))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.StarterUnitTemplate.Unit CreateEmptyPoco()
        {
            return new Pocos.axosimple.StarterUnitTemplate.Unit();
        }
    }
}