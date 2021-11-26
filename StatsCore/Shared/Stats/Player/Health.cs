namespace StatsCore.Stats
{
	public static class HealthData
    {
		public static float MaxHealth
		{
			get { return Player.main.liveMixin.data.maxHealth; }
			set { Player.main.liveMixin.data.maxHealth = value; }
		}

		public static float HealthRegenDelay { get; set; } = 0;
		public static float HealthRegenAmount { get; set; } = 0;
		public static float HealthRegen_Delay_AfterDamage { get; set; } = 0;
	}
}
