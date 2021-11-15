using HarmonyLib;
using static Stats_Core.Stats.player.Air;

namespace Stats_Core.Patches
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