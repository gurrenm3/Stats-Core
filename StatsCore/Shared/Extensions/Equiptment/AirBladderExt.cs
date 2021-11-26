using static StatsCore.Stats.AirBladderData;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="AirBladder"/>.
    /// </summary>
    public static partial class AirBladderExt
    {
        /// <summary>
        /// Returns whether or not the air bladder is inflating.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <returns></returns>
#if Subnautica
        public static bool IsInflating(this AirBladder airBladder) => airBladder.inflating;
#elif BelowZero
        public static bool IsInflating(this AirBladder airBladder) => airBladder.applyBuoyancy;
#endif

        /// <summary>
        /// Returns whether or not the air bladder is deflating.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <returns></returns>
        public static bool IsDeflating(this AirBladder airBladder) => airBladder.deflating;

        /// <summary>
        /// Returns whether or not this is the first time an air bladder has been used.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <returns></returns>
        public static bool IsFirstUse(this AirBladder airBladder) => airBladder.firstUse;
        
        
        /// <summary>
        /// Returns the amount of Oxygen currently in the air bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <returns></returns>
        public static float GetOxygen(this AirBladder airBladder) => airBladder.oxygen;

        /// <summary>
        /// Raise the amount of Oxygen currently in the air bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <param name="amount">Amount to raise Oxygen by.</param>
        /// <returns></returns>
        public static void RaiseOxygen(this AirBladder airBladder, float amount) => airBladder.oxygen += amount;

        /// <summary>
        /// Reduce the amount of Oxygen currently in the air bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <param name="amount">Amount to raise Oxygen by.</param>
        /// <returns></returns>
        public static void ReduceOxygen(this AirBladder airBladder, float amount) => airBladder.oxygen -= amount;


        /// <summary>
        /// Returns the maximum amount of Oxygen the Air Bladder can hold.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <returns></returns>
        public static float GetMaxOxygen(this AirBladder airBladder) => MaxOxygen;

        /// <summary>
        /// Raises the maximum amount of Oxygen the Air Bladder can hold.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <param name="amount">Amount to raise Max O2 by.</param>
        public static void RaiseMaxOxygen(this AirBladder airBladder, float amount) => MaxOxygen += amount;

        /// <summary>
        /// Reduces the maximum amount of Oxygen the Air Bladder can hold.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <param name="amount">Amount to reduce Max O2 by.</param>
        public static void ReduceMaxOxygen(this AirBladder airBladder, float amount) => MaxOxygen -= amount;


        /// <summary>
        /// Returns the amount of O2 consumed per second when using the Air Bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <returns></returns>
        public static float GetO2PerSecond(this AirBladder airBladder) => O2PerSecond;

        /// <summary>
        /// Raises the amount of O2 consumed per second when using the Air Bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <param name="amount">Amount to raise O2 consumption by.</param>
        public static void RaiseO2PerSecond(this AirBladder airBladder, float amount) => O2PerSecond += amount;

        /// <summary>
        /// Reduces the amount of O2 consumed per second when using the Air Bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <param name="amount">Amount to reduce O2 comsumption by.</param>
        public static void ReduceO2PerSecond(this AirBladder airBladder, float amount) => O2PerSecond -= amount;


        /// <summary>
        /// Returns the amount of upward "floating" force caused by using air bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <returns></returns>
#if Subnautica
        public static float GetBuoyancyForce(this AirBladder airBladder) => airBladder.forceConstant;
#elif BelowZero
        public static float GetBuoyancyForce(this AirBladder airBladder) => airBladder.buoyancyForce;
#endif

        /// <summary>
        /// Raises the amount of upward "floating" force caused by using air bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <param name="amount">Amount to raise upward "floating" force by.</param>
#if Subnautica
        public static void RaiseBuoyancyForce(this AirBladder airBladder, float amount) => airBladder.forceConstant += amount;
#elif BelowZero
        public static void RaiseBuoyancyForce(this AirBladder airBladder, float amount) => airBladder.buoyancyForce += amount;
#endif

        /// <summary>
        /// Reduces the amount of upward "floating" force caused by using air bladder.
        /// </summary>
        /// <param name="airBladder"></param>
        /// <param name="amount">Amount to reduce upward "floating" force by.</param>
#if Subnautica
        public static void ReduceBuoyancyForce(this AirBladder airBladder, float amount) => airBladder.forceConstant -= amount;
#elif BelowZero
        public static void ReduceBuoyancyForce(this AirBladder airBladder, float amount) => airBladder.buoyancyForce -= amount;
#endif
    }
}
