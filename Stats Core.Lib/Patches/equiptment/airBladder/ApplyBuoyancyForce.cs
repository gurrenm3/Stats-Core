using HarmonyLib;
using Stats_Core.Extensions;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Stats_Core.Patches.equiptment.airBladder
{
    [HarmonyPatch(typeof(AirBladder), nameof(AirBladder.ApplyBuoyancyForce))]
    internal class AirBladder_ApplyBuoyancyForce_Hook
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var maxOxygenTranspiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Div });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!maxOxygenTranspiler.IsCurrentInstructionGood(i))
                    continue;

                codeInstructions[i] = maxOxygenTranspiler.CreateNewCodeInstruction<AirBladder_OnEnable_Hook>
                        (nameof(ReplaceMaxOxygen));
                break;
            }

            return codeInstructions;
        }

        public static float ReplaceMaxOxygen(float num1, float num2)
        {
            return num1 / Stats.equiptment.AirBladder.MaxOxygenConsumption;
        }
    }
}
