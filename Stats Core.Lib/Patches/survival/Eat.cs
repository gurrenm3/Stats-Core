using HarmonyLib;
using Stats_Core.Extensions;
using UnityEngine;


namespace Stats_Core.Patches.survival
{
    [HarmonyPatch(typeof(Survival), nameof(Survival.Eat))]
    internal class Survival_Eat_Hook
    {
        internal static bool flag;
        #region Patches
        [HarmonyPrefix]
        internal static bool Prefix(Survival __instance, GameObject useObj)
        {
            var patch = new Survival_Eat_Hook();
            patch.NewPrefixPatch(__instance, useObj);
            return false;
        }

        [HarmonyPostfix]
        internal static void Postfix(Survival __instance, ref bool __result)
        {
            __result = flag;
        }
        #endregion


        private void NewPrefixPatch(Survival __instance, GameObject useObj)
        {
			flag = false;
			if (useObj != null)
			{
				Eatable component = useObj.GetComponent<Eatable>();
				if (component != null)
				{
					if (component.GetFoodValue() != 0f)
					{
						float miniFoodOverfill = __instance.GetStomachSize() - 1;
						if (__instance.food <= miniFoodOverfill)
						{
							__instance.food = Mathf.Clamp(__instance.food + component.GetFoodValue(), 0f, __instance.GetStomachOverfillSize());
						}
						__instance.onEat.Trigger(component.GetFoodValue());
						if (component.GetFoodValue() > 0f)
						{
							GoalManager.main.OnCustomGoalEvent("Eat_Something");
						}
						flag = true;
					}

					if (component.GetWaterValue() != 0f)
					{
						float minWaterOverfill = __instance.GetWaterCapacity() - 1;
						if (__instance.water <= minWaterOverfill)
						{
							__instance.water = Mathf.Clamp(__instance.water + component.GetWaterValue(), 0f, __instance.GetWaterOverfillSize());
						}
						__instance.onDrink.Trigger(component.GetWaterValue());
						if (component.GetWaterValue() > 0f)
						{
							GoalManager.main.OnCustomGoalEvent("Drink_Something");
						}
						flag = true;
					}

					var lowFoodThreshold = __instance.GetLowFoodThreshold();
					var lowWaterThreshold = __instance.GetLowWaterThreshold();

					bool foodOkay = (__instance.food > lowFoodThreshold && __instance.food - component.GetFoodValue() < lowFoodThreshold);
					bool waterOkay = (__instance.water > lowWaterThreshold && __instance.water - component.GetWaterValue() < lowWaterThreshold);
					if (foodOkay || waterOkay)
					{
						__instance.vitalsOkNotification.Play();
					}
				}


				if (flag)
				{
					TechType techType = CraftData.GetTechType(useObj);
					if (techType == TechType.None)
					{
						Pickupable component2 = useObj.GetComponent<Pickupable>();
						if (component2)
						{
							techType = component2.GetTechType();
						}
					}
					FMODUWE.PlayOneShot(CraftData.GetUseEatSound(techType), Player.main.transform.position, 1f);
					if (techType == TechType.Bladderfish)
					{
						Player.main.GetComponent<OxygenManager>().AddOxygen(__instance.GetO2FromBlatterfish());
					}
				}
			}
		}
    }
}
