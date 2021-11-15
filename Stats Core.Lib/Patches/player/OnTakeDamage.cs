using HarmonyLib;
using Stats_Core.Stat_Handlers;
using UnityEngine;
using Stats_Core.Extensions;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Stats_Core.Patches
{
	[HarmonyPatch(typeof(Player), nameof(Player.OnTakeDamage))]
	internal class Player_OnTakeDamage
	{
        private static DamageResistanceHandler damageResistanceHandler = new DamageResistanceHandler();
        private static Player playerInstance;

        [HarmonyPrefix]
        internal static bool Prefix(Player __instance, DamageInfo damageInfo)
        {
            if (Guard.IsGamePaused())
                return true;

            playerInstance = __instance;

            damageResistanceHandler.ApplyDamageResistance(damageInfo);
            return true;
        }


        [HarmonyPostfix]
        internal static void PostFix(Player __instance, DamageInfo damageInfo)
        {
            if (Guard.IsGamePaused())
                return;

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

                codeInstructions[i] = maxHealthTranspiler.CreateNewCodeInstruction<Player_OnTakeDamage>(nameof(GetHealthPercent));

                break;
            }

            return codeInstructions;
        }

        public static float GetHealthPercent(float damage, float oldMaxHealth)
        {
            var newMaxHealth = (Player.main.liveMixin is null) ? 100f : Player.main.liveMixin.maxHealth;
            return damage / newMaxHealth;
        }
    }
}
