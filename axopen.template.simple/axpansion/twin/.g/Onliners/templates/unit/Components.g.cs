using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple.UnitTemplate
{
    public partial class Components : AXOpen.Core.AxoObject
    {
        public AXOpen.Elements.AxoDi DI_1 { get; }

        public AXOpen.Elements.AxoDi DI_2 { get; }

        public AXOpen.Elements.AxoDo DO_1 { get; }

        public AXOpen.Elements.AxoDo DO_2 { get; }

        public AXOpen.Elements.AxoAi AI_1 { get; }

        public AXOpen.Elements.AxoAi AI_2 { get; }

        public AXOpen.Elements.AxoAo AO_1 { get; }

        public AXOpen.Elements.AxoAo AO_2 { get; }

        public AXOpen.Components.Pneumatics.AxoCylinder Cylinder_1 { get; }

        public AXOpen.Components.Pneumatics.AxoCylinder Cylinder_2 { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public Components(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            DI_1 = new AXOpen.Elements.AxoDi(this, "DI_1", "DI_1");
            DI_2 = new AXOpen.Elements.AxoDi(this, "DI_2", "DI_2");
            DO_1 = new AXOpen.Elements.AxoDo(this, "DO_1", "DO_1");
            DO_2 = new AXOpen.Elements.AxoDo(this, "DO_2", "DO_2");
            AI_1 = new AXOpen.Elements.AxoAi(this, "AI_1", "AI_1");
            AI_2 = new AXOpen.Elements.AxoAi(this, "AI_2", "AI_2");
            AO_1 = new AXOpen.Elements.AxoAo(this, "AO_1", "AO_1");
            AO_2 = new AXOpen.Elements.AxoAo(this, "AO_2", "AO_2");
            Cylinder_1 = new AXOpen.Components.Pneumatics.AxoCylinder(this, "Cylinder_1", "Cylinder_1");
            Cylinder_2 = new AXOpen.Components.Pneumatics.AxoCylinder(this, "Cylinder_2", "Cylinder_2");
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.UnitTemplate.Components> OnlineToPlainAsync()
        {
            Pocos.axosimple.UnitTemplate.Components plain = new Pocos.axosimple.UnitTemplate.Components();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DI_1 = await DI_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DI_2 = await DI_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DO_1 = await DO_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DO_2 = await DO_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AI_1 = await AI_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AI_2 = await AI_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AO_1 = await AO_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AO_2 = await AO_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Cylinder_1 = await Cylinder_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Cylinder_2 = await Cylinder_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.UnitTemplate.Components> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.UnitTemplate.Components plain = new Pocos.axosimple.UnitTemplate.Components();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DI_1 = await DI_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DI_2 = await DI_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DO_1 = await DO_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DO_2 = await DO_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AI_1 = await AI_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AI_2 = await AI_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AO_1 = await AO_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AO_2 = await AO_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Cylinder_1 = await Cylinder_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Cylinder_2 = await Cylinder_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.UnitTemplate.Components> _OnlineToPlainNoacAsync(Pocos.axosimple.UnitTemplate.Components plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DI_1 = await DI_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DI_2 = await DI_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DO_1 = await DO_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.DO_2 = await DO_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AI_1 = await AI_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AI_2 = await AI_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AO_1 = await AO_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.AO_2 = await AO_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Cylinder_1 = await Cylinder_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Cylinder_2 = await Cylinder_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.UnitTemplate.Components plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.DI_1._PlainToOnlineNoacAsync(plain.DI_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DI_2._PlainToOnlineNoacAsync(plain.DI_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DO_1._PlainToOnlineNoacAsync(plain.DO_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DO_2._PlainToOnlineNoacAsync(plain.DO_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AI_1._PlainToOnlineNoacAsync(plain.AI_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AI_2._PlainToOnlineNoacAsync(plain.AI_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AO_1._PlainToOnlineNoacAsync(plain.AO_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AO_2._PlainToOnlineNoacAsync(plain.AO_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Cylinder_1._PlainToOnlineNoacAsync(plain.Cylinder_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Cylinder_2._PlainToOnlineNoacAsync(plain.Cylinder_2);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.UnitTemplate.Components plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.DI_1._PlainToOnlineNoacAsync(plain.DI_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DI_2._PlainToOnlineNoacAsync(plain.DI_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DO_1._PlainToOnlineNoacAsync(plain.DO_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.DO_2._PlainToOnlineNoacAsync(plain.DO_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AI_1._PlainToOnlineNoacAsync(plain.AI_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AI_2._PlainToOnlineNoacAsync(plain.AI_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AO_1._PlainToOnlineNoacAsync(plain.AO_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.AO_2._PlainToOnlineNoacAsync(plain.AO_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Cylinder_1._PlainToOnlineNoacAsync(plain.Cylinder_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Cylinder_2._PlainToOnlineNoacAsync(plain.Cylinder_2);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.UnitTemplate.Components> ShadowToPlainAsync()
        {
            Pocos.axosimple.UnitTemplate.Components plain = new Pocos.axosimple.UnitTemplate.Components();
            await base.ShadowToPlainAsync(plain);
            plain.DI_1 = await DI_1.ShadowToPlainAsync();
            plain.DI_2 = await DI_2.ShadowToPlainAsync();
            plain.DO_1 = await DO_1.ShadowToPlainAsync();
            plain.DO_2 = await DO_2.ShadowToPlainAsync();
            plain.AI_1 = await AI_1.ShadowToPlainAsync();
            plain.AI_2 = await AI_2.ShadowToPlainAsync();
            plain.AO_1 = await AO_1.ShadowToPlainAsync();
            plain.AO_2 = await AO_2.ShadowToPlainAsync();
            plain.Cylinder_1 = await Cylinder_1.ShadowToPlainAsync();
            plain.Cylinder_2 = await Cylinder_2.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.axosimple.UnitTemplate.Components> ShadowToPlainAsync(Pocos.axosimple.UnitTemplate.Components plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.DI_1 = await DI_1.ShadowToPlainAsync();
            plain.DI_2 = await DI_2.ShadowToPlainAsync();
            plain.DO_1 = await DO_1.ShadowToPlainAsync();
            plain.DO_2 = await DO_2.ShadowToPlainAsync();
            plain.AI_1 = await AI_1.ShadowToPlainAsync();
            plain.AI_2 = await AI_2.ShadowToPlainAsync();
            plain.AO_1 = await AO_1.ShadowToPlainAsync();
            plain.AO_2 = await AO_2.ShadowToPlainAsync();
            plain.Cylinder_1 = await Cylinder_1.ShadowToPlainAsync();
            plain.Cylinder_2 = await Cylinder_2.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.UnitTemplate.Components plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.DI_1.PlainToShadowAsync(plain.DI_1);
            await this.DI_2.PlainToShadowAsync(plain.DI_2);
            await this.DO_1.PlainToShadowAsync(plain.DO_1);
            await this.DO_2.PlainToShadowAsync(plain.DO_2);
            await this.AI_1.PlainToShadowAsync(plain.AI_1);
            await this.AI_2.PlainToShadowAsync(plain.AI_2);
            await this.AO_1.PlainToShadowAsync(plain.AO_1);
            await this.AO_2.PlainToShadowAsync(plain.AO_2);
            await this.Cylinder_1.PlainToShadowAsync(plain.Cylinder_1);
            await this.Cylinder_2.PlainToShadowAsync(plain.Cylinder_2);
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.UnitTemplate.Components plain, Pocos.axosimple.UnitTemplate.Components latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await DI_1.DetectsAnyChangeAsync(plain.DI_1, latest.DI_1))
                    somethingChanged = true;
                if (await DI_2.DetectsAnyChangeAsync(plain.DI_2, latest.DI_2))
                    somethingChanged = true;
                if (await DO_1.DetectsAnyChangeAsync(plain.DO_1, latest.DO_1))
                    somethingChanged = true;
                if (await DO_2.DetectsAnyChangeAsync(plain.DO_2, latest.DO_2))
                    somethingChanged = true;
                if (await AI_1.DetectsAnyChangeAsync(plain.AI_1, latest.AI_1))
                    somethingChanged = true;
                if (await AI_2.DetectsAnyChangeAsync(plain.AI_2, latest.AI_2))
                    somethingChanged = true;
                if (await AO_1.DetectsAnyChangeAsync(plain.AO_1, latest.AO_1))
                    somethingChanged = true;
                if (await AO_2.DetectsAnyChangeAsync(plain.AO_2, latest.AO_2))
                    somethingChanged = true;
                if (await Cylinder_1.DetectsAnyChangeAsync(plain.Cylinder_1, latest.Cylinder_1))
                    somethingChanged = true;
                if (await Cylinder_2.DetectsAnyChangeAsync(plain.Cylinder_2, latest.Cylinder_2))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.UnitTemplate.Components CreateEmptyPoco()
        {
            return new Pocos.axosimple.UnitTemplate.Components();
        }
    }
}