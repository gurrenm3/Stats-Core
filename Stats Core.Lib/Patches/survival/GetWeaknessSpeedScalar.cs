using HarmonyLib;
using Stats_Core.Extensions;

namespace Stats_Core.Patches.survival
{
    /// <summary>
    /// This class hasn't been tested yet
    /// </summary>
    internal class GetWeaknessSpeedScalar
    {
        internal static float weakness;

        #region Patches
        [HarmonyPrefix]
        internal static bool Prefix(Survival __instance)
        {
            var patch = new GetWeaknessSpeedScalar();
            patch.NewPrefixPatch(__instance);
            return false;
        }

        [HarmonyPostfix]
        internal static void Postfix(Survival __instance, ref float __result)
        {
            __result = weakness;
        }
        #endregion


        private void NewPrefixPatch(Survival instance)
        {
            var lowFoodThreshold = instance.GetLowFoodThreshold();
            var lowWaterThreshold = instance.GetLowWaterThreshold();
            var weakSpeedThreshold = instance.GetWeakSpeedThreshold();

            weakness = 1;
            if (instance.food < lowFoodThreshold)
            {
                weakness -= (weakSpeedThreshold - instance.food) * 0.02f;
            }
            if (instance.water < lowWaterThreshold)
            {
                weakness -= (weakSpeedThreshold - instance.water) * 0.02f;
            }
        }
    }
}
