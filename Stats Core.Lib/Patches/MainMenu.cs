using HarmonyLib;

namespace StatsCore.Patches
{
	[HarmonyPatch(typeof(MainMenuController), nameof(MainMenuController.Start))]
	internal class MainMenuController_Start
	{
		[HarmonyPrefix]
		internal static bool Prefix()
		{
			return true;
		}

		[HarmonyPostfix]
		internal static void PostFix()
		{
			
		}
	}
}
