﻿using HarmonyLib;

namespace Stats_Core.Patches
{
	[HarmonyPatch(typeof(MainMenuController), nameof(MainMenuController.Start))]
	internal class MainMenuController_Start_Hook
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
