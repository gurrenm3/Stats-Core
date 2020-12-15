namespace Stats_Core.Extensions
{
    public static class FireExtinguisherExt
    {
        public static float GetExpendFuelPerSecond(this FireExtinguisher fireExtinguisher) => fireExtinguisher.expendFuelPerSecond;
        public static void SetExpendFuelPerSecond(this FireExtinguisher fireExtinguisher, float newAmount) => 
            fireExtinguisher.expendFuelPerSecond = newAmount;


        public static float GetFireDousePerSecond(this FireExtinguisher fireExtinguisher) => fireExtinguisher.fireDousePerSecond;
        public static void SetFireDousePerSecond(this FireExtinguisher fireExtinguisher, float newAmount) => fireExtinguisher.fireDousePerSecond = newAmount;


        public static Fire GetFireTarget(this FireExtinguisher fireExtinguisher) => fireExtinguisher.fireTarget;
        public static void SetFireTarget(this FireExtinguisher fireExtinguisher, Fire newTarget) => fireExtinguisher.fireTarget = newTarget;
    }
}