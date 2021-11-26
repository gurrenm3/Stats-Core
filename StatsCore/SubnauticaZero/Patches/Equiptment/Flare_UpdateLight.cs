using HarmonyLib;
using StatsCore.Stats;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(Flare), nameof(Flare.UpdateLight))]
    internal class Flare_UpdateLight
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var transpiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Div });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!transpiler.IsCurrentInstructionGood(i))
                    continue;

                var newInstruction = transpiler.CreateNewCodeInstruction<Flare_UpdateLight>(nameof(GetFlickerInterval));

                const int offsetToInstruction = 0;
                codeInstructions[i + offsetToInstruction] = newInstruction;
                break;
            }

            return codeInstructions.AsEnumerable();
        }

        public static float GetFlickerInterval(float num, float flickerInterval)
        {
            return num / FlareData.FlickerInterval;
        }
    }
}
