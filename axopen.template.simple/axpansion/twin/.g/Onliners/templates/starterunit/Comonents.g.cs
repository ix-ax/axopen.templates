using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.StarterUnitTemplate
{
    public partial class Components : AXOpen.Core.AxoObject
    {
        public AXOpen.Components.Pneumatics.AxoCylinder HorizontalCylinder { get; }

        public AXOpen.Components.Pneumatics.AxoCylinder VerticalCylinder { get; }

        public AXOpen.Components.Pneumatics.AxoCylinder GripperCylinder { get; }

        public AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoDataman DMCReader { get; }

        public AXOpen.Elements.AxoDi PartPresenceSensor { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public Components(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            HorizontalCylinder = new AXOpen.Components.Pneumatics.AxoCylinder(this, "HorizontalCylinder", "HorizontalCylinder");
            VerticalCylinder = new AXOpen.Components.Pneumatics.AxoCylinder(this, "VerticalCylinder", "VerticalCylinder");
            GripperCylinder = new AXOpen.Components.Pneumatics.AxoCylinder(this, "GripperCylinder", "GripperCylinder");
            DMCReader = new AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoDataman(this, "DMCReader", "DMCReader");
            PartPresenceSensor = new AXOpen.Elements.AxoDi(this, "PartPresenceSensor", "PartPresenceSensor");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.StarterUnitTemplate.Components> OnlineToPlainAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.Components plain = new Pocos.axosimple.StarterUnitTemplate.Components();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.HorizontalCylinder = await HorizontalCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.VerticalCylinder = await VerticalCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GripperCylinder = await GripperCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DMCReader = await DMCReader._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PartPresenceSensor = await PartPresenceSensor._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.StarterUnitTemplate.Components> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.Components plain = new Pocos.axosimple.StarterUnitTemplate.Components();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.HorizontalCylinder = await HorizontalCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.VerticalCylinder = await VerticalCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GripperCylinder = await GripperCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DMCReader = await DMCReader._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PartPresenceSensor = await PartPresenceSensor._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.StarterUnitTemplate.Components> _OnlineToPlainNoacAsync(Pocos.axosimple.StarterUnitTemplate.Components plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.HorizontalCylinder = await HorizontalCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.VerticalCylinder = await VerticalCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.GripperCylinder = await GripperCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DMCReader = await DMCReader._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.PartPresenceSensor = await PartPresenceSensor._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.StarterUnitTemplate.Components plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.HorizontalCylinder._PlainToOnlineNoacAsync(plain.HorizontalCylinder);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.VerticalCylinder._PlainToOnlineNoacAsync(plain.VerticalCylinder);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.GripperCylinder._PlainToOnlineNoacAsync(plain.GripperCylinder);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DMCReader._PlainToOnlineNoacAsync(plain.DMCReader);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PartPresenceSensor._PlainToOnlineNoacAsync(plain.PartPresenceSensor);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.StarterUnitTemplate.Components plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.HorizontalCylinder._PlainToOnlineNoacAsync(plain.HorizontalCylinder);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.VerticalCylinder._PlainToOnlineNoacAsync(plain.VerticalCylinder);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.GripperCylinder._PlainToOnlineNoacAsync(plain.GripperCylinder);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DMCReader._PlainToOnlineNoacAsync(plain.DMCReader);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.PartPresenceSensor._PlainToOnlineNoacAsync(plain.PartPresenceSensor);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.StarterUnitTemplate.Components> ShadowToPlainAsync()
        {
            Pocos.axosimple.StarterUnitTemplate.Components plain = new Pocos.axosimple.StarterUnitTemplate.Components();
            await base.ShadowToPlainAsync(plain);
            plain.HorizontalCylinder = await HorizontalCylinder.ShadowToPlainAsync();
            plain.VerticalCylinder = await VerticalCylinder.ShadowToPlainAsync();
            plain.GripperCylinder = await GripperCylinder.ShadowToPlainAsync();
            plain.DMCReader = await DMCReader.ShadowToPlainAsync();
            plain.PartPresenceSensor = await PartPresenceSensor.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.StarterUnitTemplate.Components> ShadowToPlainAsync(Pocos.axosimple.StarterUnitTemplate.Components plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.HorizontalCylinder = await HorizontalCylinder.ShadowToPlainAsync();
            plain.VerticalCylinder = await VerticalCylinder.ShadowToPlainAsync();
            plain.GripperCylinder = await GripperCylinder.ShadowToPlainAsync();
            plain.DMCReader = await DMCReader.ShadowToPlainAsync();
            plain.PartPresenceSensor = await PartPresenceSensor.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.StarterUnitTemplate.Components plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.HorizontalCylinder.PlainToShadowAsync(plain.HorizontalCylinder);
            await this.VerticalCylinder.PlainToShadowAsync(plain.VerticalCylinder);
            await this.GripperCylinder.PlainToShadowAsync(plain.GripperCylinder);
            await this.DMCReader.PlainToShadowAsync(plain.DMCReader);
            await this.PartPresenceSensor.PlainToShadowAsync(plain.PartPresenceSensor);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.StarterUnitTemplate.Components plain, Pocos.axosimple.StarterUnitTemplate.Components latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await HorizontalCylinder.DetectsAnyChangeAsync(plain.HorizontalCylinder, latest.HorizontalCylinder))
                    somethingChanged = true;
                if (await VerticalCylinder.DetectsAnyChangeAsync(plain.VerticalCylinder, latest.VerticalCylinder))
                    somethingChanged = true;
                if (await GripperCylinder.DetectsAnyChangeAsync(plain.GripperCylinder, latest.GripperCylinder))
                    somethingChanged = true;
                if (await DMCReader.DetectsAnyChangeAsync(plain.DMCReader, latest.DMCReader))
                    somethingChanged = true;
                if (await PartPresenceSensor.DetectsAnyChangeAsync(plain.PartPresenceSensor, latest.PartPresenceSensor))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.StarterUnitTemplate.Components CreateEmptyPoco()
        {
            return new Pocos.axosimple.StarterUnitTemplate.Components();
        }
    }
}