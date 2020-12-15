using HarmonyLib;
using Stats_Core.Extensions;

namespace Stats_Core.Patches.survival
{
    [HarmonyPatch(typeof(Survival), nameof(Survival.Reset))]
    internal class Survival_Reset_Hook
    {
        [HarmonyPostfix]
        public static void Postfix(Survival __instance)
        {
            __instance.food = __instance.GetStartingFood();
            __instance.water = __instance.GetStartingWater();
        }
    }
}