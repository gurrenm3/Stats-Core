using HarmonyLib;

namespace StatsCore.Patches
{
	[HarmonyPatch(typeof(LaserCutter), nameof(LaserCutter.RandomizeIntensity))]
	internal class LaserCutter_RandomizeIntensity
	{
		[HarmonyPostfix]
		internal static void PostFix(LaserCutter __instance)
		{
			if (Guard.IsGamePaused())
				return;

			float min = Stats.LaserCutterData.MinRandomIntensity;
			float max = Stats.LaserCutterData.MaxRandomIntensity;

			__instance.lightIntensity = UnityEngine.Random.Range(min, max);
		}
	}
}
