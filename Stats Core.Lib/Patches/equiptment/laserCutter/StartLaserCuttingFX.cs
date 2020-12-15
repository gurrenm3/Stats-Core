using HarmonyLib;
using Stats_Core.Extensions;

namespace Stats_Core.Patches.equiptment.laserCutter
{
    [HarmonyPatch(typeof(LaserCutter), nameof(LaserCutter.StartLaserCuttingFX))]
    internal class LaserCutter_StartLaserCuttingFX_Hook
    {
		[HarmonyPrefix]
		internal static bool Prefix(LaserCutter __instance)
		{
			if (__instance.fxControl != null && !__instance.fxIsPlaying)
			{
				int i = Player.main.IsUnderwater() ? 1 : 0;
				__instance.fxControl.Play(i);
				__instance.fxIsPlaying = true;
				__instance.fxLight.enabled = true;

				float repeatRate = Stats.equiptment.LaserCutter.RandomizeIntensityRepeatRate;
				__instance.InvokeRepeating("RandomizeIntensity", 0f, repeatRate);
				__instance.totalTimeActive = 0f;
			}

			return false;
		}
	}
}
