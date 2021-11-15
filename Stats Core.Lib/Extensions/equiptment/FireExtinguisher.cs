namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="FireExtinguisher"/>.
    /// </summary>
    public static class FireExtinguisherExt
    {
        /// <summary>
        /// Returns the amount of fuel consumed per second using the fire extinguisher.
        /// </summary>
        /// <param name="fireExtinguisher"></param>
        /// <returns></returns>
        public static float GetExpendFuelPerSecond(this FireExtinguisher fireExtinguisher) => fireExtinguisher.expendFuelPerSecond;

        /// <summary>
        /// Raises the amount of fuel consumed per second using the fire extinguisher.
        /// </summary>
        /// <param name="fireExtinguisher"></param>
        /// <param name="amount">Amount to raise fuel consumed per second by.</param>
        public static void RaiseExpendFuelPerSecond(this FireExtinguisher fireExtinguisher, float amount) => 
            fireExtinguisher.expendFuelPerSecond += amount;

        /// <summary>
        /// Reduces the amount of fuel consumed per second using the fire extinguisher.
        /// </summary>
        /// <param name="fireExtinguisher"></param>
        /// <param name="amount">Amount to reduce fuel consumed per second by.</param>
        public static void ReduceExpendFuelPerSecond(this FireExtinguisher fireExtinguisher, float amount) =>
            fireExtinguisher.expendFuelPerSecond -= amount;


        /// <summary>
        /// Returns the amount of fire that is extinguished per second when using the fire extinguisher.
        /// </summary>
        /// <param name="fireExtinguisher"></param>
        /// <returns></returns>
        public static float GetFireDousePerSecond(this FireExtinguisher fireExtinguisher) => fireExtinguisher.fireDousePerSecond;

        /// <summary>
        /// Raises the amount of fire that is extinguished per second when using the fire extinguisher.
        /// </summary>
        /// <param name="fireExtinguisher"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseFireDousePerSecond(this FireExtinguisher fireExtinguisher, float amount) =>
            fireExtinguisher.fireDousePerSecond += amount;

        /// <summary>
        /// Reduces the amount of fire that is extinguished per second when using the fire extinguisher.
        /// </summary>
        /// <param name="fireExtinguisher"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceFireDousePerSecond(this FireExtinguisher fireExtinguisher, float amount) =>
            fireExtinguisher.fireDousePerSecond -= amount;


        /// <summary>
        /// Returns the current fire target.
        /// </summary>
        /// <param name="fireExtinguisher"></param>
        /// <returns></returns>
        public static Fire GetFireTarget(this FireExtinguisher fireExtinguisher) => fireExtinguisher.fireTarget;

        /// <summary>
        /// Sets the current fire target.
        /// </summary>
        /// <param name="fireExtinguisher"></param>
        /// <param name="newTarget"></param>
        public static void SetFireTarget(this FireExtinguisher fireExtinguisher, Fire newTarget) => fireExtinguisher.fireTarget = newTarget;
    }
}