using HarmonyLib;
using Stats_Core.Extensions;

namespace Stats_Core.Patches.uGui_WaterBar
{
    [HarmonyPatch(typeof(uGUI_WaterBar), nameof(uGUI_WaterBar.SetValue))]
    internal class uGUIWaterBar_SetValue_Hook
    {
        [HarmonyPrefix]
        public static bool Prefix(uGUI_WaterBar __instance, ref float capacity)
        {
            capacity = Player.main.GetSurvival().GetWaterCapacity();
            return true;
        }

        [HarmonyPostfix]
        public static void Postfix(uGUI_WaterBar __instance)
        {
            __instance.pulseReferenceCapacity = Player.main.GetSurvival().GetWaterCapacity();
        }
    }
}
