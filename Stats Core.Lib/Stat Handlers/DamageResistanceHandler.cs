using Stats_Core.Extensions;

namespace Stats_Core.Stat_Handlers
{
    internal class DamageResistanceHandler
    {
		private LiveMixin liveMixin = Player.main.liveMixin;

		internal void ApplyDamageResistance(DamageInfo damageInfo)
		{
			float percentToIgnore = GetAmountToIgnore(damageInfo);
			ApplyDamageResistance(damageInfo, percentToIgnore);
		}

		internal void ApplyDamageResistance(DamageInfo damageInfo, float percentToIgnore)
        {
			if (!HasDamageResistance(percentToIgnore))
				return;

			AddResistanceToHealth(damageInfo.damage, percentToIgnore);
		}


		private void AddResistanceToHealth(float damageAmount, float percentToIgnore)
		{
			float totalAmountToIgnore = damageAmount * percentToIgnore;
			liveMixin.health += totalAmountToIgnore;
		}

		private float GetAmountToIgnore(DamageInfo damageInfo)
        {
			float resistanceAmount = damageInfo.GetResistance();
			float percentToIgnore = resistanceAmount / liveMixin.maxHealth;
			return percentToIgnore;
		}
		
		private bool HasDamageResistance(float resistanceAmount)
        {
			const float noResistance = 0;
			bool hasResistance = resistanceAmount > noResistance;

			return hasResistance;
		}
	}
}