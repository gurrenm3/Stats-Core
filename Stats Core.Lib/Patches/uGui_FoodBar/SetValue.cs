using HarmonyLib;
using Stats_Core.Extensions;

namespace Stats_Core.Patches.uGui_FoodBar
{
    [HarmonyPatch(typeof(uGUI_FoodBar), nameof(uGUI_FoodBar.SetValue))]
    internal class uGUIFoodBar_SetValue_Hook
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