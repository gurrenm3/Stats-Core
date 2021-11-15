using HarmonyLib;
using StatsCore.Extensions;

namespace StatsCore.Patches
{
    /// <summary>
    /// This class hasn't been tested yet
    /// </summary>
    internal class Survival_GetWeaknessSpeedScalar
    {
        private static float weakness;

        [HarmonyPrefix]
        internal static bool Prefix(Survival __instance)
        {
            weakness = 1;

            var weakSpeedThreshold = __instance.GetWeakSpeedThreshold();
            if (__instance.food < __instance.GetLowFoodThreshold())
            {
                weakness -= (weakSpeedThreshold - __instance.food) * 0.02f;
            }
            if (__instance.water < __instance.GetLowWaterThreshold())
            {
                weakness -= (weakSpeedThreshold - __instance.water) * 0.02f;
            }

            return false;
        }

        [HarmonyPostfix]
        internal static void Postfix(Survival __instance, ref float __result)
        {
            __result = weakness;
        }
    }
}
