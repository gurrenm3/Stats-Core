using HarmonyLib;
using StatsCore.Extensions;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StatsCore.Patches
{
    [HarmonyPatch(typeof(Survival), nameof(Survival.UpdateHunger))]
    internal class Survival_UpdateHunger
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codeInstructions = new List<CodeInstruction>(instructions);
            var foodWaterTranspiler = new BaseTranspilerPatch(codeInstructions, new List<OpCode>() { OpCodes.Add });
            var baseRegenTranspiler = new BaseTranspilerPatch(codeInstructions, 
                new List<OpCode>() { OpCodes.Mul });

            bool setFoodWater = false;
            bool setBaseRegen = false;

            for (int i = 0; i < codeInstructions.Count; i++)
            {
                int offsetToInstruction = 0;
                var instruction = codeInstructions[i];

                
                if (!setFoodWater && foodWaterTranspiler.IsCurrentInstructionGood(i))
                {
                    instruction = foodWaterTranspiler.CreateNewCodeInstruction<Survival_UpdateHunger>
                        (nameof(GetFoodWaterHealThreshold));
                    offsetToInstruction = 1;
                    setFoodWater = true;
                }
                else if (!setBaseRegen && baseRegenTranspiler.IsCurrentInstructionGood(i))
                {
                    instruction = baseRegenTranspiler.CreateNewCodeInstruction<Survival_UpdateHunger>
                        (nameof(GetBaseRegen_HealthToAdd));
                    setBaseRegen = true;
                }

                codeInstructions[i + offsetToInstruction] = instruction;
            }

            return codeInstructions;
        }

        public static float GetFoodWaterHealThreshold()
        {
            return Player.main.GetSurvival().GetFoodWaterHealThreshold();
        }

        public static float GetBaseRegen_HealthToAdd(float num1, float num2)
        {
            var survival = Player.main.GetSurvival();
            var healthToAdd = (survival.GetBaseRegenRate() * survival.GetUpdateHungerInterval());
            return healthToAdd;
        }
    }
}
