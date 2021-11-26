using HarmonyLib;
using UnityEngine;
using System.Reflection.Emit;
using System.Collections.Generic;
using static StatsCore.Stats.BuilderToolData;

namespace StatsCore.Patches
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
                        (nameof(GetConstructionRange));
                break;
            }

#if BelowZero
            getTargetTranspiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Call, OpCodes.Brfalse_S, OpCodes.Ldloc_1, OpCodes.Ldc_R4, OpCodes.Bgt_Un_S });
            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!getTargetTranspiler.IsCurrentInstructionGood(i))
                    continue;

                const int offsetToInstruction = 0;
                codeInstructions[i + offsetToInstruction] = getTargetTranspiler.CreateNewCodeInstruction<BuilderTool_HandleInput>
                        (nameof(GetDeconstructionRange));
                break;
            }
#endif

            return codeInstructions;
        }
#if Subnautica
        public static bool GetConstructionRange(float num1, out GameObject gameObject, out float num, Targeting.FilterRaycast filter)
        {
            return Targeting.GetTarget(HitRange, out gameObject, out num, null);
#elif BelowZero
        public static bool GetConstructionRange(float num1, out GameObject gameObject, out float num)
        {
            return Targeting.GetTarget(HitRange, out gameObject, out num);
#endif
        }


#if BelowZero
        public static bool GetDeconstructionRange(float val1, float originalDeconstructionRange)
        {
            return val1 <= Stats.BuilderToolData.DeconstructionRange; 
        }
#endif
    }
}
