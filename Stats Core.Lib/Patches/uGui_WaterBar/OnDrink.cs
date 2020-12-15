using HarmonyLib;
using Stats_Core.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using UnityEngine;

namespace Stats_Core.Patches.uGui_WaterBar
{
    [HarmonyPatch(typeof(uGUI_WaterBar), nameof(uGUI_WaterBar.OnDrink))]
    internal class uGUIWaterBar_OnDrink_Hook
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var transpiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Div, OpCodes.Call });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!transpiler.IsCurrentInstructionGood(i))
                    continue;

                var newInstruction = transpiler.CreateNewCodeInstruction<uGUIWaterBar_OnDrink_Hook>(nameof(GetCurrentWater));
                codeInstructions[i] = newInstruction;
                break;
            }

            return codeInstructions.AsEnumerable();
        }

        public static float GetCurrentWater(float drinkAmount, float defaultMaxStomach)
        {
            return Mathf.Clamp01(drinkAmount / Player.main.GetSurvival().GetWaterCapacity());
        }
    }
}
