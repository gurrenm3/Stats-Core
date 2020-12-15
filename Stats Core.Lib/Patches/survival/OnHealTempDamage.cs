using HarmonyLib;
using Stats_Core.Extensions;
using UnityEngine;

namespace Stats_Core.Patches.survival
{
    [HarmonyPatch(typeof(Survival), nameof(Survival.OnHealTempDamage))]
    internal class Survival_OnHealTempDamage_Hook
    {
        [HarmonyPostfix]
        public static void Postfix(Survival __instance, float damage)
        {
            float foodPerTempDamage = __instance.GetFoodPerTempDamage();
            float value = __instance.food - damage * foodPerTempDamage;
            
            const float min = 0;
            float max = __instance.GetStomachOverfillSize();
            __instance.food = Mathf.Clamp(value, min, max);
        }
    }
}