using HarmonyLib;
using static Stats_Core.Stats.equiptment.BuilderTool;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

namespace Stats_Core.Patches
{
    [HarmonyPatch(typeof(BuilderTool), nameof(BuilderTool.HandleInput))]
    internal class BuilderTool_HandleInput
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var getTargetTranspiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Call, OpCodes.Pop });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!getTargetTranspiler.IsCurrentInstructionGood(i))
                    continue;

                codeInstructions[i] = getTargetTranspiler.CreateNewCodeInstruction<BuilderTool_HandleInput>
                        (nameof(GetTargetCustomRange));
                break;
            }

            return codeInstructions;
        }

        public static bool GetTargetCustomRange(float num1, out GameObject gameObject, out float num, Targeting.FilterRaycast filter)
        {
            return Targeting.GetTarget(HitRange, out gameObject, out num, null);
        }
    }
}
