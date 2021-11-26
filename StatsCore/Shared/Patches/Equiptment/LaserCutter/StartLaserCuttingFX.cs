using HarmonyLib;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(LaserCutter), nameof(LaserCutter.StartLaserCuttingFX))]
    internal class LaserCutter_StartLaserCuttingFX
    {
		[HarmonyPrefix]
		internal static bool Prefix(LaserCutter __instance)
		{
			if (__instance.fxControl != null && !__instance.fxIsPlaying)
			{
				float repeatRate = Stats.LaserCutterData.RandomizeIntensityRepeatRate;
#if Subnautica
				int i = Player.main.IsUnderwater() ? 1 : 0;
				__instance.fxControl.Play(i);
				__instance.fxIsPlaying = true;
				__instance.fxLight.enabled = true;
				
				__instance.InvokeRepeating("RandomizeIntensity", 0f, repeatRate);
				__instance.totalTimeActive = 0f;

#elif BelowZero
				int i = Player.main.IsUnderwater() ? 1 : 0;
				if (MiscSettings.flashes)
				{
					__instance.fxControl.Play(i);
					__instance.fxLight.enabled = true;
				}
				__instance.fxControl.Play(3);
				__instance.fxIsPlaying = true;
				__instance.InvokeRepeating("RandomizeIntensity", 0f, repeatRate);
				__instance.totalTimeActive = 0f;
#endif
			}

			return false;
		}
	}
}
