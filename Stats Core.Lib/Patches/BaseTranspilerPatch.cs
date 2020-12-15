using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Stats_Core.Patches
{
    internal class BaseTranspilerPatch
    {
        public List<CodeInstruction> codeInstructions;
        public List<OpCode> correctOpCodes;

        public BaseTranspilerPatch() { }

        public BaseTranspilerPatch(List<CodeInstruction> codeInstructions, List<OpCode> correctOpCodes)
        {
            this.codeInstructions = codeInstructions;
            this.correctOpCodes = correctOpCodes;
        }

        private void ThrowIfMissingProperties()
        {
            if (codeInstructions is null)
                throw new NullReferenceException("{Stats Core} Cannot use BaseTranspilerPatch. " +
                    "codeInstructions property is null");

            if (correctOpCodes is null)
                throw new NullReferenceException("{Stats Core} Cannot use BaseTranspilerPatch. " +
                    "correctOpCodes property is null");
        }

        public bool IsCurrentInstructionGood(int index)
        {
            ThrowIfMissingProperties();
            if (index < 0) return false;

            bool isInstructionGood = true;
            for (int i = 0; i < correctOpCodes.Count; i++)
            {
                var currentInstruction = codeInstructions[index + i];
                bool isOpcodeCorrect = (currentInstruction.opcode.Equals(correctOpCodes[i]));
                if (isOpcodeCorrect)
                    continue;

                isInstructionGood = false;
                break;
            }

            return isInstructionGood;
        }

        public CodeInstruction CreateNewCodeInstruction<T>(string methodName)
        {
            var methodInfo = typeof(T).GetMethod(methodName);
            var newInstruction = new CodeInstruction(OpCodes.Call, methodInfo);
            return newInstruction;
        }
    }
}
