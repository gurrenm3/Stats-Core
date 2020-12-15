using HarmonyLib;

namespace Stats_Core.Patches.equiptment.knife
{
	[HarmonyPatch(typeof(Knife), nameof(Knife.GetUsesPerHit))]
	internal class Knife_GetUsesPerHit_Patch
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
