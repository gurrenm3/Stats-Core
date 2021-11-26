using HarmonyLib;
using static StatsCore.Stats.AirData;

namespace StatsCore.Patches
{
	[HarmonyPatch(typeof(Player), nameof(Player.GetBreathPeriod))]
	internal class Player_GetBreathPeriod
	{
		[HarmonyPostfix]
		internal static void PostFix(ref float __result)
		{
			if (Guard.IsGamePaused() || !newBreathPeriod.HasValue)
				return;

			__result = newBreathPeriod.Value;
		}
	}
}
