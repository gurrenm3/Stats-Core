namespace StatsCore.Stat_Handlers
{
    using StatsCore.Extensions;
    using UnityEngine;
	

	internal class HealthRegenHandler
    {
		private static float nextHealthRegen = 0f;
		internal static float healthRegen_Delay_AfterDamage = 0f;
		private LiveMixin liveMixin;

		internal void HandleHealthRegen()
		{
			liveMixin = Player.main.liveMixin;
			if (CanRegenHealth())
				RegenHealth();
		}
		
		private bool CanRegenHealth()
		{
			bool isHealthFull = (liveMixin.health == liveMixin.maxHealth);
			if (isHealthFull)
				return false;

			bool hasNoWaitAfterDamage = (Time.time >= healthRegen_Delay_AfterDamage);
			bool canDoNextRegen = (Time.time >= nextHealthRegen);

			bool canRegenHealth = (hasNoWaitAfterDamage && canDoNextRegen);
			return canRegenHealth;
		}

		private void RegenHealth()
		{
			float maxHealth = liveMixin.maxHealth;
			float nextSetHealth = liveMixin.health + liveMixin.GetHealthRegenAmount();
			liveMixin.health = (nextSetHealth >= maxHealth) ? maxHealth : nextSetHealth;
			nextHealthRegen = Time.time + liveMixin.GetHealthRegenDelay();
		}
	}
}
