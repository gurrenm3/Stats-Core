using HarmonyLib;
using Stats_Core.Extensions;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Stats_Core.Patches.liveMixin
{
    [HarmonyPatch(typeof(LiveMixin), nameof(LiveMixin.TakeDamage))]
    internal class LiveMixin_TakeDamage_Hook
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var tempDamageHealRateTranspiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Ldc_R4, OpCodes.Add, OpCodes.Ble_Un });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!tempDamageHealRateTranspiler.IsCurrentInstructionGood(i))
                    continue;

                const int offsetToInstruction = 1;
                codeInstructions[i + offsetToInstruction] = tempDamageHealRateTranspiler.CreateNewCodeInstruction<LiveMixin_TakeDamage_Hook>
                        (nameof(GetNewTempDamageHealRate));
                break;
            }

            return codeInstructions;
        }

        public static float GetNewTempDamageHealRate(float val1, float val2)
        {
            return val1 + LiveMixin.tempDamageHealRate;
        }
    }
}
