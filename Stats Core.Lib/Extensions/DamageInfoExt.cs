using StatsCore.Stats.player;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="DamageInfo"/>.
    /// </summary>
    public static class DamageInfoExt
    {
        /// <summary>
        /// Returns the damage resistance for this DamageType.
        /// </summary>
        /// <param name="damageInfo"></param>
        /// <returns></returns>
        public static float GetResistance(this DamageInfo damageInfo) => DamageTypeResistance.allResistances[damageInfo.type];

        /// <summary>
        /// Raises the total resistance to this type of damage.
        /// </summary>
        /// <param name="damageInfo"></param>
        /// <param name="amount">Amount to raise resistance by.</param>
        public static void RaiseResistance(this DamageInfo damageInfo, float amount) => DamageTypeResistance.allResistances[damageInfo.type] += amount;

        /// <summary>
        /// Reduces the total resistance to this type of damage.
        /// </summary>
        /// <param name="damageInfo"></param>
        /// <param name="amount">Amount to reduce resistance by.</param>
        public static void ReduceResistance(this DamageInfo damageInfo, float amount) => DamageTypeResistance.allResistances[damageInfo.type] -= amount;
    }
}
