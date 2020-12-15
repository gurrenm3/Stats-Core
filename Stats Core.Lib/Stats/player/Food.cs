namespace Stats_Core.Stats.player
{
	public static class Food
    {
		public static readonly float defaultStartingFood = SurvivalConstants.kStartFoodStat;
		public static readonly float defaultMinFood = 0;
		public static readonly float default_StomachSize = SurvivalConstants.kMaxStat;
		public static readonly float default_OverFillStomachSize = SurvivalConstants.kMaxOverfillStat;
		public static readonly float defaultFoodPerTempDamage = SurvivalConstants.kFoodPerTempDamage;
		public static readonly float defaultFoodTime = SurvivalConstants.kFoodTime;
		public static readonly float defaultStarveDamage = SurvivalConstants.kStarveDamage;
		public static readonly float defaultLowFoodThreshold = SurvivalConstants.kLowFoodThreshold;
		public static readonly float defaultCriticalFoodThreshold = SurvivalConstants.kCriticalFoodThreshold;


		public static float StartingFood { get; set; } = defaultStartingFood;
		public static float MinFood { get; set; } = defaultMinFood;
		public static float StomachSize { get; set; } = default_StomachSize;
		public static float OverfillStomachSize { get; set; } = default_OverFillStomachSize;
		public static float FoodPerTempDamage { get; set; } = defaultFoodPerTempDamage;
		public static float FoodTime { get; set; } = defaultFoodTime;
		public static float StarveDamage { get; set; } = defaultStarveDamage;
		public static float LowFoodThreshold { get; set; } = defaultLowFoodThreshold;
		public static float CriticalFoodThreshold { get; set; } = defaultCriticalFoodThreshold;
	}
}