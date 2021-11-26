using StatsCore.Stats;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Survival"/>.
    /// </summary>
    public static partial class SurvivalExt
    {
        /// <summary>
        /// Returns the water that the stomach starts with when respawning.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetStartingWater(this Survival survival) => WaterData.StartingWater;

        /// <summary>
        /// Raises the water that the stomach starts with when respawning.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseStartingWater(this Survival survival, float amount) => WaterData.StartingWater += amount;

        /// <summary>
        /// Reduces the water that the stomach starts with when respawning.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceStartingWater(this Survival survival, float amount) => WaterData.StartingWater -= amount;

        
        /// <summary>
        /// Returns the minimum amount of water the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetMinWater(this Survival survival) => WaterData.MinWater;

        /// <summary>
        /// Raises the minimum amount of water the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseMinWater(this Survival survival, float amount) => WaterData.MinWater += amount;

        /// <summary>
        /// Reduces the minimum amount of water the stomach can hold.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceMinWater(this Survival survival, float amount) => WaterData.MinWater -= amount;


        /// <summary>
        /// Returns the amount of water the stomach can hold before overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetWaterCapacity(this Survival survival) => WaterData.WaterCapacity;

        /// <summary>
        /// Rasies the amount of water the stomach can hold before overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseWaterCapacity(this Survival survival, float amount) => WaterData.WaterCapacity += amount;

        /// <summary>
        /// Reduces the amount of water the stomach can hold before overfill.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceWaterCapacity(this Survival survival, float amount) => WaterData.WaterCapacity -= amount;


        /// <summary>
        /// Returns the max amount of water the stomach can hold when overfilled.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetWaterOverfillSize(this Survival survival) => WaterData.OverfillWaterSize;

        /// <summary>
        /// Raises the max amount of water the stomach can hold when overfilled.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseWaterOverfillSize(this Survival survival, float amount) => WaterData.OverfillWaterSize += amount;

        /// <summary>
        /// Reduces the max amount of water the stomach can hold when overfilled.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceWaterOverfillSize(this Survival survival, float amount) => WaterData.OverfillWaterSize -= amount;


        /// <summary>
        /// Returns the total time, in seconds, it takes for the stomach to completely deplete all of it's water from being full.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetWaterTime(this Survival survival) => WaterData.WaterTime;

        /// <summary>
        /// Raises the total time, in seconds, it takes for the stomach to completely deplete all of it's water from being full.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseWaterTime(this Survival survival, float amount) => WaterData.WaterTime += amount;

        /// <summary>
        /// Reduces the total time, in seconds, it takes for the stomach to completely deplete all of it's water from being full.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceWaterTime(this Survival survival, float amount) => WaterData.WaterTime -= amount;


        /// <summary>
        /// Returns the amount of damage taken when player is completely out of water.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetDehydrationDamage(this Survival survival) => WaterData.DehydrationDamage;

        /// <summary>
        /// Raises the amount of damage taken when player is completely out of water.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseDehydrationDamage(this Survival survival, float amount) => WaterData.DehydrationDamage += amount;

        /// <summary>
        /// Reduces the amount of damage taken when player is completely out of water.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceDehydrationDamage(this Survival survival, float amount) => WaterData.DehydrationDamage -= amount;


        /// <summary>
        /// Returns how low the water needs to be for a "Low Water" warning.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetLowWaterThreshold(this Survival survival) => WaterData.LowWaterThreshold;

        /// <summary>
        /// Raises how low the water needs to be for a "Low Water" warning.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseLowWaterThreshold(this Survival survival, float amount) => WaterData.LowWaterThreshold += amount;

        /// <summary>
        /// Reduces how low the water needs to be for a "Low Water" warning.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceLowWaterThreshold(this Survival survival, float amount) => WaterData.LowWaterThreshold -= amount;


        /// <summary>
        /// Returns how low the water needs to be for a "Critically Low Water" warning.
        /// </summary>
        /// <param name="survival"></param>
        /// <returns></returns>
        public static float GetCriticalWaterThreshold(this Survival survival) => WaterData.CriticalWaterThreshold;

        /// <summary>
        /// Raises how low the water needs to be for a "Critically Low Water" warning.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseCriticalWaterThreshold(this Survival survival, float amount) => WaterData.CriticalWaterThreshold += amount;

        /// <summary>
        /// Reduces how low the water needs to be for a "Critically Low Water" warning.
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceCriticalWaterThreshold(this Survival survival, float amount) => WaterData.CriticalWaterThreshold -= amount;
    }
}