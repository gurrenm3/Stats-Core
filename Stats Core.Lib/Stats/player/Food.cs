namespace StatsCore.Stats
{
	/// <summary>
	/// Contains extra methods/variables for manipulating food in <see cref="Survival"/>. 
	/// Needed because some values are hard coded in Subnautica and therefore new variables/methods are needed.
	/// </summary>
	public static class Food
    {
		/// <summary>
		/// The default starting food.
		/// </summary>
		public static readonly float defaultStartingFood = SurvivalConstants.kStartFoodStat;

		/// <summary>
		/// The default minimum food amount.
		/// </summary>
		public static readonly float defaultMinFood = 0;

		/// <summary>
		/// The default stomach size.
		/// </summary>
		public static readonly float default_StomachSize = SurvivalConstants.kMaxStat;

		/// <summary>
		/// The default overfill size.
		/// </summary>
		public static readonly float default_OverFillStomachSize = SurvivalConstants.kMaxOverfillStat;

		/// <summary>
		/// 
		/// </summary>
		public static readonly float defaultFoodPerTempDamage = SurvivalConstants.kFoodPerTempDamage;

		/// <summary>
		/// The default amount of time between consuming food.
		/// </summary>
		public static readonly float defaultFoodTime = SurvivalConstants.kFoodTime;

		/// <summary>
		/// The default amount of starve damage.
		/// </summary>
		public static readonly float defaultStarveDamage = SurvivalConstants.kStarveDamage;

		/// <summary>
		/// The default value for low food warnings.
		/// </summary>
		public static readonly float defaultLowFoodThreshold = SurvivalConstants.kLowFoodThreshold;

		/// <summary>
		/// The default value for critically low food warnings.
		/// </summary>
		public static readonly float defaultCriticalFoodThreshold = SurvivalConstants.kCriticalFoodThreshold;


		/// <summary>
		/// A placeholder variable for manually adjusting the amount of food the player starts with whenever respawning.
		/// </summary>
		public static float StartingFood { get; set; } = defaultStartingFood;

		/// <summary>
		/// A placeholder variable for manually adjusting the minimum amount of food.
		/// Useful for raising the minimum above or below zero.
		/// </summary>
		public static float MinFood { get; set; } = defaultMinFood;

		/// <summary>
		/// A placeholder variable for manually adjusting the size of the stomach.
		/// </summary>
		public static float StomachSize { get; set; } = default_StomachSize;

		/// <summary>
		/// A placeholder variable for manually adjusting the overfill stomach size.
		/// </summary>
		public static float OverfillStomachSize { get; set; } = default_OverFillStomachSize;

		/// <summary>
		/// 
		/// </summary>
		public static float FoodPerTempDamage { get; set; } = defaultFoodPerTempDamage;

		/// <summary>
		/// A placeholder variable for manually adjusting the time between consuming food.
		/// </summary>
		public static float FoodTime { get; set; } = defaultFoodTime;

		/// <summary>
		/// A placeholder variable for manually adjusting the starve damage.
		/// </summary>
		public static float StarveDamage { get; set; } = defaultStarveDamage;

		/// <summary>
		/// A placeholder variable for manually adjusting the threshold for low food warnings.
		/// </summary>
		public static float LowFoodThreshold { get; set; } = defaultLowFoodThreshold;

		/// <summary>
		/// A placeholder variable for manually adjusting the threshold for critical food warnings.
		/// </summary>
		public static float CriticalFoodThreshold { get; set; } = defaultCriticalFoodThreshold;
	}
}