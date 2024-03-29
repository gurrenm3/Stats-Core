﻿using HarmonyLib;
using StatsCore.Extensions;
using StatsCore.Stat_Handlers;
using UnityEngine;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(Player), nameof(Player.Update))]
    internal class Player_Update
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
#if Subnautica
				__instance.GetSurvival().Reset();
#elif BelowZero
				__instance.GetSurvival().ResetStats();
#endif
				resetSurvivalForNewBorn = true;
			}
		}
	}
}