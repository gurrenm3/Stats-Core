using UnityEngine;
using static Stats_Core.Stats.equiptment.BuilderTool;

namespace Stats_Core.Extensions
{
    public static class BuilderToolExt
    {
        public static string GetDeconstructionText(this BuilderTool builderTool) => builderTool.deconstructText;
        public static void SetDeconstructionText(this BuilderTool builderTool, string text) => builderTool.deconstructText = text;

        public static string GetConstructionText(this BuilderTool builderTool) => builderTool.constructText;
        public static void SetConstructionText(this BuilderTool builderTool, string text) => builderTool.constructText = text;


        public static string GetNoPowerText(this BuilderTool builderTool) => builderTool.noPowerText;
        public static void SetNoPowerText(this BuilderTool builderTool, string text) => builderTool.noPowerText = text;


        public static Material GetBarMaterial(this BuilderTool builderTool) => builderTool.barMaterial;
        public static void SetBarMaterial(this BuilderTool builderTool, Material material) => builderTool.barMaterial = material;


        public static bool IsConstruction(this BuilderTool builderTool) => builderTool.isConstructing;

        public static Constructable GetConstructable(this BuilderTool builderTool) => builderTool.constructable;

        public static Vector3 GetLeftPointVector(this BuilderTool builderTool) => builderTool.leftPoint;
        public static void SetLeftPointVector(this BuilderTool builderTool, Vector3 vector3) => builderTool.leftPoint = vector3;


        public static Vector3 GetRightPointVector(this BuilderTool builderTool) => builderTool.rightPoint;
        public static void SetRightPointVector(this BuilderTool builderTool, Vector3 vector3) => builderTool.rightPoint = vector3;

        public static Vector3 GetLeftConstructionPoint(this BuilderTool builderTool) => builderTool.leftConstructionPoint;
        public static void SetLeftConstructionPoint(this BuilderTool builderTool, Vector3 vector3) => builderTool.leftConstructionPoint = vector3;


        public static Vector3 GetRightConstructionPoint(this BuilderTool builderTool) => builderTool.rightConstructionPoint;
        public static void SetRightConstructionPoint(this BuilderTool builderTool, Vector3 vector3) => builderTool.rightConstructionPoint = vector3;


        public static float GetHitRange(this BuilderTool builderTool) => HitRange;
        public static void AddtHitRange(this BuilderTool builderTool, float amount) => HitRange += amount;
        public static void SubtracttHitRange(this BuilderTool builderTool, float amount) => HitRange -= amount;


        public static float GetLeftConstructionTime(this BuilderTool builderTool) => builderTool.leftConstructionTime;
        public static void AddLeftConstructionTime(this BuilderTool builderTool, float amount) => builderTool.leftConstructionTime += amount;
        public static void SubtractLeftConstructionTime(this BuilderTool builderTool, float amount) => builderTool.leftConstructionTime -= amount;


        public static float GetRightConstructionTime(this BuilderTool builderTool) => builderTool.rightConstructionTime;
        public static void AddRightConstructionTime(this BuilderTool builderTool, float amount) => builderTool.rightConstructionTime += amount;
        public static void SubtractRightConstructionTime(this BuilderTool builderTool, float amount) => builderTool.rightConstructionTime -= amount;


        public static float GetLeftConstructionInterval(this BuilderTool builderTool) => builderTool.leftConstructionInterval;
        public static void AddLeftConstructionInterval(this BuilderTool builderTool, float amount) => builderTool.leftConstructionInterval += amount;
        public static void SubtractLeftConstructionInterval(this BuilderTool builderTool, float amount) => builderTool.leftConstructionInterval -= amount;


        public static float GetRightConstructionInterval(this BuilderTool builderTool) => builderTool.rightConstructionInterval;
        public static void AddRightConstructionInterval(this BuilderTool builderTool, float amount) => builderTool.rightConstructionInterval += amount;
        public static void SubtractRightConstructionInterval(this BuilderTool builderTool, float amount) => builderTool.rightConstructionInterval -= amount;
    }
}
