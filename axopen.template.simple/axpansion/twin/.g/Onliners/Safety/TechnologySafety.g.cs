using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple
{
    public partial class TechnologySafety : AXOpen.Core.AxoObject
    {
        public axosimple.SafetyZone_1 Zone_1 { get; }

        public axosimple.SafetyZone_2 Zone_2 { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public TechnologySafety(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            Zone_1 = new axosimple.SafetyZone_1(this, "Zone_1", "Zone_1");
            Zone_2 = new axosimple.SafetyZone_2(this, "Zone_2", "Zone_2");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.TechnologySafety> OnlineToPlainAsync()
        {
            Pocos.axosimple.TechnologySafety plain = new Pocos.axosimple.TechnologySafety();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Zone_1 = await Zone_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Zone_2 = await Zone_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.TechnologySafety> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.TechnologySafety plain = new Pocos.axosimple.TechnologySafety();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Zone_1 = await Zone_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Zone_2 = await Zone_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.TechnologySafety> _OnlineToPlainNoacAsync(Pocos.axosimple.TechnologySafety plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Zone_1 = await Zone_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Zone_2 = await Zone_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.TechnologySafety plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Zone_1._PlainToOnlineNoacAsync(plain.Zone_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Zone_2._PlainToOnlineNoacAsync(plain.Zone_2);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.TechnologySafety plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.Zone_1._PlainToOnlineNoacAsync(plain.Zone_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Zone_2._PlainToOnlineNoacAsync(plain.Zone_2);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.TechnologySafety> ShadowToPlainAsync()
        {
            Pocos.axosimple.TechnologySafety plain = new Pocos.axosimple.TechnologySafety();
            await base.ShadowToPlainAsync(plain);
            plain.Zone_1 = await Zone_1.ShadowToPlainAsync();
            plain.Zone_2 = await Zone_2.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.TechnologySafety> ShadowToPlainAsync(Pocos.axosimple.TechnologySafety plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.Zone_1 = await Zone_1.ShadowToPlainAsync();
            plain.Zone_2 = await Zone_2.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.TechnologySafety plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.Zone_1.PlainToShadowAsync(plain.Zone_1);
            await this.Zone_2.PlainToShadowAsync(plain.Zone_2);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.TechnologySafety plain, Pocos.axosimple.TechnologySafety latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await Zone_1.DetectsAnyChangeAsync(plain.Zone_1, latest.Zone_1))
                    somethingChanged = true;
                if (await Zone_2.DetectsAnyChangeAsync(plain.Zone_2, latest.Zone_2))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.TechnologySafety CreateEmptyPoco()
        {
            return new Pocos.axosimple.TechnologySafety();
        }
    }

    public partial class SafetyZone_1 : AXOpen.Core.AxoObject
    {
        public axosimple.Safety.BaseZoneLogic LogicController { get; }

        public axosimple.Safety.ControlPanel Panel_1 { get; }

        public axosimple.Safety.ControlPanel Panel_2 { get; }

        public axosimple.Safety.EmergencyStop EStop_External_1 { get; }

        public axosimple.Safety.EmergencyStop EStop_External_2 { get; }

        public axosimple.Safety.Door Door_1 { get; }

        public axosimple.Safety.Door Door_2 { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public SafetyZone_1(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            LogicController = new axosimple.Safety.BaseZoneLogic(this, "LogicController", "LogicController");
            Panel_1 = new axosimple.Safety.ControlPanel(this, "Panel_1", "Panel_1");
            Panel_2 = new axosimple.Safety.ControlPanel(this, "Panel_2", "Panel_2");
            EStop_External_1 = new axosimple.Safety.EmergencyStop(this, "EStop_External_1", "EStop_External_1");
            EStop_External_2 = new axosimple.Safety.EmergencyStop(this, "EStop_External_2", "EStop_External_2");
            Door_1 = new axosimple.Safety.Door(this, "Door_1", "Door_1");
            Door_2 = new axosimple.Safety.Door(this, "Door_2", "Door_2");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.SafetyZone_1> OnlineToPlainAsync()
        {
            Pocos.axosimple.SafetyZone_1 plain = new Pocos.axosimple.SafetyZone_1();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LogicController = await LogicController._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_1 = await Panel_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_2 = await Panel_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_1 = await EStop_External_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_2 = await EStop_External_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_1 = await Door_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_2 = await Door_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.SafetyZone_1> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.SafetyZone_1 plain = new Pocos.axosimple.SafetyZone_1();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LogicController = await LogicController._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_1 = await Panel_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_2 = await Panel_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_1 = await EStop_External_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_2 = await EStop_External_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_1 = await Door_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_2 = await Door_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.SafetyZone_1> _OnlineToPlainNoacAsync(Pocos.axosimple.SafetyZone_1 plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LogicController = await LogicController._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_1 = await Panel_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_2 = await Panel_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_1 = await EStop_External_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_2 = await EStop_External_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_1 = await Door_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_2 = await Door_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.SafetyZone_1 plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.LogicController._PlainToOnlineNoacAsync(plain.LogicController);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Panel_1._PlainToOnlineNoacAsync(plain.Panel_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Panel_2._PlainToOnlineNoacAsync(plain.Panel_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.EStop_External_1._PlainToOnlineNoacAsync(plain.EStop_External_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.EStop_External_2._PlainToOnlineNoacAsync(plain.EStop_External_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Door_1._PlainToOnlineNoacAsync(plain.Door_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Door_2._PlainToOnlineNoacAsync(plain.Door_2);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.SafetyZone_1 plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.LogicController._PlainToOnlineNoacAsync(plain.LogicController);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Panel_1._PlainToOnlineNoacAsync(plain.Panel_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Panel_2._PlainToOnlineNoacAsync(plain.Panel_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.EStop_External_1._PlainToOnlineNoacAsync(plain.EStop_External_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.EStop_External_2._PlainToOnlineNoacAsync(plain.EStop_External_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Door_1._PlainToOnlineNoacAsync(plain.Door_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Door_2._PlainToOnlineNoacAsync(plain.Door_2);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.SafetyZone_1> ShadowToPlainAsync()
        {
            Pocos.axosimple.SafetyZone_1 plain = new Pocos.axosimple.SafetyZone_1();
            await base.ShadowToPlainAsync(plain);
            plain.LogicController = await LogicController.ShadowToPlainAsync();
            plain.Panel_1 = await Panel_1.ShadowToPlainAsync();
            plain.Panel_2 = await Panel_2.ShadowToPlainAsync();
            plain.EStop_External_1 = await EStop_External_1.ShadowToPlainAsync();
            plain.EStop_External_2 = await EStop_External_2.ShadowToPlainAsync();
            plain.Door_1 = await Door_1.ShadowToPlainAsync();
            plain.Door_2 = await Door_2.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.SafetyZone_1> ShadowToPlainAsync(Pocos.axosimple.SafetyZone_1 plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.LogicController = await LogicController.ShadowToPlainAsync();
            plain.Panel_1 = await Panel_1.ShadowToPlainAsync();
            plain.Panel_2 = await Panel_2.ShadowToPlainAsync();
            plain.EStop_External_1 = await EStop_External_1.ShadowToPlainAsync();
            plain.EStop_External_2 = await EStop_External_2.ShadowToPlainAsync();
            plain.Door_1 = await Door_1.ShadowToPlainAsync();
            plain.Door_2 = await Door_2.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.SafetyZone_1 plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.LogicController.PlainToShadowAsync(plain.LogicController);
            await this.Panel_1.PlainToShadowAsync(plain.Panel_1);
            await this.Panel_2.PlainToShadowAsync(plain.Panel_2);
            await this.EStop_External_1.PlainToShadowAsync(plain.EStop_External_1);
            await this.EStop_External_2.PlainToShadowAsync(plain.EStop_External_2);
            await this.Door_1.PlainToShadowAsync(plain.Door_1);
            await this.Door_2.PlainToShadowAsync(plain.Door_2);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.SafetyZone_1 plain, Pocos.axosimple.SafetyZone_1 latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await LogicController.DetectsAnyChangeAsync(plain.LogicController, latest.LogicController))
                    somethingChanged = true;
                if (await Panel_1.DetectsAnyChangeAsync(plain.Panel_1, latest.Panel_1))
                    somethingChanged = true;
                if (await Panel_2.DetectsAnyChangeAsync(plain.Panel_2, latest.Panel_2))
                    somethingChanged = true;
                if (await EStop_External_1.DetectsAnyChangeAsync(plain.EStop_External_1, latest.EStop_External_1))
                    somethingChanged = true;
                if (await EStop_External_2.DetectsAnyChangeAsync(plain.EStop_External_2, latest.EStop_External_2))
                    somethingChanged = true;
                if (await Door_1.DetectsAnyChangeAsync(plain.Door_1, latest.Door_1))
                    somethingChanged = true;
                if (await Door_2.DetectsAnyChangeAsync(plain.Door_2, latest.Door_2))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.SafetyZone_1 CreateEmptyPoco()
        {
            return new Pocos.axosimple.SafetyZone_1();
        }
    }

    public partial class SafetyZone_2 : AXOpen.Core.AxoObject
    {
        public axosimple.Safety.BaseZoneLogic LogicController { get; }

        public axosimple.Safety.ControlPanel Panel_1 { get; }

        public axosimple.Safety.EmergencyStop EStop_External_1 { get; }

        public axosimple.Safety.Door Door_1 { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public SafetyZone_2(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            LogicController = new axosimple.Safety.BaseZoneLogic(this, "LogicController", "LogicController");
            Panel_1 = new axosimple.Safety.ControlPanel(this, "Panel_1", "Panel_1");
            EStop_External_1 = new axosimple.Safety.EmergencyStop(this, "EStop_External_1", "EStop_External_1");
            Door_1 = new axosimple.Safety.Door(this, "Door_1", "Door_1");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.SafetyZone_2> OnlineToPlainAsync()
        {
            Pocos.axosimple.SafetyZone_2 plain = new Pocos.axosimple.SafetyZone_2();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LogicController = await LogicController._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_1 = await Panel_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_1 = await EStop_External_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_1 = await Door_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.SafetyZone_2> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.SafetyZone_2 plain = new Pocos.axosimple.SafetyZone_2();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LogicController = await LogicController._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_1 = await Panel_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_1 = await EStop_External_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_1 = await Door_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.SafetyZone_2> _OnlineToPlainNoacAsync(Pocos.axosimple.SafetyZone_2 plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.LogicController = await LogicController._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Panel_1 = await Panel_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.EStop_External_1 = await EStop_External_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Door_1 = await Door_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.SafetyZone_2 plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.LogicController._PlainToOnlineNoacAsync(plain.LogicController);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Panel_1._PlainToOnlineNoacAsync(plain.Panel_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.EStop_External_1._PlainToOnlineNoacAsync(plain.EStop_External_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Door_1._PlainToOnlineNoacAsync(plain.Door_1);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.SafetyZone_2 plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.LogicController._PlainToOnlineNoacAsync(plain.LogicController);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Panel_1._PlainToOnlineNoacAsync(plain.Panel_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.EStop_External_1._PlainToOnlineNoacAsync(plain.EStop_External_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Door_1._PlainToOnlineNoacAsync(plain.Door_1);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.SafetyZone_2> ShadowToPlainAsync()
        {
            Pocos.axosimple.SafetyZone_2 plain = new Pocos.axosimple.SafetyZone_2();
            await base.ShadowToPlainAsync(plain);
            plain.LogicController = await LogicController.ShadowToPlainAsync();
            plain.Panel_1 = await Panel_1.ShadowToPlainAsync();
            plain.EStop_External_1 = await EStop_External_1.ShadowToPlainAsync();
            plain.Door_1 = await Door_1.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.SafetyZone_2> ShadowToPlainAsync(Pocos.axosimple.SafetyZone_2 plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.LogicController = await LogicController.ShadowToPlainAsync();
            plain.Panel_1 = await Panel_1.ShadowToPlainAsync();
            plain.EStop_External_1 = await EStop_External_1.ShadowToPlainAsync();
            plain.Door_1 = await Door_1.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.SafetyZone_2 plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.LogicController.PlainToShadowAsync(plain.LogicController);
            await this.Panel_1.PlainToShadowAsync(plain.Panel_1);
            await this.EStop_External_1.PlainToShadowAsync(plain.EStop_External_1);
            await this.Door_1.PlainToShadowAsync(plain.Door_1);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.SafetyZone_2 plain, Pocos.axosimple.SafetyZone_2 latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await LogicController.DetectsAnyChangeAsync(plain.LogicController, latest.LogicController))
                    somethingChanged = true;
                if (await Panel_1.DetectsAnyChangeAsync(plain.Panel_1, latest.Panel_1))
                    somethingChanged = true;
                if (await EStop_External_1.DetectsAnyChangeAsync(plain.EStop_External_1, latest.EStop_External_1))
                    somethingChanged = true;
                if (await Door_1.DetectsAnyChangeAsync(plain.Door_1, latest.Door_1))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.SafetyZone_2 CreateEmptyPoco()
        {
            return new Pocos.axosimple.SafetyZone_2();
        }
    }
}