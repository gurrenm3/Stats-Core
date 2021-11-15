namespace StatsCore.Stats.player
{
	public static class survival
    {
		public static readonly float default_UpdateHungerInterval = 10f;
		public static readonly float defaultFoodWaterHealThreshold = SurvivalConstants.kFoodWaterHealThreshold;
		public static readonly float defaultBaseRegenRate = SurvivalConstants.kBaseRegenRate;
		public static readonly float defaultO2FromBlatterfish = SurvivalConstants.kBladderFishO2OnEat;
		public static readonly float defaultWeakSpeedThreshold = SurvivalConstants.kWeakSpeedThreshold;

		public static float FoodWaterHealThreshold { get; set; } = defaultFoodWaterHealThreshold;
		public static float BaseRegenRate { get; set; } = defaultBaseRegenRate;
		public static float O2FromBlatterfish { get; set; } = defaultO2FromBlatterfish;
		public static float WeakSpeedThreshold { get; set; } = defaultWeakSpeedThreshold;
	}
}