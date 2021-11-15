using HarmonyLib;

namespace Stats_Core.Patches
{
	[HarmonyPatch(typeof(LaserCutter), nameof(LaserCutter.RandomizeIntensity))]
	internal class LaserCutter_RandomizeIntensity
	{
		[HarmonyPostfix]
		internal static void PostFix(LaserCutter __instance)
		{
			if (Guard.IsGamePaused())
				return;

			float min = Stats.equiptment.LaserCutter.MinRandomIntensity;
			float max = Stats.equiptment.LaserCutter.MaxRandomIntensity;

			__instance.lightIntensity = UnityEngine.Random.Range(min, max);
		}
	}
}
