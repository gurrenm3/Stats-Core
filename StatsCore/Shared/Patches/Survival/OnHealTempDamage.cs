using HarmonyLib;
using StatsCore.Extensions;
using UnityEngine;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(Survival), nameof(Survival.OnHealTempDamage))]
    internal class Survival_OnHealTempDamage
    {
        [HarmonyPostfix]
        public static void Postfix(Survival __instance, float damage)
        {
            float foodPerTempDamage = __instance.GetFoodPerTempDamage();
            float value = __instance.food - damage * foodPerTempDamage;
            
            float min =__instance.GetMinStomachSize();
            float max = __instance.GetStomachOverfillSize();
            __instance.food = Mathf.Clamp(value, min, max);
        }
    }
}