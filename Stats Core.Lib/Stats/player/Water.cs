namespace Stats_Core.Stats.player
{
    public static class Water
    {
		public static readonly float defaultStartingWater = SurvivalConstants.kStartWaterStat;
        public static readonly float defaultMinWater = 0;
        public static readonly float default_WaterCapacity = SurvivalConstants.kMaxStat;
        public static readonly float default_OverFillWaterSize = default_WaterCapacity;
        public static readonly float defaultWaterTime = SurvivalConstants.kWaterTime;
        public static readonly float defaultDehydrationDamage = SurvivalConstants.kStarveDamage;
        public static readonly float defaultLowWaterThreshold = SurvivalConstants.kLowWaterThreshold;
        public static readonly float defaultCriticalWaterThreshold = SurvivalConstants.kCriticalWaterThreshold;


        public static float StartingWater { get; set; } = defaultStartingWater;
        public static float MinWater { get; set; } = defaultMinWater;
        public static float WaterCapacity { get; set; } = default_WaterCapacity;
        public static float OverfillWaterSize { get; set; } = default_OverFillWaterSize;
        public static float WaterTime { get; set; } = defaultWaterTime;
        public static float DehydrationDamage { get; set; } = defaultDehydrationDamage;
        public static float LowWaterThreshold { get; set; } = defaultLowWaterThreshold;
        public static float CriticalWaterThreshold { get; set; } = defaultCriticalWaterThreshold;
    }
}
