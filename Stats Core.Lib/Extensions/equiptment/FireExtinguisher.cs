namespace Stats_Core.Extensions
{
    public static class FireExtinguisherExt
    {
        public static float GetExpendFuelPerSecond(this FireExtinguisher fireExtinguisher) => fireExtinguisher.expendFuelPerSecond;
        public static void AddExpendFuelPerSecond(this FireExtinguisher fireExtinguisher, float amount) => 
            fireExtinguisher.expendFuelPerSecond += amount;
        public static void SubtractExpendFuelPerSecond(this FireExtinguisher fireExtinguisher, float amount) =>
            fireExtinguisher.expendFuelPerSecond -= amount;


        public static float GetFireDousePerSecond(this FireExtinguisher fireExtinguisher) => fireExtinguisher.fireDousePerSecond;
        public static void AddFireDousePerSecond(this FireExtinguisher fireExtinguisher, float amount) =>
            fireExtinguisher.fireDousePerSecond += amount;
        public static void SubtractFireDousePerSecond(this FireExtinguisher fireExtinguisher, float amount) =>
            fireExtinguisher.fireDousePerSecond -= amount;


        public static Fire GetFireTarget(this FireExtinguisher fireExtinguisher) => fireExtinguisher.fireTarget;
        public static void SetFireTarget(this FireExtinguisher fireExtinguisher, Fire newTarget) => fireExtinguisher.fireTarget = newTarget;
    }
}