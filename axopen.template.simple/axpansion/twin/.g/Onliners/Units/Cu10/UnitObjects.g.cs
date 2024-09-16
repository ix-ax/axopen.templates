using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.Cu10
{
    public partial class UnitObjects : axosimple.BaseUnit.UnitObjects
    {
        public axosimple.Cu10.Components C { get; }

        public axosimple.Cu10.ProcessDataManager PD { get; }

        public axosimple.Cu10.TechnologyDataManager TD { get; }

        [AXOpen.Data.PersistentAttribute("Cu10")]
        public OnlinerString SpecialSettings { get; }

        public AXOpen.Core.AxoDialog _DL { get; }

        public AXOpen.Core.AxoAlert _ADL { get; }

        public AXOpen.Inspectors.AxoInspectorDialog _IDL { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public UnitObjects(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            C = new axosimple.Cu10.Components(this, "C", "C");
            PD = new axosimple.Cu10.ProcessDataManager(this, "PD", "PD");
            TD = new axosimple.Cu10.TechnologyDataManager(this, "TD", "TD");
            SpecialSettings = @Connector.ConnectorAdapter.AdapterFactory.CreateSTRING(this, "SpecialSettings", "SpecialSettings");
            _DL = new AXOpen.Core.AxoDialog(this, "_DL", "_DL");
            _ADL = new AXOpen.Core.AxoAlert(this, "_ADL", "_ADL");
            _IDL = new AXOpen.Inspectors.AxoInspectorDialog(this, "_IDL", "_IDL");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Cu10.UnitObjects> OnlineToPlainAsync()
        {
            Pocos.axosimple.Cu10.UnitObjects plain = new Pocos.axosimple.Cu10.UnitObjects();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.C = await C._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PD = await PD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TD = await TD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.SpecialSettings = SpecialSettings.LastValue;
#pragma warning disable CS0612
            plain._DL = await _DL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._ADL = await _ADL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._IDL = await _IDL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.Cu10.UnitObjects> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.Cu10.UnitObjects plain = new Pocos.axosimple.Cu10.UnitObjects();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.C = await C._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PD = await PD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TD = await TD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.SpecialSettings = SpecialSettings.LastValue;
#pragma warning disable CS0612
            plain._DL = await _DL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._ADL = await _ADL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._IDL = await _IDL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.Cu10.UnitObjects> _OnlineToPlainNoacAsync(Pocos.axosimple.Cu10.UnitObjects plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.C = await C._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PD = await PD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TD = await TD._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain.SpecialSettings = SpecialSettings.LastValue;
#pragma warning disable CS0612
            plain._DL = await _DL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._ADL = await _ADL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._IDL = await _IDL._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.Cu10.UnitObjects plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.C._PlainToOnlineNoacAsync(plain.C);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PD._PlainToOnlineNoacAsync(plain.PD);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TD._PlainToOnlineNoacAsync(plain.TD);
#pragma warning restore CS0612
#pragma warning disable CS0612
            SpecialSettings.LethargicWrite(plain.SpecialSettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._DL._PlainToOnlineNoacAsync(plain._DL);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._ADL._PlainToOnlineNoacAsync(plain._ADL);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._IDL._PlainToOnlineNoacAsync(plain._IDL);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Cu10.UnitObjects plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.C._PlainToOnlineNoacAsync(plain.C);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PD._PlainToOnlineNoacAsync(plain.PD);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TD._PlainToOnlineNoacAsync(plain.TD);
#pragma warning restore CS0612
#pragma warning disable CS0612
            SpecialSettings.LethargicWrite(plain.SpecialSettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._DL._PlainToOnlineNoacAsync(plain._DL);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._ADL._PlainToOnlineNoacAsync(plain._ADL);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._IDL._PlainToOnlineNoacAsync(plain._IDL);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Cu10.UnitObjects> ShadowToPlainAsync()
        {
            Pocos.axosimple.Cu10.UnitObjects plain = new Pocos.axosimple.Cu10.UnitObjects();
            await base.ShadowToPlainAsync(plain);
            plain.C = await C.ShadowToPlainAsync();
            plain.PD = await PD.ShadowToPlainAsync();
            plain.TD = await TD.ShadowToPlainAsync();
            plain.SpecialSettings = SpecialSettings.Shadow;
            plain._DL = await _DL.ShadowToPlainAsync();
            plain._ADL = await _ADL.ShadowToPlainAsync();
            plain._IDL = await _IDL.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.Cu10.UnitObjects> ShadowToPlainAsync(Pocos.axosimple.Cu10.UnitObjects plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.C = await C.ShadowToPlainAsync();
            plain.PD = await PD.ShadowToPlainAsync();
            plain.TD = await TD.ShadowToPlainAsync();
            plain.SpecialSettings = SpecialSettings.Shadow;
            plain._DL = await _DL.ShadowToPlainAsync();
            plain._ADL = await _ADL.ShadowToPlainAsync();
            plain._IDL = await _IDL.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Cu10.UnitObjects plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.C.PlainToShadowAsync(plain.C);
            await this.PD.PlainToShadowAsync(plain.PD);
            await this.TD.PlainToShadowAsync(plain.TD);
            SpecialSettings.Shadow = plain.SpecialSettings;
            await this._DL.PlainToShadowAsync(plain._DL);
            await this._ADL.PlainToShadowAsync(plain._ADL);
            await this._IDL.PlainToShadowAsync(plain._IDL);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.Cu10.UnitObjects plain, Pocos.axosimple.Cu10.UnitObjects latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await C.DetectsAnyChangeAsync(plain.C, latest.C))
                    somethingChanged = true;
                if (await PD.DetectsAnyChangeAsync(plain.PD, latest.PD))
                    somethingChanged = true;
                if (await TD.DetectsAnyChangeAsync(plain.TD, latest.TD))
                    somethingChanged = true;
                if (plain.SpecialSettings != SpecialSettings.LastValue)
                    somethingChanged = true;
                if (await _DL.DetectsAnyChangeAsync(plain._DL, latest._DL))
                    somethingChanged = true;
                if (await _ADL.DetectsAnyChangeAsync(plain._ADL, latest._ADL))
                    somethingChanged = true;
                if (await _IDL.DetectsAnyChangeAsync(plain._IDL, latest._IDL))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.Cu10.UnitObjects CreateEmptyPoco()
        {
            return new Pocos.axosimple.Cu10.UnitObjects();
        }
    }
}