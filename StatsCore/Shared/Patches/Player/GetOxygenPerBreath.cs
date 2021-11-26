using HarmonyLib;
using static StatsCore.Stats.AirData;

namespace StatsCore.Patches
{

	[HarmonyPatch(typeof(Player), nameof(Player.GetOxygenPerBreath))]
	internal class Player_GetOxygenPerBreath
	{
		[HarmonyPostfix]
		internal static void PostFix(ref float __result)
		{
			if (Guard.IsGamePaused() || !newOxygenPerBreath.HasValue)
				return;

			__result = newOxygenPerBreath.Value;
		}
	}
}