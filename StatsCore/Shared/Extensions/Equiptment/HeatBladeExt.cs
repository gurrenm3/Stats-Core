namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="HeatBlade"/>.
    /// </summary>
    public static class HeatBladeExt
    {
        /// <summary>
        /// Raises the number of uses per hit.
        /// </summary>
        /// <param name="heatBlade"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseUsesPerHit(this HeatBlade heatBlade, int amount) => Stats.HeatBladeData.UsesPerHit += amount;

        /// <summary>
        /// Reduces the number of uses per het.
        /// </summary>
        /// <param name="heatBlade"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceUsesPerHit(this HeatBlade heatBlade, int amount) => Stats.HeatBladeData.UsesPerHit -= amount;
    }
}
