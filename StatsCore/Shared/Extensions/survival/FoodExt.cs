using StatsCore.Stats;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Survival"/>.
    /// </summary>
    public static partial class SurvivalExt
    {
        /// <summary>
        /// Returns the food that the stomach starts with when respawning.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetStartingFood(this Survival survival) => FoodData.StartingFood;

        /// <summary>
        /// Raise the food that the stomach starts with when respawning. 
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStartingFood(this Survival survival, float amount) => FoodData.StartingFood += amount;

        /// <summary>
        /// Reduce the food that the stomach starts with when respawning.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStartingFood(this Survival survival, float amount) => FoodData.StartingFood -= amount;


        /// <summary>
        /// Returns the minimum amount of food the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetMinStomachSize(this Survival survival) => FoodData.MinFood;

        /// <summary>
        /// Raise the minimum amount of food the stomach can hold. Useful for making the minimum food above/below zero.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseMinStomachSize(this Survival survival, float amount) => FoodData.MinFood += amount;

        /// <summary>
        /// Reduce the minimum amount of food the stomach can hold. Useful for making the minimum food above/below zero.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceMinStomachSize(this Survival survival, float amount) => FoodData.MinFood -= amount;


        /// <summary>
        /// Returns the amout of food the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetStomachSize(this Survival survival) => FoodData.StomachSize;

        /// <summary>
        /// Raise the amout of food the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStomachSize(this Survival survival, float amount) => FoodData.StomachSize += amount;

        /// <summary>
        /// Reduce the amout of food the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStomachSize(this Survival survival, float amount) => FoodData.StomachSize -= amount;
        

        /// <summary>
        /// Returns the amount the stomach can overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetStomachOverfillSize(this Survival survival) => FoodData.OverfillStomachSize;

        /// <summary>
        /// Raise the amount the stomach can overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStomachOverfillSize(this Survival survival, float amount) => FoodData.OverfillStomachSize += amount;

        /// <summary>
        /// Reduce the amount the stomach can overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStomachOverfillSize(this Survival survival, float amount) => FoodData.OverfillStomachSize -= amount;


        /// <summary>
        /// Returns the FoodPerTempDamage.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetFoodPerTempDamage(this Survival survival) => FoodData.FoodPerTempDamage;

        /// <summary>
        /// Raise the FoodPerTempDamage.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseFoodPerTempDamage(this Survival survival, float amount) => FoodData.FoodPerTempDamage += amount;

        /// <summary>
        /// Reduce the FoodPerTempDamage.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceFoodPerTempDamage(this Survival survival, float amount) => FoodData.FoodPerTempDamage -= amount;


        /// <summary>
        /// Returns the amount of time in between consuming FoodData.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetFoodTime(this Survival survival) => FoodData.FoodTime;

        /// <summary>
        /// Raise the amount of time in between consuming FoodData.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseFoodTime(this Survival survival, float amount) => FoodData.FoodTime += amount;

        /// <summary>
        /// Reduce the amount of time in between consuming FoodData.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceFoodTime(this Survival survival, float amount) => FoodData.FoodTime -= amount;


        /// <summary>
        /// Returns the damage taken when starving.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetStarveDamage(this Survival survival) => FoodData.StarveDamage;

        /// <summary>
        /// Raise the damage taken when starving.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStarveDamage(this Survival survival, float amount) => FoodData.StarveDamage += amount;

        /// <summary>
        /// Reduce the damage taken when starving.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStarveDamage(this Survival survival, float amount) => FoodData.StarveDamage -= amount;


        /// <summary>
        /// Returns the threshold for low food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetLowFoodThreshold(this Survival survival) => FoodData.LowFoodThreshold;

        /// <summary>
        /// Raise the threshold for low food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseLowFoodThreshold(this Survival survival, float amount) => FoodData.LowFoodThreshold += amount;

        /// <summary>
        /// Reduce the threshold for low food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceLowFoodThreshold(this Survival survival, float amount) => FoodData.LowFoodThreshold -= amount;


        /// <summary>
        /// Returns the threshold for critical food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetCriticalFoodThreshold(this Survival survival) => FoodData.CriticalFoodThreshold;

        /// <summary>
        /// Raise the threshold for critical food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseCriticalFoodThreshold(this Survival survival, float amount) => FoodData.CriticalFoodThreshold += amount;

        /// <summary>
        /// Reduce the threshold for critical food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceCriticalFoodThreshold(this Survival survival, float amount) => FoodData.CriticalFoodThreshold -= amount;
    }
}
