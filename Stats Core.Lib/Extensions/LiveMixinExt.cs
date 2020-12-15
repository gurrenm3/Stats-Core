using Stats_Core.Stats.player;

namespace Stats_Core.Extensions
{
    public static class LiveMixinExt
    {
        public static void AddMaxHealth(this LiveMixin liveMixin, float amount) => liveMixin.data.maxHealth += amount;
        public static void SubtractMaxHealth(this LiveMixin liveMixin, float amount) => liveMixin.data.maxHealth -= amount;
        public static void SetMaxHealth(this LiveMixin liveMixin, float amount) => liveMixin.data.maxHealth = amount;


        public static float GetHealthRegenDelay(this LiveMixin liveMixin) => Health.HealthRegenDelay;
        public static void AddHealthRegenDelay(this LiveMixin liveMixin, float amount) => Health.HealthRegenDelay += amount;
        public static void SubtractHealthRegenDelay(this LiveMixin liveMixin, float amount) => Health.HealthRegenDelay -= amount;
        public static void SetHealthRegenDelay(this LiveMixin liveMixin, float amount) => Health.HealthRegenDelay = amount;


        public static float GetHealthRegenAmount(this LiveMixin liveMixin) => Health.HealthRegenAmount;
        public static void AddHealthRegenAmount(this LiveMixin liveMixin, float amount) => Health.HealthRegenAmount += amount;
        public static void SubtractHealthRegenAmount(this LiveMixin liveMixin, float amount) => Health.HealthRegenAmount -= amount;
        public static void SetHealthRegenAmount(this LiveMixin liveMixin, float amount) => Health.HealthRegenAmount = amount;


        public static float GetHealthRegenDelay_AfterDamage(this LiveMixin liveMixin) => Health.HealthRegen_Delay_AfterDamage;
        public static void AddHealthRegenDelay_AfterDamage(this LiveMixin liveMixin, float amount) => Health.HealthRegen_Delay_AfterDamage += amount;
        public static void SubtractHealthRegenDelay_AfterDamage(this LiveMixin liveMixin, float amount) => Health.HealthRegen_Delay_AfterDamage -= amount;
        public static void SetHealthRegenDelay_AfterDamage(this LiveMixin liveMixin, float amount) => Health.HealthRegen_Delay_AfterDamage = amount;
    }
}
