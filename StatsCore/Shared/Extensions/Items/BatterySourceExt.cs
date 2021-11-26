namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="BatterySource"/>.
    /// </summary>
    public static class BatterySourceExt
    {
        /// <summary>
        /// returns the power relay that the battery source is connected to.
        /// </summary>
        /// <param name="battery"></param>
        /// <returns></returns>
        public static PowerRelay GetPowerRelay(this BatterySource battery) => battery.connectedRelay;

        /// <summary>
        /// Sets the power relay that the battery source is connected to.
        /// </summary>
        /// <param name="battery"></param>
        /// <param name="newPowerRelay"></param>
        /// <returns></returns>
        public static void SetPowerRelay(this BatterySource battery, PowerRelay newPowerRelay) => battery.connectedRelay = newPowerRelay;
    }
}
