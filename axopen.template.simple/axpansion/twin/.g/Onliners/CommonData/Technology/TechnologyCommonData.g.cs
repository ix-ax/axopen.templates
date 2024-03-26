using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace axosimple
{
    public partial class TechnologyCommonData : AXOpen.Data.AxoDataEntity
    {
        public OnlinerTime IdealCycleTime { get; }

        public OnlinerTime WarningCycleTime { get; }

        public OnlinerTime ErrorCycleTime { get; }

        public OnlinerTime TimeToEntryEnergySavingMode { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public TechnologyCommonData(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            IdealCycleTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Cycle time#> - <#Nominal#>", "IdealCycleTime");
            IdealCycleTime.AttributeName = "<#Cycle time#> - <#Nominal#>";
            WarningCycleTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Cycle time#> - <#Warning#>", "WarningCycleTime");
            WarningCycleTime.AttributeName = "<#Cycle time#> - <#Warning#>";
            ErrorCycleTime = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Cycle time#> - <#Error#>", "ErrorCycleTime");
            ErrorCycleTime.AttributeName = "<#Cycle time#> - <#Error#>";
            TimeToEntryEnergySavingMode = @Connector.ConnectorAdapter.AdapterFactory.CreateTIME(this, "<#Energy saving mode - Inactivity time#>", "TimeToEntryEnergySavingMode");
            TimeToEntryEnergySavingMode.AttributeName = "<#Energy saving mode - Inactivity time#> ";
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.axosimple.TechnologyCommonData> OnlineToPlainAsync()
        {
            Pocos.axosimple.TechnologyCommonData plain = new Pocos.axosimple.TechnologyCommonData();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.IdealCycleTime = IdealCycleTime.LastValue;
            plain.WarningCycleTime = WarningCycleTime.LastValue;
            plain.ErrorCycleTime = ErrorCycleTime.LastValue;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.axosimple.TechnologyCommonData> _OnlineToPlainNoacAsync()
        {
            Pocos.axosimple.TechnologyCommonData plain = new Pocos.axosimple.TechnologyCommonData();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.IdealCycleTime = IdealCycleTime.LastValue;
            plain.WarningCycleTime = WarningCycleTime.LastValue;
            plain.ErrorCycleTime = ErrorCycleTime.LastValue;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.LastValue;
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.axosimple.TechnologyCommonData> _OnlineToPlainNoacAsync(Pocos.axosimple.TechnologyCommonData plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
            plain.IdealCycleTime = IdealCycleTime.LastValue;
            plain.WarningCycleTime = WarningCycleTime.LastValue;
            plain.ErrorCycleTime = ErrorCycleTime.LastValue;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.LastValue;
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.axosimple.TechnologyCommonData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            IdealCycleTime.LethargicWrite(plain.IdealCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            WarningCycleTime.LethargicWrite(plain.WarningCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ErrorCycleTime.LethargicWrite(plain.ErrorCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            TimeToEntryEnergySavingMode.LethargicWrite(plain.TimeToEntryEnergySavingMode);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.axosimple.TechnologyCommonData plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            IdealCycleTime.LethargicWrite(plain.IdealCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            WarningCycleTime.LethargicWrite(plain.WarningCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            ErrorCycleTime.LethargicWrite(plain.ErrorCycleTime);
#pragma warning restore CS0612
#pragma warning disable CS0612
            TimeToEntryEnergySavingMode.LethargicWrite(plain.TimeToEntryEnergySavingMode);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.axosimple.TechnologyCommonData> ShadowToPlainAsync()
        {
            Pocos.axosimple.TechnologyCommonData plain = new Pocos.axosimple.TechnologyCommonData();
            await base.ShadowToPlainAsync(plain);
            plain.IdealCycleTime = IdealCycleTime.Shadow;
            plain.WarningCycleTime = WarningCycleTime.Shadow;
            plain.ErrorCycleTime = ErrorCycleTime.Shadow;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.Shadow;
            return plain;
        }

        protected async Task<Pocos.axosimple.TechnologyCommonData> ShadowToPlainAsync(Pocos.axosimple.TechnologyCommonData plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.IdealCycleTime = IdealCycleTime.Shadow;
            plain.WarningCycleTime = WarningCycleTime.Shadow;
            plain.ErrorCycleTime = ErrorCycleTime.Shadow;
            plain.TimeToEntryEnergySavingMode = TimeToEntryEnergySavingMode.Shadow;
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.axosimple.TechnologyCommonData plain)
        {
            await base.PlainToShadowAsync(plain);
            IdealCycleTime.Shadow = plain.IdealCycleTime;
            WarningCycleTime.Shadow = plain.WarningCycleTime;
            ErrorCycleTime.Shadow = plain.ErrorCycleTime;
            TimeToEntryEnergySavingMode.Shadow = plain.TimeToEntryEnergySavingMode;
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
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.axosimple.TechnologyCommonData plain, Pocos.axosimple.TechnologyCommonData latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (plain.IdealCycleTime != IdealCycleTime.LastValue)
                    somethingChanged = true;
                if (plain.WarningCycleTime != WarningCycleTime.LastValue)
                    somethingChanged = true;
                if (plain.ErrorCycleTime != ErrorCycleTime.LastValue)
                    somethingChanged = true;
                if (plain.TimeToEntryEnergySavingMode != TimeToEntryEnergySavingMode.LastValue)
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.axosimple.TechnologyCommonData CreateEmptyPoco()
        {
            return new Pocos.axosimple.TechnologyCommonData();
        }
    }
}