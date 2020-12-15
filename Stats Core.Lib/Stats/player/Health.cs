namespace Stats_Core.Stats.player
{
	public static class Health
    {
		public static float MaxHealth
		{
			get { return Player.main.liveMixin.data.maxHealth; }
			set { Player.main.liveMixin.data.maxHealth = value; }
		}

		private static float healthRegenDelay = 0f;
		public static float HealthRegenDelay
		{
			get { return healthRegenDelay; }
			set { healthRegenDelay = value; }
		}

		private static float healthRegenAmount = 0f;
		public static float HealthRegenAmount
		{
			get { return healthRegenAmount; }
			set { healthRegenAmount = value; }
		}

		private static float healthRegen_Delay_AfterDamage = 0f;
		public static float HealthRegen_Delay_AfterDamage
		{
			get { return healthRegen_Delay_AfterDamage; }
			set { healthRegen_Delay_AfterDamage = value; }
		}
	}
}
