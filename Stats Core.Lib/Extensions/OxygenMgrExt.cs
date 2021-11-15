using Stats_Core.Stats.player;
using System.Collections.Generic;

namespace Stats_Core.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="OxygenManager"/>.
    /// </summary>
    public static class OxygenMgrExt
    {
        /// <summary>
		/// Returns all of the oxygen sources affecting the player. Player's lungs are the first source.
		/// </summary>
        public static List<Oxygen> GetAllSources(this OxygenManager oxygenManager) => oxygenManager.sources;

        /// <summary>
        /// Returns the amount of O2 thats recovered per second on the surface of the ocean.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetO2UnitsPerSecondSurface(this OxygenManager oxygenManager) => oxygenManager.oxygenUnitsPerSecondSurface;

        /// <summary>
        /// Raises the amount of O2 thats recovered per second on the surface of the ocean.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseO2UnitsPerSecondSurface(this OxygenManager oxygenManager, float amount) => oxygenManager.oxygenUnitsPerSecondSurface += amount;

        /// <summary>
        /// Reduces the amount of O2 thats recovered per second on the surface of the ocean.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount"></param>
        public static void ReduceO2UnitsPerSecondSurface(this OxygenManager oxygenManager, float amount) => oxygenManager.oxygenUnitsPerSecondSurface -= amount;


        /// <summary>
        /// Returns how long it takes for the player to take one breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetBreathPeriod(this OxygenManager oxygenManager) => Air.BreathPeriod;

        /// <summary>
        /// Raises the amount of time it takes for the player to take one breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseBreathPeriod(this OxygenManager oxygenManager, float amount) => Air.BreathPeriod += amount;
        
        /// <summary>
        /// Reduces the amount of time it takes for the player to take one breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to reduce breath time by.</param>
        public static void ReduceBreathPeriod(this OxygenManager oxygenManager, float amount) => Air.BreathPeriod -= amount;


        /// <summary>
        /// Returns how much Oxygen is consumed per breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetO2PerBreath(this OxygenManager oxygenManager) => Air.OxygenPerBreath;

        /// <summary>
        /// Raises how much Oxygen is consumed per breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseO2PerBreath(this OxygenManager oxygenManager, float amount) => Air.OxygenPerBreath += amount;

        /// <summary>
        /// Reduces how much Oxygen is consumed per breath.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceO2PerBreath(this OxygenManager oxygenManager, float amount) => Air.OxygenPerBreath -= amount;


        /// <summary>
        /// Returns the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetSuffocationTime(this OxygenManager oxygenManager) => Air.SuffocationTime;

        /// <summary>
        /// Raises the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseSuffocationTime(this OxygenManager oxygenManager, float amount) => Air.SuffocationTime += amount;

        /// <summary>
        /// Reduces the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceSuffocationTime(this OxygenManager oxygenManager, float amount) => Air.SuffocationTime -= amount;


        /// <summary>
        /// Returns the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <returns></returns>
        public static float GetSuffocationRecoveryTime(this OxygenManager oxygenManager) => Air.SuffocationRecoveryTime;

        /// <summary>
        /// Raises the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseSuffocationRecoveryTime(this OxygenManager oxygenManager, float amount) => Air.SuffocationRecoveryTime += amount;

        /// <summary>
        /// Reduces the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="oxygenManager"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceSuffocationRecoveryTime(this OxygenManager oxygenManager, float amount) => Air.SuffocationRecoveryTime -= amount;
    }
}