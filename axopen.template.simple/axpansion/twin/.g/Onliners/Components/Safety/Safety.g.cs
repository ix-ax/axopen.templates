using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.Safety
{
    public partial class BaseZoneLogic : AXOpen.Core.AxoObject, axosimple.Safety.IZone
    {
        public OnlinerBool AllUnitInAuto { get; }

        public OnlinerBool AllUnitInGrounded { get; }

        public OnlinerBool AllUnitInService { get; }

        public OnlinerBool AllKeysMan { get; }

        public OnlinerBool AllKeysAuto { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public BaseZoneLogic(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            AllUnitInAuto = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "AllUnitInAuto", "AllUnitInAuto");
            AllUnitInGrounded = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "AllUnitInGrounded", "AllUnitInGrounded");
            AllUnitInService = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "AllUnitInService", "AllUnitInService");
            AllKeysMan = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "AllKeysMan", "AllKeysMan");
            AllKeysAuto = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "AllKeysAuto", "AllKeysAuto");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Safety.BaseZoneLogic> OnlineToPlainAsync()
        {
            Pocos.axosimple.Safety.BaseZoneLogic plain = new Pocos.axosimple.Safety.BaseZoneLogic();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.AllUnitInAuto = AllUnitInAuto.LastValue;
            plain.AllUnitInGrounded = AllUnitInGrounded.LastValue;
            plain.AllUnitInService = AllUnitInService.LastValue;
            plain.AllKeysMan = AllKeysMan.LastValue;
            plain.AllKeysAuto = AllKeysAuto.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.Safety.BaseZoneLogic> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.Safety.BaseZoneLogic plain = new Pocos.axosimple.Safety.BaseZoneLogic();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.AllUnitInAuto = AllUnitInAuto.LastValue;
            plain.AllUnitInGrounded = AllUnitInGrounded.LastValue;
            plain.AllUnitInService = AllUnitInService.LastValue;
            plain.AllKeysMan = AllKeysMan.LastValue;
            plain.AllKeysAuto = AllKeysAuto.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.Safety.BaseZoneLogic> _OnlineToPlainNoacAsync(Pocos.axosimple.Safety.BaseZoneLogic plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.AllUnitInAuto = AllUnitInAuto.LastValue;
            plain.AllUnitInGrounded = AllUnitInGrounded.LastValue;
            plain.AllUnitInService = AllUnitInService.LastValue;
            plain.AllKeysMan = AllKeysMan.LastValue;
            plain.AllKeysAuto = AllKeysAuto.LastValue;
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.Safety.BaseZoneLogic plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            AllUnitInAuto.LethargicWrite(plain.AllUnitInAuto);
#pragma warning restore CS0612
#pragma warning disable CS0612
            AllUnitInGrounded.LethargicWrite(plain.AllUnitInGrounded);
#pragma warning restore CS0612
#pragma warning disable CS0612
            AllUnitInService.LethargicWrite(plain.AllUnitInService);
#pragma warning restore CS0612
#pragma warning disable CS0612
            AllKeysMan.LethargicWrite(plain.AllKeysMan);
#pragma warning restore CS0612
#pragma warning disable CS0612
            AllKeysAuto.LethargicWrite(plain.AllKeysAuto);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Safety.BaseZoneLogic plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            AllUnitInAuto.LethargicWrite(plain.AllUnitInAuto);
#pragma warning restore CS0612
#pragma warning disable CS0612
            AllUnitInGrounded.LethargicWrite(plain.AllUnitInGrounded);
#pragma warning restore CS0612
#pragma warning disable CS0612
            AllUnitInService.LethargicWrite(plain.AllUnitInService);
#pragma warning restore CS0612
#pragma warning disable CS0612
            AllKeysMan.LethargicWrite(plain.AllKeysMan);
#pragma warning restore CS0612
#pragma warning disable CS0612
            AllKeysAuto.LethargicWrite(plain.AllKeysAuto);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Safety.BaseZoneLogic> ShadowToPlainAsync()
        {
            Pocos.axosimple.Safety.BaseZoneLogic plain = new Pocos.axosimple.Safety.BaseZoneLogic();
            await base.ShadowToPlainAsync(plain);
            plain.AllUnitInAuto = AllUnitInAuto.Shadow;
            plain.AllUnitInGrounded = AllUnitInGrounded.Shadow;
            plain.AllUnitInService = AllUnitInService.Shadow;
            plain.AllKeysMan = AllKeysMan.Shadow;
            plain.AllKeysAuto = AllKeysAuto.Shadow;
            return plain;
        }

        protected async Task<Pocos.axosimple.Safety.BaseZoneLogic> ShadowToPlainAsync(Pocos.axosimple.Safety.BaseZoneLogic plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.AllUnitInAuto = AllUnitInAuto.Shadow;
            plain.AllUnitInGrounded = AllUnitInGrounded.Shadow;
            plain.AllUnitInService = AllUnitInService.Shadow;
            plain.AllKeysMan = AllKeysMan.Shadow;
            plain.AllKeysAuto = AllKeysAuto.Shadow;
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Safety.BaseZoneLogic plain)
        {
            await base.PlainToShadowAsync(plain);
            AllUnitInAuto.Shadow = plain.AllUnitInAuto;
            AllUnitInGrounded.Shadow = plain.AllUnitInGrounded;
            AllUnitInService.Shadow = plain.AllUnitInService;
            AllKeysMan.Shadow = plain.AllKeysMan;
            AllKeysAuto.Shadow = plain.AllKeysAuto;
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.Safety.BaseZoneLogic plain, Pocos.axosimple.Safety.BaseZoneLogic latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (plain.AllUnitInAuto != AllUnitInAuto.LastValue)
                    somethingChanged = true;
                if (plain.AllUnitInGrounded != AllUnitInGrounded.LastValue)
                    somethingChanged = true;
                if (plain.AllUnitInService != AllUnitInService.LastValue)
                    somethingChanged = true;
                if (plain.AllKeysMan != AllKeysMan.LastValue)
                    somethingChanged = true;
                if (plain.AllKeysAuto != AllKeysAuto.LastValue)
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.Safety.BaseZoneLogic CreateEmptyPoco()
        {
            return new Pocos.axosimple.Safety.BaseZoneLogic();
        }
    }

    public partial class ControlPanel : AXOpen.Core.AxoObject, axosimple.Safety.IControlPanel
    {
        public axosimple.Safety.EmergencyStop EStop { get; }

        public AXOpen.Elements.AxoDi ButtonStart { get; }

        public AXOpen.Elements.AxoDi ButtonStop { get; }

        public AXOpen.Elements.AxoDi KeyManual { get; }

        public AXOpen.Elements.AxoDi KeyAuto { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public ControlPanel(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            EStop = new axosimple.Safety.EmergencyStop(this, "EStop", "EStop");
            ButtonStart = new AXOpen.Elements.AxoDi(this, "ButtonStart", "ButtonStart");
            ButtonStop = new AXOpen.Elements.AxoDi(this, "ButtonStop", "ButtonStop");
            KeyManual = new AXOpen.Elements.AxoDi(this, "KeyManual", "KeyManual");
            KeyAuto = new AXOpen.Elements.AxoDi(this, "KeyAuto", "KeyAuto");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Safety.ControlPanel> OnlineToPlainAsync()
        {
            Pocos.axosimple.Safety.ControlPanel plain = new Pocos.axosimple.Safety.ControlPanel();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop = await EStop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ButtonStart = await ButtonStart._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ButtonStop = await ButtonStop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.KeyManual = await KeyManual._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.KeyAuto = await KeyAuto._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.Safety.ControlPanel> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.Safety.ControlPanel plain = new Pocos.axosimple.Safety.ControlPanel();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop = await EStop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ButtonStart = await ButtonStart._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ButtonStop = await ButtonStop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.KeyManual = await KeyManual._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.KeyAuto = await KeyAuto._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.Safety.ControlPanel> _OnlineToPlainNoacAsync(Pocos.axosimple.Safety.ControlPanel plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop = await EStop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ButtonStart = await ButtonStart._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.ButtonStop = await ButtonStop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.KeyManual = await KeyManual._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.KeyAuto = await KeyAuto._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.Safety.ControlPanel plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.EStop._PlainToOnlineNoacAsync(plain.EStop);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ButtonStart._PlainToOnlineNoacAsync(plain.ButtonStart);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ButtonStop._PlainToOnlineNoacAsync(plain.ButtonStop);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.KeyManual._PlainToOnlineNoacAsync(plain.KeyManual);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.KeyAuto._PlainToOnlineNoacAsync(plain.KeyAuto);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Safety.ControlPanel plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.EStop._PlainToOnlineNoacAsync(plain.EStop);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ButtonStart._PlainToOnlineNoacAsync(plain.ButtonStart);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.ButtonStop._PlainToOnlineNoacAsync(plain.ButtonStop);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.KeyManual._PlainToOnlineNoacAsync(plain.KeyManual);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.KeyAuto._PlainToOnlineNoacAsync(plain.KeyAuto);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Safety.ControlPanel> ShadowToPlainAsync()
        {
            Pocos.axosimple.Safety.ControlPanel plain = new Pocos.axosimple.Safety.ControlPanel();
            await base.ShadowToPlainAsync(plain);
            plain.EStop = await EStop.ShadowToPlainAsync();
            plain.ButtonStart = await ButtonStart.ShadowToPlainAsync();
            plain.ButtonStop = await ButtonStop.ShadowToPlainAsync();
            plain.KeyManual = await KeyManual.ShadowToPlainAsync();
            plain.KeyAuto = await KeyAuto.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.Safety.ControlPanel> ShadowToPlainAsync(Pocos.axosimple.Safety.ControlPanel plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.EStop = await EStop.ShadowToPlainAsync();
            plain.ButtonStart = await ButtonStart.ShadowToPlainAsync();
            plain.ButtonStop = await ButtonStop.ShadowToPlainAsync();
            plain.KeyManual = await KeyManual.ShadowToPlainAsync();
            plain.KeyAuto = await KeyAuto.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Safety.ControlPanel plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.EStop.PlainToShadowAsync(plain.EStop);
            await this.ButtonStart.PlainToShadowAsync(plain.ButtonStart);
            await this.ButtonStop.PlainToShadowAsync(plain.ButtonStop);
            await this.KeyManual.PlainToShadowAsync(plain.KeyManual);
            await this.KeyAuto.PlainToShadowAsync(plain.KeyAuto);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.Safety.ControlPanel plain, Pocos.axosimple.Safety.ControlPanel latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await EStop.DetectsAnyChangeAsync(plain.EStop, latest.EStop))
                    somethingChanged = true;
                if (await ButtonStart.DetectsAnyChangeAsync(plain.ButtonStart, latest.ButtonStart))
                    somethingChanged = true;
                if (await ButtonStop.DetectsAnyChangeAsync(plain.ButtonStop, latest.ButtonStop))
                    somethingChanged = true;
                if (await KeyManual.DetectsAnyChangeAsync(plain.KeyManual, latest.KeyManual))
                    somethingChanged = true;
                if (await KeyAuto.DetectsAnyChangeAsync(plain.KeyAuto, latest.KeyAuto))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.Safety.ControlPanel CreateEmptyPoco()
        {
            return new Pocos.axosimple.Safety.ControlPanel();
        }
    }

    public partial class Door : AXOpen.Core.AxoObject, axosimple.Safety.IDoor
    {
        public AXOpen.Components.Pneumatics.AxoCylinder Lock { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public Door(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Lock = new AXOpen.Components.Pneumatics.AxoCylinder(this, "Lock", "Lock");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Safety.Door> OnlineToPlainAsync()
        {
            Pocos.axosimple.Safety.Door plain = new Pocos.axosimple.Safety.Door();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Lock = await Lock._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.Safety.Door> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.Safety.Door plain = new Pocos.axosimple.Safety.Door();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Lock = await Lock._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.Safety.Door> _OnlineToPlainNoacAsync(Pocos.axosimple.Safety.Door plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Lock = await Lock._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.Safety.Door plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Lock._PlainToOnlineNoacAsync(plain.Lock);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Safety.Door plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Lock._PlainToOnlineNoacAsync(plain.Lock);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Safety.Door> ShadowToPlainAsync()
        {
            Pocos.axosimple.Safety.Door plain = new Pocos.axosimple.Safety.Door();
            await base.ShadowToPlainAsync(plain);
            plain.Lock = await Lock.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.Safety.Door> ShadowToPlainAsync(Pocos.axosimple.Safety.Door plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Lock = await Lock.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Safety.Door plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.Lock.PlainToShadowAsync(plain.Lock);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.Safety.Door plain, Pocos.axosimple.Safety.Door latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await Lock.DetectsAnyChangeAsync(plain.Lock, latest.Lock))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.Safety.Door CreateEmptyPoco()
        {
            return new Pocos.axosimple.Safety.Door();
        }
    }

    public partial class EmergencyStop : AXOpen.Elements.AxoDi, axosimple.Safety.IEmergencyStop
    {
        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public EmergencyStop(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Safety.EmergencyStop> OnlineToPlainAsync()
        {
            Pocos.axosimple.Safety.EmergencyStop plain = new Pocos.axosimple.Safety.EmergencyStop();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.Safety.EmergencyStop> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.Safety.EmergencyStop plain = new Pocos.axosimple.Safety.EmergencyStop();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.Safety.EmergencyStop> _OnlineToPlainNoacAsync(Pocos.axosimple.Safety.EmergencyStop plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.Safety.EmergencyStop plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.Safety.EmergencyStop plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.Safety.EmergencyStop> ShadowToPlainAsync()
        {
            Pocos.axosimple.Safety.EmergencyStop plain = new Pocos.axosimple.Safety.EmergencyStop();
            await base.ShadowToPlainAsync(plain);
            return plain;
        }

        protected async Task<Pocos.axosimple.Safety.EmergencyStop> ShadowToPlainAsync(Pocos.axosimple.Safety.EmergencyStop plain)
        {
            await base.ShadowToPlainAsync(plain);
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.Safety.EmergencyStop plain)
        {
            await base.PlainToShadowAsync(plain);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.Safety.EmergencyStop plain, Pocos.axosimple.Safety.EmergencyStop latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.Safety.EmergencyStop CreateEmptyPoco()
        {
            return new Pocos.axosimple.Safety.EmergencyStop();
        }
    }
}