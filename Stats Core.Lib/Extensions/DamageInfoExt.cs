using Stats_Core.Stats.player;

namespace Stats_Core.Extensions
{
    public static class DamageInfoExt
    {
        public static float GetDamageTypeResistance(this DamageInfo damageInfo) => DamageTypeResistance.allResistances[damageInfo.type];
        public static void AddDamageTypeResistance(this DamageInfo damageInfo, float amount) => DamageTypeResistance.allResistances[damageInfo.type] += amount;
        public static void SubtractDamageTypeResistance(this DamageInfo damageInfo, float amount) => DamageTypeResistance.allResistances[damageInfo.type] -= amount;
    }
}
