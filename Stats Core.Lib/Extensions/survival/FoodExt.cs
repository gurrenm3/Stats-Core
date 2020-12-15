using Stats_Core.Stats.player;

namespace Stats_Core.Extensions
{
    public static partial class SurvivalExt
    {
        public static float GetStartingFood(this Survival survival) => Food.StartingFood;
        public static void AddStartingFood(this Survival survival, float amount) => Food.StartingFood += amount;
        public static void SubtractStartingFood(this Survival survival, float amount) => Food.StartingFood -= amount;
        public static void SetStartingFood(this Survival survival, float amount) => Food.StartingFood = amount;


        public static float GetMinStomachSize(this Survival survival) => Food.MinFood;
        public static void AddMinStomachSize(this Survival survival, float amount) => Food.MinFood += amount;
        public static void SubtractMinStomachSize(this Survival survival, float amount) => Food.MinFood -= amount;
        public static void SetMinStomachSize(this Survival survival, float amount) => Food.MinFood = amount;


        public static float GetStomachSize(this Survival survival) => Food.StomachSize;
        public static void AddStomachSize(this Survival survival, float amount) => Food.StomachSize += amount;
        public static void SubtractStomachSize(this Survival survival, float amount) => Food.StomachSize -= amount;
        public static void SetStomachSize(this Survival survival, float amount) => Food.StomachSize = amount;


        public static float GetStomachOverfillSize(this Survival survival) => Food.OverfillStomachSize;
        public static void AddStomachOverfillSize(this Survival survival, float amount) => Food.OverfillStomachSize += amount;
        public static void SubtractStomachOverfillSize(this Survival survival, float amount) => Food.OverfillStomachSize -= amount;
        public static void SetStomachOverfillSize(this Survival survival, float amount) => Food.OverfillStomachSize = amount;


        public static float GetFoodPerTempDamage(this Survival survival) => Food.FoodPerTempDamage;
        public static void AddFoodPerTempDamage(this Survival survival, float amount) => Food.FoodPerTempDamage += amount;
        public static void SubtractFoodPerTempDamage(this Survival survival, float amount) => Food.FoodPerTempDamage -= amount;
        public static void SetFoodPerTempDamage(this Survival survival, float amount) => Food.FoodPerTempDamage = amount;


        public static float GetFoodTime(this Survival survival) => Food.FoodTime;
        public static void AddFoodTime(this Survival survival, float amount) => Food.FoodTime += amount;
        public static void SubtractFoodTime(this Survival survival, float amount) => Food.FoodTime -= amount;
        public static void SetFoodTime(this Survival survival, float amount) => Food.FoodTime = amount;


        public static float GetStarveDamage(this Survival survival) => Food.StarveDamage;
        public static void AddStarveDamage(this Survival survival, float amount) => Food.StarveDamage += amount;
        public static void SubtractStarveDamage(this Survival survival, float amount) => Food.StarveDamage -= amount;
        public static void SetStarveDamage(this Survival survival, float amount) => Food.StarveDamage = amount;


        public static float GetLowFoodThreshold(this Survival survival) => Food.LowFoodThreshold;
        public static void AddLowFoodThreshold(this Survival survival, float amount) => Food.LowFoodThreshold += amount;
        public static void SubtractLowFoodThreshold(this Survival survival, float amount) => Food.LowFoodThreshold -= amount;
        public static void SetLowFoodThreshold(this Survival survival, float amount) => Food.LowFoodThreshold = amount;


        public static float GetCriticalFoodThreshold(this Survival survival) => Food.CriticalFoodThreshold;
        public static void AddCriticalFoodThreshold(this Survival survival, float amount) => Food.CriticalFoodThreshold += amount;
        public static void SubtractCriticalFoodThreshold(this Survival survival, float amount) => Food.CriticalFoodThreshold -= amount;
        public static void SetCriticalFoodThreshold(this Survival survival, float amount) => Food.CriticalFoodThreshold = amount;
    }
}
