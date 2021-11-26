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
        public static float GetStartingFood(this Survival survival) => Food.StartingFood;

        /// <summary>
        /// Raise the food that the stomach starts with when respawning. 
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStartingFood(this Survival survival, float amount) => Food.StartingFood += amount;

        /// <summary>
        /// Reduce the food that the stomach starts with when respawning.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStartingFood(this Survival survival, float amount) => Food.StartingFood -= amount;


        /// <summary>
        /// Returns the minimum amount of food the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetMinStomachSize(this Survival survival) => Food.MinFood;

        /// <summary>
        /// Raise the minimum amount of food the stomach can hold. Useful for making the minimum food above/below zero.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseMinStomachSize(this Survival survival, float amount) => Food.MinFood += amount;

        /// <summary>
        /// Reduce the minimum amount of food the stomach can hold. Useful for making the minimum food above/below zero.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceMinStomachSize(this Survival survival, float amount) => Food.MinFood -= amount;


        /// <summary>
        /// Returns the amout of food the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetStomachSize(this Survival survival) => Food.StomachSize;

        /// <summary>
        /// Raise the amout of food the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStomachSize(this Survival survival, float amount) => Food.StomachSize += amount;

        /// <summary>
        /// Reduce the amout of food the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStomachSize(this Survival survival, float amount) => Food.StomachSize -= amount;
        

        /// <summary>
        /// Returns the amount the stomach can overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetStomachOverfillSize(this Survival survival) => Food.OverfillStomachSize;

        /// <summary>
        /// Raise the amount the stomach can overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStomachOverfillSize(this Survival survival, float amount) => Food.OverfillStomachSize += amount;

        /// <summary>
        /// Reduce the amount the stomach can overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStomachOverfillSize(this Survival survival, float amount) => Food.OverfillStomachSize -= amount;


        /// <summary>
        /// Returns the FoodPerTempDamage.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetFoodPerTempDamage(this Survival survival) => Food.FoodPerTempDamage;

        /// <summary>
        /// Raise the FoodPerTempDamage.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseFoodPerTempDamage(this Survival survival, float amount) => Food.FoodPerTempDamage += amount;

        /// <summary>
        /// Reduce the FoodPerTempDamage.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceFoodPerTempDamage(this Survival survival, float amount) => Food.FoodPerTempDamage -= amount;


        /// <summary>
        /// Returns the amount of time in between consuming food.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetFoodTime(this Survival survival) => Food.FoodTime;

        /// <summary>
        /// Raise the amount of time in between consuming food.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseFoodTime(this Survival survival, float amount) => Food.FoodTime += amount;

        /// <summary>
        /// Reduce the amount of time in between consuming food.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceFoodTime(this Survival survival, float amount) => Food.FoodTime -= amount;


        /// <summary>
        /// Returns the damage taken when starving.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetStarveDamage(this Survival survival) => Food.StarveDamage;

        /// <summary>
        /// Raise the damage taken when starving.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStarveDamage(this Survival survival, float amount) => Food.StarveDamage += amount;

        /// <summary>
        /// Reduce the damage taken when starving.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStarveDamage(this Survival survival, float amount) => Food.StarveDamage -= amount;


        /// <summary>
        /// Returns the threshold for low food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetLowFoodThreshold(this Survival survival) => Food.LowFoodThreshold;

        /// <summary>
        /// Raise the threshold for low food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseLowFoodThreshold(this Survival survival, float amount) => Food.LowFoodThreshold += amount;

        /// <summary>
        /// Reduce the threshold for low food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceLowFoodThreshold(this Survival survival, float amount) => Food.LowFoodThreshold -= amount;


        /// <summary>
        /// Returns the threshold for critical food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetCriticalFoodThreshold(this Survival survival) => Food.CriticalFoodThreshold;

        /// <summary>
        /// Raise the threshold for critical food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseCriticalFoodThreshold(this Survival survival, float amount) => Food.CriticalFoodThreshold += amount;

        /// <summary>
        /// Reduce the threshold for critical food warnings.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceCriticalFoodThreshold(this Survival survival, float amount) => Food.CriticalFoodThreshold -= amount;
    }
}
