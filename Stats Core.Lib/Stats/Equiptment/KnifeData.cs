namespace StatsCore.Stats
{
    /// <summary>
    /// Contains extra methods/variables for manipulating <see cref="Knife"/>. 
    /// Needed because some values are hard coded in Subnautica and therefore new variables/methods are needed.
    /// </summary>
    internal static class KnifeData
    {
        /// <summary>
        /// A placeholder variable for manually adjusting the uses per hit of a knife.
        /// </summary>
        public static int UsesPerHit { get; set; } = 1;

        /// <summary>
        /// A placeholder variable for manually adjusting the base number of resources dropped when 
        /// damaging something that drops resources.
        /// </summary>
        public static int BaseResourceOnDamage { get; set; } = 1;

        /// <summary>
        /// A placeholder variable for manually adjusting whether or not resources should be
        /// spawned on the ground if inventory is full.
        /// </summary>
        public static bool SpawnResourceIfCantAdd { get; set; } = false;
    }
}