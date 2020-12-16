using Stats_Core.Stats.player;

namespace Stats_Core.Extensions
{
    public static partial class SurvivalExt
    {
        public static float GetStartingWater(this Survival survival) => Water.StartingWater;
        public static void AddStartingWater(this Survival survival, float amount) => Water.StartingWater += amount;
        public static void SubtractStartingWater(this Survival survival, float amount) => Water.StartingWater -= amount;


        public static float GetMinWater(this Survival survival) => Water.MinWater;
        public static void AddMinWater(this Survival survival, float amount) => Water.MinWater += amount;
        public static void SubtractMinWater(this Survival survival, float amount) => Water.MinWater -= amount;


        public static float GetWaterCapacity(this Survival survival) => Water.WaterCapacity;
        public static void AddWaterCapacity(this Survival survival, float amount) => Water.WaterCapacity += amount;
        public static void SubtractWaterCapacity(this Survival survival, float amount) => Water.WaterCapacity -= amount;


        public static float GetWaterOverfillSize(this Survival survival) => Water.OverfillWaterSize;
        public static void AddWaterOverfillSize(this Survival survival, float amount) => Water.OverfillWaterSize += amount;
        public static void SubtractWaterOverfillSize(this Survival survival, float amount) => Water.OverfillWaterSize -= amount;


        public static float GetWaterTime(this Survival survival) => Water.WaterTime;
        public static void AddWaterTime(this Survival survival, float amount) => Water.WaterTime += amount;
        public static void SubtractWaterTime(this Survival survival, float amount) => Water.WaterTime -= amount;


        public static float GetDehydrationDamage(this Survival survival) => Water.DehydrationDamage;
        public static void AddDehydrationDamage(this Survival survival, float amount) => Water.DehydrationDamage += amount;
        public static void SubtractDehydrationDamage(this Survival survival, float amount) => Water.DehydrationDamage -= amount;


        public static float GetLowWaterThreshold(this Survival survival) => Water.LowWaterThreshold;
        public static void AddLowWaterThreshold(this Survival survival, float amount) => Water.LowWaterThreshold += amount;
        public static void SubtractLowWaterThreshold(this Survival survival, float amount) => Water.LowWaterThreshold -= amount;


        public static float GetCriticalWaterThreshold(this Survival survival) => Water.CriticalWaterThreshold;
        public static void AddCriticalWaterThreshold(this Survival survival, float amount) => Water.CriticalWaterThreshold += amount;
        public static void SubtractCriticalWaterThreshold(this Survival survival, float amount) => Water.CriticalWaterThreshold -= amount;
    }
}