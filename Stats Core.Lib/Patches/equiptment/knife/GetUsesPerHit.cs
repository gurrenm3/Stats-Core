using HarmonyLib;

namespace Stats_Core.Patches
{
	[HarmonyPatch(typeof(Knife), nameof(Knife.GetUsesPerHit))]
	internal class Knife_GetUsesPerHit
	{
		[HarmonyPostfix]
		internal static void PostFix(Knife __instance, ref int __result)
		{
			if (Guard.IsGamePaused())
				return;

			__result = Stats.equiptment.Knife.UsesPerHit;
		}
	}
}
