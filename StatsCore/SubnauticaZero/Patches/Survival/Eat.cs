using HarmonyLib;
using StatsCore.Extensions;
using UnityEngine;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(Survival), nameof(Survival.Eat))]
    internal class Survival_Eat
    {
        internal static bool result;

        #region Patches

        [HarmonyPrefix]
        internal static bool Prefix(Survival __instance, GameObject useObj)
        {
            var patch = new Survival_Eat();
            patch.NewPrefixPatch(__instance, useObj);
            return false;
        }

        [HarmonyPostfix]
        internal static void Postfix(Survival __instance, ref bool __result)
        {
            __result = result;
        }

        #endregion

		/// <summary>
		/// This is a copy paste of the original <see cref="Survival.Eat(GameObject)"/> because there are too many things to transpile
		/// </summary>
		/// <param name="__instance"></param>
		/// <param name="useObj"></param>
        private void NewPrefixPatch(Survival __instance, GameObject useObj)
        {
			bool flag = false;
			if (useObj != null)
			{
				Eatable component = useObj.GetComponent<Eatable>();
				if (component != null)
				{
					bool flag2 = component.maxCharges == 0 || component.charges > 0;
					if (component.GetFoodValue() != 0f && flag2)
					{
						if (__instance.food <= __instance.GetStomachSize() - 1)
						{
							__instance.food = Mathf.Clamp(__instance.food + component.GetFoodValue(), __instance.GetMinStomachSize(), __instance.GetStomachOverfillSize());
						}
						__instance.onEat.Trigger(component.GetFoodValue());
						if (component.GetFoodValue() > 0f)
						{
							GoalManager.main.OnCustomGoalEvent("Eat_Something");
						}
						result = component.removeOnUse;
						flag = true;
					}
					if (component.GetWaterValue() != 0f && flag2)
					{
						__instance.water = Mathf.Clamp(__instance.water + component.GetWaterValue(), __instance.GetMinWater(), __instance.GetWaterOverfillSize());
						__instance.onDrink.Trigger(component.GetWaterValue());
						if (component.GetWaterValue() > 0f)
						{
							GoalManager.main.OnCustomGoalEvent("Drink_Something");
						}
						result = component.removeOnUse;
						flag = true;
					}
					float healthValue = component.GetHealthValue();
					if (healthValue != 0f && flag2)
					{
						if (healthValue > 0f)
						{
							__instance.liveMixin.AddHealth(healthValue);
							GoalManager.main.OnCustomGoalEvent("Heal_Damage");
						}
						else if (healthValue <= -1f)
						{
							__instance.liveMixin.TakeDamage(-healthValue, default(Vector3), DamageType.FoodPoison, null);
						}
						result = component.removeOnUse;
						flag = true;
					}
					float coldMeterValue = component.GetColdMeterValue();
					if (coldMeterValue != 0f && flag2)
					{
						__instance.bodyTemperature.AddCold(coldMeterValue);
						result = component.removeOnUse;
						flag = true;
					}
					if (!__instance.InConversation() && ((__instance.food > __instance.GetLowFoodThreshold() && __instance.food - component.GetFoodValue() < __instance.GetLowFoodThreshold()) || (__instance.water > __instance.GetLowWaterThreshold() && __instance.water - component.GetWaterValue() < __instance.GetLowWaterThreshold())))
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
					FMODAsset useSound = __instance.player.GetUseSound(TechData.GetSoundType(techType));
					if (useSound)
					{
						Utils.PlayFMODAsset(useSound, __instance.player.transform.position, 20f);
					}
					if (component.IsRotten())
					{
						Utils.PlayFMODAsset(__instance.ateRottenFoodSound, __instance.player.transform.position, 20f);
					}
					if (techType == TechType.Bladderfish)
					{
						Player.main.GetComponent<OxygenManager>().AddOxygen(__instance.GetO2FromBlatterfish());
					}
					if (component.maxCharges > 0)
					{
						component.ConsumeCharge();
					}
				}
			}
		}
    }
}
