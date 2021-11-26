using StatsCore.Stats;
using System.Collections.Generic;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="OxygenManager"/>.
    /// </summary>
    public static partial class OxygenMgrExt
    {
        /// <summary>
        /// (Cross-Game compatible) Returns all of the oxygen sources affecting the player. Player's lungs are the first source.
        /// </summary>
#if Subnautica
        public static List<Oxygen> GetAllSources(this OxygenManager oxygenManager) => oxygenManager.sources;
#elif BelowZero
        public static List<IOxygenSource> GetAllSources(this OxygenManager oxygenManager) => oxygenManager.sources;
#endif

        /// <summary>
        /// (Cross-Game compatible) Returns the amount of O2 thats recovered per second on the surface of the ocean.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetO2UnitsPerSecondSurface(this OxygenManager oxygenManager) => oxygenManager.oxygenUnitsPerSecondSurface;

        /// <summary>
        /// (Cross-Game compatible) Raises the amount of O2 thats recovered per second on the surface of the ocean.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseO2UnitsPerSecondSurface(this OxygenManager oxygenManager, float amount) => oxygenManager.oxygenUnitsPerSecondSurface += amount;

        /// <summary>
        /// (Cross-Game compatible) Reduces the amount of O2 thats recovered per second on the surface of the ocean.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount"></param>
        public static void ReduceO2UnitsPerSecondSurface(this OxygenManager oxygenManager, float amount) => oxygenManager.oxygenUnitsPerSecondSurface -= amount;


        /// <summary>
        /// (Cross-Game compatible) Returns how long it takes for the player to take one breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetBreathPeriod(this OxygenManager oxygenManager) => AirData.BreathPeriod;

        /// <summary>
        /// (Cross-Game compatible) Raises the amount of time it takes for the player to take one breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseBreathPeriod(this OxygenManager oxygenManager, float amount) => AirData.BreathPeriod += amount;

        /// <summary>
        /// (Cross-Game compatible) Reduces the amount of time it takes for the player to take one breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to reduce breath time by.</param>
        public static void ReduceBreathPeriod(this OxygenManager oxygenManager, float amount) => AirData.BreathPeriod -= amount;


        /// <summary>
        /// (Cross-Game compatible) Returns how much Oxygen is consumed per breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetO2PerBreath(this OxygenManager oxygenManager) => AirData.OxygenPerBreath;

        /// <summary>
        /// (Cross-Game compatible) Raises how much Oxygen is consumed per breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseO2PerBreath(this OxygenManager oxygenManager, float amount) => AirData.OxygenPerBreath += amount;

        /// <summary>
        /// (Cross-Game compatible) Reduces how much Oxygen is consumed per breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceO2PerBreath(this OxygenManager oxygenManager, float amount) => AirData.OxygenPerBreath -= amount;


        /// <summary>
        /// (Cross-Game compatible) Returns the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetSuffocationTime(this OxygenManager oxygenManager) => AirData.SuffocationTime;

        /// <summary>
        /// (Cross-Game compatible) Raises the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseSuffocationTime(this OxygenManager oxygenManager, float amount) => AirData.SuffocationTime += amount;

        /// <summary>
        /// (Cross-Game compatible) Reduces the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceSuffocationTime(this OxygenManager oxygenManager, float amount) => AirData.SuffocationTime -= amount;


        /// <summary>
        /// (Cross-Game compatible) Returns the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetSuffocationRecoveryTime(this OxygenManager oxygenManager) => AirData.SuffocationRecoveryTime;

        /// <summary>
        /// (Cross-Game compatible) Raises the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseSuffocationRecoveryTime(this OxygenManager oxygenManager, float amount) => AirData.SuffocationRecoveryTime += amount;

        /// <summary>
        /// (Cross-Game compatible) Reduces the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceSuffocationRecoveryTime(this OxygenManager oxygenManager, float amount) => AirData.SuffocationRecoveryTime -= amount;
    }
}