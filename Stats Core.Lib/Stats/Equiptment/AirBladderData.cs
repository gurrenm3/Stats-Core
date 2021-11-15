namespace StatsCore.Stats
{
    /// <summary>
    /// Contains extra methods/variables for manipulating <see cref="AirBladder"/>. 
    /// Needed because some values are hard coded in Subnautica and therefore new variables/methods are needed.
    /// </summary>
    internal static class AirBladderData
    {
        /// <summary>
        /// A placeholder variable for manually adjusting the max oxygen in an AirBladder. 
        /// <br/>This is needed because the original <see cref="AirBladder.maxOxygen"/> is a constant and therefore unchangable.
        /// </summary>
        public static float MaxOxygen { get; set; } = 5f;

        /// <summary>
        /// A placeholder variable for manually adjusting the amount of Oxygen consumed per second in an AirBladder. 
        /// <br/>This is needed because the original <see cref="AirBladder.kTransferPerSecond"/> is a constant and therefore unchangable.
        /// </summary>
        public static float O2PerSecond { get; set; } = 2f;
    }
}
