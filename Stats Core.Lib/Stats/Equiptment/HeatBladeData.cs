namespace StatsCore.Stats
{
    /// <summary>
    /// Contains extra methods/variables for manipulating <see cref="HeatBlade"/>. 
    /// Needed because some values are hard coded in Subnautica and therefore new variables/methods are needed.
    /// </summary>
    internal static class HeatBladeData
    {
        /// <summary>
        /// A placeholder variable for manually adjusting the uses per hit of a heat blade.
        /// </summary>
        public static int UsesPerHit { get; set; } = 3;
    }
}
