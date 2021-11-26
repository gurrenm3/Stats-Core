namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Survival"/>.
    /// </summary>
    public static partial class SurvivalExt
    {
        /// <summary>
        /// Returns how much health to regen when player has eaten enough food. Calculated as (baseRegenRate * UpdateHungerInterval).
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetFoodWaterHealThreshold(this Survival survival) => Stats.SurvivalData.FoodWaterHealThreshold;

        /// <summary>
        /// Raise how much health to regen when player has eaten enough food. Calculated as (baseRegenRate * UpdateHungerInterval).
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseFoodWaterHealThreshold(this Survival survival, float amount) => Stats.SurvivalData.FoodWaterHealThreshold += amount;

        /// <summary>
        /// Reduce how much health to regen when player has eaten enough food. Calculated as (baseRegenRate * UpdateHungerInterval).
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceFoodWaterHealThreshold(this Survival survival, float amount) => Stats.SurvivalData.FoodWaterHealThreshold -= amount;


        public static float GetBaseRegenRate(this Survival survival) => Stats.SurvivalData.BaseRegenRate;
        public static void RaiseBaseRegenRate(this Survival survival, float amount) => Stats.SurvivalData.BaseRegenRate += amount;
        public static void ReduceBaseRegenRate(this Survival survival, float amount) => Stats.SurvivalData.BaseRegenRate -= amount;


        /// <summary>
        /// Returns the amount of O2 gained from Blatter Fish.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetO2FromBlatterfish(this Survival survival) => Stats.SurvivalData.O2FromBlatterfish;

        /// <summary>
        /// Raises the amount of O2 gained from Blatterfish.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to Raise by.</param>
        public static void RaiseO2FromBlatterfish(this Survival survival, float amount) => Stats.SurvivalData.O2FromBlatterfish += amount;

        /// <summary>
        /// Reduces the amount of O2 gained from Blatterfish.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceO2FromBlatterfish(this Survival survival, float amount) => Stats.SurvivalData.O2FromBlatterfish -= amount;


        public static float GetWeakSpeedThreshold(this Survival survival) => Stats.SurvivalData.WeakSpeedThreshold;
        public static void RaiseWeakSpeedThreshold(this Survival survival, float amount) => Stats.SurvivalData.WeakSpeedThreshold += amount;
        public static void ReduceWeakSpeedThreshold(this Survival survival, float amount) => Stats.SurvivalData.WeakSpeedThreshold -= amount;


        public static float GetUpdateHungerInterval(this Survival survival) => survival.kUpdateHungerInterval;
        public static void RaiseUpdateHungerInterval(this Survival survival, float amount)
        {
            survival.kUpdateHungerInterval += amount;
            survival.CancelInvoke("UpdateHunger");
            survival.InvokeRepeating("UpdateHunger", 0, survival.kUpdateHungerInterval);
        }

        public static void ReduceUpdateHungerInterval(this Survival survival, float amount)
        {
            survival.kUpdateHungerInterval -= amount;
            survival.CancelInvoke("UpdateHunger");
            survival.InvokeRepeating("UpdateHunger", 0, survival.kUpdateHungerInterval);
        }
    }
}
