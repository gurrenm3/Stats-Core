using Stats_Core.Stats.player;

namespace Stats_Core.Extensions
{
    public static partial class SurvivalExt
    {
        public static float GetUpdateHungerInterval(this Survival survival) => survival.kUpdateHungerInterval;
        public static void AddUpdateHungerInterval(this Survival survival, float amount) => survival.kUpdateHungerInterval += amount;
        public static void SubtractUpdateHungerInterval(this Survival survival, float amount) => survival.kUpdateHungerInterval -= amount;
        public static void SetUpdateHungerInterval(this Survival survival, float amount) => survival.kUpdateHungerInterval = amount;


        /// <summary> How much health to regen when player has eaten enough food. Calculated as (baseRegenRate * UpdateHungerInterval) </summary>
        public static float GetFoodWaterHealThreshold(this Survival survival) => Stats.player.survival.FoodWaterHealThreshold;
        public static void AddFoodWaterHealThreshold(this Survival survival, float amount) => Stats.player.survival.FoodWaterHealThreshold += amount;
        public static void SubtractFoodWaterHealThreshold(this Survival survival, float amount) => Stats.player.survival.FoodWaterHealThreshold -= amount;
        public static void SetFoodWaterHealThreshold(this Survival survival, float amount) => Stats.player.survival.FoodWaterHealThreshold = amount;


        public static float GetBaseRegenRate(this Survival survival) => Stats.player.survival.BaseRegenRate;
        public static void AddBaseRegenRate(this Survival survival, float amount) => Stats.player.survival.BaseRegenRate += amount;
        public static void SubtractBaseRegenRate(this Survival survival, float amount) => Stats.player.survival.BaseRegenRate -= amount;
        public static void SetBaseRegenRate(this Survival survival, float amount) => Stats.player.survival.BaseRegenRate = amount;


        public static float GetO2FromBlatterfish(this Survival survival) => Stats.player.survival.O2FromBlatterfish;
        public static void AddO2FromBlatterfish(this Survival survival, float amount) => Stats.player.survival.O2FromBlatterfish += amount;
        public static void SubtractO2FromBlatterfish(this Survival survival, float amount) => Stats.player.survival.O2FromBlatterfish -= amount;
        public static void SetO2FromBlatterfish(this Survival survival, float amount) => Stats.player.survival.O2FromBlatterfish = amount;


        public static float GetWeakSpeedThreshold(this Survival survival) => Stats.player.survival.WeakSpeedThreshold;
        public static void AddWeakSpeedThreshold(this Survival survival, float amount) => Stats.player.survival.WeakSpeedThreshold += amount;
        public static void SubtractWeakSpeedThreshold(this Survival survival, float amount) => Stats.player.survival.WeakSpeedThreshold -= amount;
        public static void SetWeakSpeedThreshold(this Survival survival, float amount) => Stats.player.survival.WeakSpeedThreshold = amount;
    }
}
