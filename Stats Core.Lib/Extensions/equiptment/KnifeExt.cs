using static StatsCore.Stats.KnifeData;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Knife"/>.
    /// </summary>
    public static class KnifeExt
    {
        /// <summary>
        /// Raises the number of uses per hit.
        /// </summary>
        /// <param name="knife"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseUsesPerHit(this Knife knife, int amount) => UsesPerHit += amount;

        /// <summary>
        /// Reduces the number of uses per hit.
        /// </summary>
        /// <param name="knife"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void ReduceUsesPerHit(this Knife knife, int amount) => UsesPerHit -= amount;

        /// <summary>
        /// Returns the base number of resources gained when damaging a resource that drops items.
        /// </summary>
        /// <param name="knife"></param>
        /// <returns></returns>
        public static int GetBaseResourceOnDamage(this Knife knife) => BaseResourceOnDamage;

        /// <summary>
        /// Raises the base number of resources gained when damaging a resource that drops items.
        /// </summary>
        /// <param name="knife"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseBaseResourceOnDamage(this Knife knife, int amount) => BaseResourceOnDamage += amount;

        /// <summary>
        /// Reduces the base number of resources gained when damaging a resource that drops items.
        /// </summary>
        /// <param name="knife"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceBaseResourceOnDamage(this Knife knife, int amount) => BaseResourceOnDamage -= amount;


        /// <summary>
        /// Returns whether or not resources should by spawned on the ground if the inventory is full.
        /// </summary>
        /// <param name="knife"></param>
        /// <returns></returns>
        public static bool GetSpawnResourceIfCantAdd(this Knife knife) => SpawnResourceIfCantAdd;

        /// <summary>
        /// Sets whether or not resources should by spawned on the ground if the inventory is full.
        /// </summary>
        /// <param name="knife"></param>
        /// <param name="spawnIfCantAdd">Should resources be spawned on ground?</param>
        public static void SetSpawnResourceIfCantAdd(this Knife knife, bool spawnIfCantAdd) => SpawnResourceIfCantAdd = spawnIfCantAdd;
    }
}