﻿using HarmonyLib;

namespace StatsCore.Patches
{
	[HarmonyPatch(typeof(HeatBlade), nameof(HeatBlade.GetUsesPerHit))]
	internal class HeatBlade_GetUsesPerHit_Patch
	{
		[HarmonyPostfix]
		internal static void PostFix(HeatBlade __instance, ref int __result)
		{
			if (Guard.IsGamePaused())
				return;

			__result = Stats.HeatBladeData.UsesPerHit;
		}
	}
}