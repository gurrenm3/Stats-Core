namespace StatsCore.Stats
{
    /// <summary>
    /// Contains extra methods/variables for manipulating <see cref="LaserCutter"/>. 
    /// Needed because some values are hard coded in Subnautica and therefore new variables/methods are needed.
    /// </summary>
    internal static class LaserCutterData
    {
        /// <summary>
        /// A placeholder variable for manually adjusting the minimum random intensity.
        /// </summary>
        public static float MinRandomIntensity { get; set; } = 0f;

        /// <summary>
        /// A placeholder variable for manually adjusting the maximum random intensity.
        /// </summary>
        public static float MaxRandomIntensity { get; set; } = 4f;

        /// <summary>
        /// A placeholder variable for manually adjusting the random intensity repeat rate.
        /// </summary>
        public static float RandomizeIntensityRepeatRate { get; set; } = 0.05f;
    }
}