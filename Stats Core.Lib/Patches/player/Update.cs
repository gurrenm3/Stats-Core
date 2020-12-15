using HarmonyLib;
using Stats_Core.Events;
using Stats_Core.Extensions;
using Stats_Core.Stat_Handlers;
using Stats_Core.Vehicles;
using static Stats_Core.Events.Player_Events;

namespace Stats_Core.Patches.player
{
	[HarmonyPatch(typeof(Player), nameof(Player.Update))]
	internal class Player_Update_Patch
	{
		private static HealthRegenHandler healthRegenHandler = new HealthRegenHandler();

		[HarmonyPrefix]
		internal static bool Prefix()
		{
			if (Guard.IsGamePaused())
				return true;

			healthRegenHandler.HandleHealthRegen();
			return true;
		}

		[HarmonyPostfix]
		internal static void PostFix(Player __instance)
		{
			if (Guard.IsGamePaused())
				return;

			ResetSurvivalForNewborn(__instance);

			PlayerEventArgs args = new PlayerEventArgs();
			args.Player = __instance;

			Player_Events playerStats = new Player_Events();
			playerStats.OnPlayerUpdated(args);

			/*if (__instance.motorMode == Player.MotorMode.Seaglide)
			{
				Player.main.playerController.activeController.forwardMaxSpeed = SeaglideStats.ForwardMaxSpeed;
				Player.main.playerController.activeController.backwardMaxSpeed = SeaglideStats.BackwardsMaxSpeed;
				Player.main.playerController.activeController.strafeMaxSpeed = SeaglideStats.StrafeMaxSpeed;
				Player.main.playerController.activeController.acceleration = SeaglideStats.Acceleration;
			}*/
		}

		private static bool resetSurvivalForNewBorn = false;
		private static void ResetSurvivalForNewborn(Player __instance)
        {
			if (__instance.IsNewBorn() && !resetSurvivalForNewBorn)
			{
				__instance.GetSurvival().Reset();
				resetSurvivalForNewBorn = true;
			}
		}
	}
}
