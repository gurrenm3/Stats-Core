using HarmonyLib;
using Stats_Core.Stat_Handlers;
using UnityEngine;
using Stats_Core.Events;
using Stats_Core.Extensions;
using static Stats_Core.Events.Player_Events;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Stats_Core.Patches.player
{
	[HarmonyPatch(typeof(Player), nameof(Player.OnTakeDamage))]
	internal class Player_OnTakeDamage_Patch
	{
        private static DamageResistanceHandler damageResistanceHandler;

        [HarmonyPrefix]
        internal static bool Prefix(Player __instance, DamageInfo damageInfo)
        {
            if (Guard.IsGamePaused())
                return true;

            if (damageResistanceHandler is null)
                damageResistanceHandler = new DamageResistanceHandler();

            damageResistanceHandler.ApplyDamageResistance(damageInfo);
            return true;
        }


        [HarmonyPostfix]
        internal static void PostFix(Player __instance, DamageInfo damageInfo)
        {
            if (Guard.IsGamePaused())
                return;

            var args = new PlayerEventArgs();
            args.Player = __instance;
            args.damageInfo = damageInfo;

            Player_Events stats = new Player_Events();
            stats.OnDamageTaken(args);

            HealthRegenHandler.healthRegen_Delay_AfterDamage = Time.time + __instance.liveMixin.GetHealthRegenDelay_AfterDamage();
        }


        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var maxHealthTranspiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Div });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!maxHealthTranspiler.IsCurrentInstructionGood(i))
                    continue;

                codeInstructions[i] = maxHealthTranspiler.CreateNewCodeInstruction<Player_OnTakeDamage_Patch>
                        (nameof(GetDamagePercentOfMaxHealth));

                break;
            }

            return codeInstructions;
        }

        public static float GetDamagePercentOfMaxHealth(float damage, float oldMaxHealth)
        {
            var newMaxHealth = (Player.main.liveMixin is null) ? 100f : Player.main.liveMixin.maxHealth;
            return damage / newMaxHealth;
        }
    }
}
