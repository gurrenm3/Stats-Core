using HarmonyLib;
using static Stats_Core.Stats.player.Air;

namespace Stats_Core.Patches.player
{
	[HarmonyPatch(typeof(Player), nameof(Player.GetBreathPeriod))]
	internal class Player_GetBreathPeriod_Hook
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
