using HarmonyLib;
using Stats_Core.Extensions;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Stats_Core.Patches.equiptment.knife
{
    [HarmonyPatch(typeof(Knife), nameof(Knife.GiveResourceOnDamage))]
    internal class Knife_GiveResourceOnDamage_Hook
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var baseResourceTranspiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Call, OpCodes.Ret });

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                if (!baseResourceTranspiler.IsCurrentInstructionGood(i))
                    continue;

                var newInstruction = baseResourceTranspiler.CreateNewCodeInstruction<Knife_GiveResourceOnDamage_Hook>
                        (nameof(GetBaseResourceOnDamage));

                codeInstructions[i] = newInstruction;
            }

            return codeInstructions;
        }

        public static void GetBaseResourceOnDamage(TechType harvestOutputData, int amount, bool noMessage, bool spawnIfCantAdd)
        {
            amount += Stats.equiptment.Knife.BaseResourceOnDamage;
            spawnIfCantAdd = Stats.equiptment.Knife.SpawnResourceIfCantAdd;
            CraftData.AddToInventory(harvestOutputData, amount, noMessage, spawnIfCantAdd);
        }
    }
}
