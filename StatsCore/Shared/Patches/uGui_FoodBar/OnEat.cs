﻿using HarmonyLib;
using StatsCore.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using UnityEngine;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(uGUI_FoodBar), nameof(uGUI_FoodBar.OnEat))]
    internal class uGUIFoodBar_OnEat
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var transpiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Div, OpCodes.Call });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!transpiler.IsCurrentInstructionGood(i))
                    continue;

                var newInstruction = transpiler.CreateNewCodeInstruction<uGUIFoodBar_OnEat>(nameof(GetCurrentFood));
                codeInstructions[i] = newInstruction;
                break;
            }

            return codeInstructions.AsEnumerable();
        }

        public static float GetCurrentFood(float eatAmount, float defaultMaxStomach)
        {
            return Mathf.Clamp01(eatAmount / Player.main.GetSurvival().GetStomachSize());
        }
    }
}
