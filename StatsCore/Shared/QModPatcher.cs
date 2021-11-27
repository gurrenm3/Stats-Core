using HarmonyLib;
using QModManager.API.ModLoading;
using System;
using System.Reflection;

namespace StatsCore
{
    [QModCore]
    public static class QModPatcher
    {
        public static string modsDir = $"{Environment.CurrentDirectory}\\QMods\\{Assembly.GetExecutingAssembly().GetName().Name}";
        public const string versionNumber = "2.0.0";

        [QModPatch]
        public static void Patch()
        {
            var assembly = Assembly.GetExecutingAssembly();
            new Harmony($"GurrenM4_{assembly.GetName().Name}").PatchAll(assembly);
        }
    }
}
