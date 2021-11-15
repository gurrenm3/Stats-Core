using HarmonyLib;
using StatsCore.Extensions;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(uGUI_FoodBar), nameof(uGUI_FoodBar.SetValue))]
    internal class uGUIFoodBar_SetValue
    {
        [HarmonyPrefix]
        public static bool Prefix(uGUI_FoodBar __instance, ref float capacity)
        {
            capacity = Player.main.GetSurvival().GetStomachSize();
            return true;
        }

        [HarmonyPostfix]
        public static void Postfix(uGUI_FoodBar __instance)
        {
            __instance.pulseReferenceCapacity = Player.main.GetSurvival().GetStomachSize();
        }
    }
}