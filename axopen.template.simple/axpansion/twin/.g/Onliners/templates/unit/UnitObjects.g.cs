using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.UnitTemplate
{
    public partial class UnitObjects : axosimple.BaseUnit.UnitObjects
    {
        [AXOpen.Data.PersistentAttribute("UnitTemplate")]
        public OnlinerString SpecialSettings { get; }

        public AXOpen.Core.AxoDialog _dialog { get; }

        public AXOpen.Core.AxoAlert _alertDialog { get; }

        public AXOpen.Inspectors.AxoInspectorDialog _inspectorDialog { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public UnitObjects(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            SpecialSettings = @Connector.ConnectorAdapter.AdapterFactory.CreateSTRING(this, "SpecialSettings", "SpecialSettings");
            _dialog = new AXOpen.Core.AxoDialog(this, "_dialog", "_dialog");
            _alertDialog = new AXOpen.Core.AxoAlert(this, "_alertDialog", "_alertDialog");
            _inspectorDialog = new AXOpen.Inspectors.AxoInspectorDialog(this, "_inspectorDialog", "_inspectorDialog");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.UnitTemplate.UnitObjects> OnlineToPlainAsync()
        {
            Pocos.axosimple.UnitTemplate.UnitObjects plain = new Pocos.axosimple.UnitTemplate.UnitObjects();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.SpecialSettings = SpecialSettings.LastValue;
#pragma warning disable CS0612
            plain._dialog = await _dialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._alertDialog = await _alertDialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._inspectorDialog = await _inspectorDialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.UnitTemplate.UnitObjects> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.UnitTemplate.UnitObjects plain = new Pocos.axosimple.UnitTemplate.UnitObjects();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.SpecialSettings = SpecialSettings.LastValue;
#pragma warning disable CS0612
            plain._dialog = await _dialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._alertDialog = await _alertDialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._inspectorDialog = await _inspectorDialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.UnitTemplate.UnitObjects> _OnlineToPlainNoacAsync(Pocos.axosimple.UnitTemplate.UnitObjects plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.SpecialSettings = SpecialSettings.LastValue;
#pragma warning disable CS0612
            plain._dialog = await _dialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._alertDialog = await _alertDialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._inspectorDialog = await _inspectorDialog._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.UnitTemplate.UnitObjects plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            SpecialSettings.LethargicWrite(plain.SpecialSettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._dialog._PlainToOnlineNoacAsync(plain._dialog);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._alertDialog._PlainToOnlineNoacAsync(plain._alertDialog);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._inspectorDialog._PlainToOnlineNoacAsync(plain._inspectorDialog);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.UnitTemplate.UnitObjects plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            SpecialSettings.LethargicWrite(plain.SpecialSettings);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._dialog._PlainToOnlineNoacAsync(plain._dialog);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._alertDialog._PlainToOnlineNoacAsync(plain._alertDialog);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._inspectorDialog._PlainToOnlineNoacAsync(plain._inspectorDialog);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.UnitTemplate.UnitObjects> ShadowToPlainAsync()
        {
            Pocos.axosimple.UnitTemplate.UnitObjects plain = new Pocos.axosimple.UnitTemplate.UnitObjects();
            await base.ShadowToPlainAsync(plain);
            plain.SpecialSettings = SpecialSettings.Shadow;
            plain._dialog = await _dialog.ShadowToPlainAsync();
            plain._alertDialog = await _alertDialog.ShadowToPlainAsync();
            plain._inspectorDialog = await _inspectorDialog.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.UnitTemplate.UnitObjects> ShadowToPlainAsync(Pocos.axosimple.UnitTemplate.UnitObjects plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.SpecialSettings = SpecialSettings.Shadow;
            plain._dialog = await _dialog.ShadowToPlainAsync();
            plain._alertDialog = await _alertDialog.ShadowToPlainAsync();
            plain._inspectorDialog = await _inspectorDialog.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.UnitTemplate.UnitObjects plain)
        {
            await base.PlainToShadowAsync(plain);
            SpecialSettings.Shadow = plain.SpecialSettings;
            await this._dialog.PlainToShadowAsync(plain._dialog);
            await this._alertDialog.PlainToShadowAsync(plain._alertDialog);
            await this._inspectorDialog.PlainToShadowAsync(plain._inspectorDialog);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.UnitTemplate.UnitObjects plain, Pocos.axosimple.UnitTemplate.UnitObjects latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (plain.SpecialSettings != SpecialSettings.LastValue)
                    somethingChanged = true;
                if (await _dialog.DetectsAnyChangeAsync(plain._dialog, latest._dialog))
                    somethingChanged = true;
                if (await _alertDialog.DetectsAnyChangeAsync(plain._alertDialog, latest._alertDialog))
                    somethingChanged = true;
                if (await _inspectorDialog.DetectsAnyChangeAsync(plain._inspectorDialog, latest._inspectorDialog))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.UnitTemplate.UnitObjects CreateEmptyPoco()
        {
            return new Pocos.axosimple.UnitTemplate.UnitObjects();
        }
    }
}