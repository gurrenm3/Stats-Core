﻿using HarmonyLib;
using Stats_Core.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using UnityEngine;

namespace Stats_Core.Patches.uGui_HealthBar
{
    [HarmonyPatch(typeof(uGUI_HealthBar), nameof(uGUI_HealthBar.OnHealDamage))]
    internal class uGUIHealthBar_OnHealDamage_Hook
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var transpiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Div, OpCodes.Call });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!transpiler.IsCurrentInstructionGood(i))
                    continue;

                var newInstruction = transpiler.CreateNewCodeInstruction<uGUIHealthBar_OnHealDamage_Hook>(nameof(GetMaxScale));
                codeInstructions[i] = newInstruction;
                break;
            }

            return codeInstructions.AsEnumerable();
        }

        public static float GetMaxScale(float damage, float defaultMaxHealth)
        {
            return Mathf.Clamp01(damage / Player.main.liveMixin.maxHealth);
        }
    }
}
