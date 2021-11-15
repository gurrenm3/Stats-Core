using HarmonyLib;

namespace StatsCore.Patches
{
	[HarmonyPatch(typeof(Knife), nameof(Knife.GetUsesPerHit))]
	internal class Knife_GetUsesPerHit
	{
		[HarmonyPostfix]
		internal static void PostFix(Knife __instance, ref int __result)
		{
			if (Guard.IsGamePaused())
				return;

			__result = Stats.KnifeData.UsesPerHit;
		}
	}
}
