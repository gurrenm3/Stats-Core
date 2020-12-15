using HarmonyLib;
using System;
using UnityEngine;
using Stats_Core.Extensions;

namespace Stats_Core.Patches.survival
{
    [HarmonyPatch(typeof(Survival), nameof(Survival.UpdateStats))]
    internal class Survival_UpdateStats_Hook
    {
		internal static float totalFoodThirstDamage;

        #region Patches
        [HarmonyPrefix]
        internal static bool Prefix(Survival __instance, float timePassed)
        {
			var patch = new Survival_UpdateStats_Hook();
			patch.NewPrefixPatch(__instance, timePassed);
			return false;
		}

        internal void NewPrefixPatch(Survival instance)
        {
            throw new NotImplementedException();
        }

        [HarmonyPostfix]
		internal static void Postfix(Survival __instance, ref float __result)
		{
			__result = totalFoodThirstDamage;
		}
        #endregion


        private void NewPrefixPatch(Survival __instance, float timePassed)
		{
			totalFoodThirstDamage = 0f;
			const float minimumPastTime = 1.401298E-45f;

			if (minimumPastTime > timePassed)
				return;

			float startingFood = __instance.food;
			float startingWater = __instance.water;
			UpdateFood(__instance, timePassed);
			UpdateWater(__instance, timePassed);

			__instance.UpdateWarningSounds(__instance.foodWarningSounds, __instance.food, startingFood, __instance.GetLowFoodThreshold(), 
				__instance.GetCriticalFoodThreshold());

			__instance.UpdateWarningSounds(__instance.waterWarningSounds, __instance.water, startingWater, __instance.GetLowWaterThreshold(),
				__instance.GetCriticalWaterThreshold());
		}

		private static void UpdateFood(Survival __instance, float timePassed)
		{
			UpdateStat(timePassed, ref __instance.food, __instance.GetFoodTime(), __instance.GetMinStomachSize(), __instance.GetStomachSize(),
				__instance.GetStomachOverfillSize(), __instance.GetStarveDamage());
		}

		private static void UpdateWater(Survival __instance, float timePassed)
        {
			UpdateStat(timePassed, ref __instance.water, __instance.GetWaterTime(), __instance.GetMinWater(), __instance.GetWaterCapacity(),
				__instance.GetWaterOverfillSize(), __instance.GetDehydrationDamage());
		}

		private static void UpdateStat(float timePassed, ref float statCurrentValue, float statTime, float minStat, float maxStat, float overfillValue, float damage)
		{
			float statLoss = timePassed / statTime * maxStat;
			if (statLoss > statCurrentValue)
				totalFoodThirstDamage += (statLoss - statCurrentValue) * damage;

			statCurrentValue = Mathf.Clamp(statCurrentValue - statLoss, minStat, overfillValue);
		}
	}
}