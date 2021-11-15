using HarmonyLib;
using StatsCore.Extensions;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(uGUI_WaterBar), nameof(uGUI_WaterBar.SetValue))]
    internal class uGUIWaterBar_SetValue
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
