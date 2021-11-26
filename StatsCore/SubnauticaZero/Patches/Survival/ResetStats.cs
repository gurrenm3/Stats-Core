using HarmonyLib;
using StatsCore.Extensions;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(Survival), nameof(Survival.ResetStats))]
    internal class Survival_Reset
    {
        [HarmonyPostfix]
        public static void Postfix(Survival __instance)
        {
            __instance.food = __instance.GetStartingFood();
            __instance.water = __instance.GetStartingWater();
        }
    }
}