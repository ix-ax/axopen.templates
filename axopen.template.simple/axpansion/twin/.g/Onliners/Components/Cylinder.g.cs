using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;
using AXOpen.Core;
using AXOpen.Messaging;
using AXOpen.Messaging.Static;

namespace AXOpen.Pneumatics
{
    public partial class Cylinder : AXOpen.Core.AxoComponent
    {
        [Container(Layout.Wrap)]
        [ComponentHeader()]
        public AXOpen.Core.AxoTask MoveToWork { get; }

        [ComponentHeader()]
        public AXOpen.Core.AxoTask Stop { get; }

        [ComponentHeader()]
        public AXOpen.Core.AxoTask MoveToHome { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Signals")]
        [ReadOnly()]
        public OnlinerBool _HomeSensor { get; }

        [ComponentDetails("Signals")]
        [ReadOnly()]
        public OnlinerBool _WorkSensor { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Signals")]
        [ReadOnly()]
        public OnlinerBool _MoveHomeSignal { get; }

        [ComponentDetails("Signals")]
        [ReadOnly()]
        public OnlinerBool _MoveWorkSignal { get; }

        public AXOpen.Messaging.Static.AxoMessenger _MoveToWorkNotReached { get; }

        public AXOpen.Messaging.Static.AxoMessenger _MoveToHomeNotReached { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public Cylinder(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            MoveToWork = new AXOpen.Core.AxoTask(this, "MoveToWork", "MoveToWork");
            Stop = new AXOpen.Core.AxoTask(this, "Stop", "Stop");
            MoveToHome = new AXOpen.Core.AxoTask(this, "MoveToHome", "MoveToHome");
            _HomeSensor = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "<#Home sensor#>", "_HomeSensor");
            _HomeSensor.AttributeName = "<#Home sensor#>";
            _HomeSensor.MakeReadOnly();
            _WorkSensor = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "<#Work sensor#>", "_WorkSensor");
            _WorkSensor.AttributeName = "<#Work sensor#>";
            _WorkSensor.MakeReadOnly();
            _MoveHomeSignal = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "<#Move home signal#>", "_MoveHomeSignal");
            _MoveHomeSignal.AttributeName = "<#Move home signal#>";
            _MoveHomeSignal.MakeReadOnly();
            _MoveWorkSignal = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "<#Move work signal#>", "_MoveWorkSignal");
            _MoveWorkSignal.AttributeName = "<#Move work signal#>";
            _MoveWorkSignal.MakeReadOnly();
            _MoveToWorkNotReached = new AXOpen.Messaging.Static.AxoMessenger(this, "_MoveToWorkNotReached", "_MoveToWorkNotReached");
            _MoveToWorkNotReached.MessageText = "<#Move to work position did not succeed.#>";
            _MoveToWorkNotReached.Help = "<#Check the cyclinder that it is free to move, check that the air pressure reaches... and extremity sensor.#>";
            _MoveToHomeNotReached = new AXOpen.Messaging.Static.AxoMessenger(this, "_MoveToHomeNotReached", "_MoveToHomeNotReached");
            _MoveToHomeNotReached.MessageText = "<#Move to home position did not succeed.#>";
            _MoveToHomeNotReached.Help = "<#Check the cyclinder that it is free to move, check that the air pressure reaches... and extremity sensor.#>";
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.AXOpen.Pneumatics.Cylinder> OnlineToPlainAsync()
        {
            Pocos.AXOpen.Pneumatics.Cylinder plain = new Pocos.AXOpen.Pneumatics.Cylinder();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToWork = await MoveToWork._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Stop = await Stop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToHome = await MoveToHome._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain._HomeSensor = _HomeSensor.LastValue;
            plain._WorkSensor = _WorkSensor.LastValue;
            plain._MoveHomeSignal = _MoveHomeSignal.LastValue;
            plain._MoveWorkSignal = _MoveWorkSignal.LastValue;
#pragma warning disable CS0612
            plain._MoveToWorkNotReached = await _MoveToWorkNotReached._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._MoveToHomeNotReached = await _MoveToHomeNotReached._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.AXOpen.Pneumatics.Cylinder> _OnlineToPlainNoacAsync()
        {
            Pocos.AXOpen.Pneumatics.Cylinder plain = new Pocos.AXOpen.Pneumatics.Cylinder();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToWork = await MoveToWork._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Stop = await Stop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToHome = await MoveToHome._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain._HomeSensor = _HomeSensor.LastValue;
            plain._WorkSensor = _WorkSensor.LastValue;
            plain._MoveHomeSignal = _MoveHomeSignal.LastValue;
            plain._MoveWorkSignal = _MoveWorkSignal.LastValue;
#pragma warning disable CS0612
            plain._MoveToWorkNotReached = await _MoveToWorkNotReached._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._MoveToHomeNotReached = await _MoveToHomeNotReached._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.AXOpen.Pneumatics.Cylinder> _OnlineToPlainNoacAsync(Pocos.AXOpen.Pneumatics.Cylinder plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToWork = await MoveToWork._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Stop = await Stop._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToHome = await MoveToHome._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            plain._HomeSensor = _HomeSensor.LastValue;
            plain._WorkSensor = _WorkSensor.LastValue;
            plain._MoveHomeSignal = _MoveHomeSignal.LastValue;
            plain._MoveWorkSignal = _MoveWorkSignal.LastValue;
#pragma warning disable CS0612
            plain._MoveToWorkNotReached = await _MoveToWorkNotReached._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain._MoveToHomeNotReached = await _MoveToHomeNotReached._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.AXOpen.Pneumatics.Cylinder plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.MoveToWork._PlainToOnlineNoacAsync(plain.MoveToWork);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Stop._PlainToOnlineNoacAsync(plain.Stop);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.MoveToHome._PlainToOnlineNoacAsync(plain.MoveToHome);
#pragma warning restore CS0612
#pragma warning disable CS0612
            _HomeSensor.LethargicWrite(plain._HomeSensor);
#pragma warning restore CS0612
#pragma warning disable CS0612
            _WorkSensor.LethargicWrite(plain._WorkSensor);
#pragma warning restore CS0612
#pragma warning disable CS0612
            _MoveHomeSignal.LethargicWrite(plain._MoveHomeSignal);
#pragma warning restore CS0612
#pragma warning disable CS0612
            _MoveWorkSignal.LethargicWrite(plain._MoveWorkSignal);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._MoveToWorkNotReached._PlainToOnlineNoacAsync(plain._MoveToWorkNotReached);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._MoveToHomeNotReached._PlainToOnlineNoacAsync(plain._MoveToHomeNotReached);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.AXOpen.Pneumatics.Cylinder plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.MoveToWork._PlainToOnlineNoacAsync(plain.MoveToWork);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Stop._PlainToOnlineNoacAsync(plain.Stop);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.MoveToHome._PlainToOnlineNoacAsync(plain.MoveToHome);
#pragma warning restore CS0612
#pragma warning disable CS0612
            _HomeSensor.LethargicWrite(plain._HomeSensor);
#pragma warning restore CS0612
#pragma warning disable CS0612
            _WorkSensor.LethargicWrite(plain._WorkSensor);
#pragma warning restore CS0612
#pragma warning disable CS0612
            _MoveHomeSignal.LethargicWrite(plain._MoveHomeSignal);
#pragma warning restore CS0612
#pragma warning disable CS0612
            _MoveWorkSignal.LethargicWrite(plain._MoveWorkSignal);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._MoveToWorkNotReached._PlainToOnlineNoacAsync(plain._MoveToWorkNotReached);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this._MoveToHomeNotReached._PlainToOnlineNoacAsync(plain._MoveToHomeNotReached);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.AXOpen.Pneumatics.Cylinder> ShadowToPlainAsync()
        {
            Pocos.AXOpen.Pneumatics.Cylinder plain = new Pocos.AXOpen.Pneumatics.Cylinder();
            await base.ShadowToPlainAsync(plain);
            plain.MoveToWork = await MoveToWork.ShadowToPlainAsync();
            plain.Stop = await Stop.ShadowToPlainAsync();
            plain.MoveToHome = await MoveToHome.ShadowToPlainAsync();
            plain._HomeSensor = _HomeSensor.Shadow;
            plain._WorkSensor = _WorkSensor.Shadow;
            plain._MoveHomeSignal = _MoveHomeSignal.Shadow;
            plain._MoveWorkSignal = _MoveWorkSignal.Shadow;
            plain._MoveToWorkNotReached = await _MoveToWorkNotReached.ShadowToPlainAsync();
            plain._MoveToHomeNotReached = await _MoveToHomeNotReached.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.AXOpen.Pneumatics.Cylinder> ShadowToPlainAsync(Pocos.AXOpen.Pneumatics.Cylinder plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.MoveToWork = await MoveToWork.ShadowToPlainAsync();
            plain.Stop = await Stop.ShadowToPlainAsync();
            plain.MoveToHome = await MoveToHome.ShadowToPlainAsync();
            plain._HomeSensor = _HomeSensor.Shadow;
            plain._WorkSensor = _WorkSensor.Shadow;
            plain._MoveHomeSignal = _MoveHomeSignal.Shadow;
            plain._MoveWorkSignal = _MoveWorkSignal.Shadow;
            plain._MoveToWorkNotReached = await _MoveToWorkNotReached.ShadowToPlainAsync();
            plain._MoveToHomeNotReached = await _MoveToHomeNotReached.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.AXOpen.Pneumatics.Cylinder plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.MoveToWork.PlainToShadowAsync(plain.MoveToWork);
            await this.Stop.PlainToShadowAsync(plain.Stop);
            await this.MoveToHome.PlainToShadowAsync(plain.MoveToHome);
            _HomeSensor.Shadow = plain._HomeSensor;
            _WorkSensor.Shadow = plain._WorkSensor;
            _MoveHomeSignal.Shadow = plain._MoveHomeSignal;
            _MoveWorkSignal.Shadow = plain._MoveWorkSignal;
            await this._MoveToWorkNotReached.PlainToShadowAsync(plain._MoveToWorkNotReached);
            await this._MoveToHomeNotReached.PlainToShadowAsync(plain._MoveToHomeNotReached);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.AXOpen.Pneumatics.Cylinder plain, Pocos.AXOpen.Pneumatics.Cylinder latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await MoveToWork.DetectsAnyChangeAsync(plain.MoveToWork, latest.MoveToWork))
                    somethingChanged = true;
                if (await Stop.DetectsAnyChangeAsync(plain.Stop, latest.Stop))
                    somethingChanged = true;
                if (await MoveToHome.DetectsAnyChangeAsync(plain.MoveToHome, latest.MoveToHome))
                    somethingChanged = true;
                if (plain._HomeSensor != _HomeSensor.LastValue)
                    somethingChanged = true;
                if (plain._WorkSensor != _WorkSensor.LastValue)
                    somethingChanged = true;
                if (plain._MoveHomeSignal != _MoveHomeSignal.LastValue)
                    somethingChanged = true;
                if (plain._MoveWorkSignal != _MoveWorkSignal.LastValue)
                    somethingChanged = true;
                if (await _MoveToWorkNotReached.DetectsAnyChangeAsync(plain._MoveToWorkNotReached, latest._MoveToWorkNotReached))
                    somethingChanged = true;
                if (await _MoveToHomeNotReached.DetectsAnyChangeAsync(plain._MoveToHomeNotReached, latest._MoveToHomeNotReached))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.AXOpen.Pneumatics.Cylinder CreateEmptyPoco()
        {
            return new Pocos.AXOpen.Pneumatics.Cylinder();
        }
    }
}