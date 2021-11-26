
namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="EnergyMixin"/>.
    /// </summary>
    public static class EnergyMixinExt
    {
        /// <summary>
        /// (Cross-Game compatible) Returns the IBattery interface of this energy mixin.
        /// </summary>
        /// <param name="energyMixin"></param>
        /// <returns></returns>
        public static IBattery GetIBattery(this EnergyMixin energyMixin) => energyMixin.battery;

        /// <summary>
        /// Returns the Storage Slot for this energy mixin.
        /// </summary>
        /// <param name="energyMixin"></param>
        /// <returns></returns>
        public static StorageSlot GetStorageSlot(this EnergyMixin energyMixin) => energyMixin.batterySlot;
    }
}
