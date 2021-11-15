
namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="EnergyMixin"/>.
    /// </summary>
    public static class EnergyMixinExt
    {
        /// <summary>
        /// Returns the IBattery interface of this energy mixin.
        /// </summary>
        /// <param name="energyMixin"></param>
        /// <returns></returns>
        public static IBattery GetIBattery(this EnergyMixin energyMixin) => energyMixin.battery;
    }
}
