using StatsCore.Stats;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Flare"/>.
    /// </summary>
    public static class FlareExt
    {
        /// <summary>
        /// Returns whether or not this flare is being thrown.
        /// </summary>
        /// <param name="flare"></param>
        /// <returns></returns>
        public static bool IsThrowing(this Flare flare) => flare.isThrowing;

        /// <summary>
        /// Returns the flicker intensity of the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <returns></returns>
#if Subnautica
        public static float GetFlickerInterval(this Flare flare) => flare.flickerInterval;
#elif BelowZero
        public static float GetFlickerInterval(this Flare flare) => FlareData.FlickerInterval;
#endif

        /// <summary>
        /// Raises the flicker intensity of the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <param name="amount">Amount to raise by.</param>
#if Subnautica
        public static void RaiseFlickerInterval(this Flare flare, float amount) => flare.flickerInterval += amount;
#elif BelowZero
        public static void RaiseFlickerInterval(this Flare flare, float amount) => FlareData.FlickerInterval += amount;
#endif

        /// <summary>
        /// Reduces the flicker intensity of the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <param name="amount">Amount to reduce by.</param>
#if Subnautica
        public static void ReduceFlickerInterval(this Flare flare, float amount) => flare.flickerInterval -= amount;
#elif BelowZero
        public static void ReduceFlickerInterval(this Flare flare, float amount) => FlareData.FlickerInterval -= amount;
#endif


        /// <summary>
        /// Returns how long it takes to throw the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <returns></returns>
        public static float GetThrowDuration(this Flare flare) => flare.throwDuration;

        /// <summary>
        /// Raise the time it takes to throw the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseThrowDuration(this Flare flare, float amount) => flare.throwDuration += amount;

        /// <summary>
        /// Reduce the time it takes to throw the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceThrowDuration(this Flare flare, float amount) => flare.throwDuration -= amount;


        /// <summary>
        /// Returns the original light intensity for the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <returns></returns>
        public static float GetOriginalLightIntensity(this Flare flare) => flare.originalIntensity;

        /// <summary>
        /// Raise the original light intensity for the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseOriginalLightIntensity(this Flare flare, float amount) => flare.originalIntensity += amount;

        /// <summary>
        /// Reduce the original light intensity for the flare.
        /// </summary>
        /// <param name="flare"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceOriginalLightIntensity(this Flare flare, float amount) => flare.originalIntensity -= amount;


        /// <summary>
        /// Returns the original light range.
        /// </summary>
        /// <param name="flare"></param>
        /// <returns></returns>
        public static float GetOriginalLightRange(this Flare flare) => flare.originalrange;

        /// <summary>
        /// Raises the original light range.
        /// </summary>
        /// <param name="flare"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseOriginalLightRange(this Flare flare, float amount) => flare.originalrange += amount;
        
        /// <summary>
        /// Reduces the original light range.
        /// </summary>
        /// <param name="flare"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceOriginalLightRange(this Flare flare, float amount) => flare.originalrange -= amount;
    }
}
