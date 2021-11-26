namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Survival"/>.
    /// </summary>
    public static partial class SurvivalExt
    {
        /// <summary>
        /// Returns the 
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetUpdateHungerInterval(this Survival survival) => survival.kUpdateHungerInterval;
        public static void AddUpdateHungerInterval(this Survival survival, float amount)
        {
            survival.kUpdateHungerInterval += amount;
            survival.CancelInvoke("UpdateHunger");
            survival.InvokeRepeating("UpdateHunger", 0, survival.kUpdateHungerInterval);
        }
     
        public static void SubtractUpdateHungerInterval(this Survival survival, float amount)
        {
            survival.kUpdateHungerInterval -= amount;
            survival.CancelInvoke("UpdateHunger");
            survival.InvokeRepeating("UpdateHunger", 0, survival.kUpdateHungerInterval);
        }


        /// <summary> How much health to regen when player has eaten enough food. Calculated as (baseRegenRate * UpdateHungerInterval) </summary>
        public static float GetFoodWaterHealThreshold(this Survival survival) => Stats.player.survival.FoodWaterHealThreshold;
        public static void AddFoodWaterHealThreshold(this Survival survival, float amount) => Stats.player.survival.FoodWaterHealThreshold += amount;
        public static void SubtractFoodWaterHealThreshold(this Survival survival, float amount) => Stats.player.survival.FoodWaterHealThreshold -= amount;


        public static float GetBaseRegenRate(this Survival survival) => Stats.player.survival.BaseRegenRate;
        public static void AddBaseRegenRate(this Survival survival, float amount) => Stats.player.survival.BaseRegenRate += amount;
        public static void SubtractBaseRegenRate(this Survival survival, float amount) => Stats.player.survival.BaseRegenRate -= amount;


        public static float GetO2FromBlatterfish(this Survival survival) => Stats.player.survival.O2FromBlatterfish;
        public static void AddO2FromBlatterfish(this Survival survival, float amount) => Stats.player.survival.O2FromBlatterfish += amount;
        public static void SubtractO2FromBlatterfish(this Survival survival, float amount) => Stats.player.survival.O2FromBlatterfish -= amount;


        public static float GetWeakSpeedThreshold(this Survival survival) => Stats.player.survival.WeakSpeedThreshold;
        public static void AddWeakSpeedThreshold(this Survival survival, float amount) => Stats.player.survival.WeakSpeedThreshold += amount;
        public static void SubtractWeakSpeedThreshold(this Survival survival, float amount) => Stats.player.survival.WeakSpeedThreshold -= amount;
    }
}
