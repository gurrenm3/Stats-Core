using HarmonyLib;
using System.Reflection.Emit;
using System.Collections.Generic;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(Knife), nameof(Knife.GiveResourceOnDamage))]
    internal class Knife_GiveResourceOnDamage
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var baseResourceTranspiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Call, OpCodes.Ret });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!baseResourceTranspiler.IsCurrentInstructionGood(i))
                    continue;

                var newInstruction = baseResourceTranspiler.CreateNewCodeInstruction<Knife_GiveResourceOnDamage>
                        (nameof(GetBaseResourceOnDamage));

                codeInstructions[i] = newInstruction;
            }

            return codeInstructions;
        }

        public static void GetBaseResourceOnDamage(TechType harvestOutputData, int amount, bool noMessage, bool spawnIfCantAdd)
        {
            amount += Stats.KnifeData.BaseResourceOnDamage - 1; // subtracting 1 to account for the game adding 1 by default
            spawnIfCantAdd = Stats.KnifeData.SpawnResourceIfCantAdd;
            CraftData.AddToInventory(harvestOutputData, amount, noMessage, spawnIfCantAdd);
        }
    }
}
