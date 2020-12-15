using HarmonyLib;
using Stats_Core.Extensions;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

namespace Stats_Core.Patches.uGui_FoodBar
{
    [HarmonyPatch(typeof(uGUI_FoodBar), nameof(uGUI_FoodBar.LateUpdate))]
    internal class uGUIFoodBar_LateUpdate_Hook
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var transpiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Div, OpCodes.Call });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!transpiler.IsCurrentInstructionGood(i))
                    continue;

                var newInstruction = transpiler.CreateNewCodeInstruction<uGUIFoodBar_LateUpdate_Hook>(nameof(GetMaxFood));

                const int offsetToInstruction = 1;
                codeInstructions[i + offsetToInstruction] = newInstruction;
                break;
            }

            return codeInstructions;
        }

        public static float GetMaxFood(float value)
        {
            var survival = Player.main.GetSurvival();
            return Mathf.Clamp01(survival.food / survival.GetStomachSize());
        }
    }
}
