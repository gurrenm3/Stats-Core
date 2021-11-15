using QModManager.API.ModLoading;
using System.Reflection;
using HarmonyLib;

namespace StatsCore.Patches
{
    [QModCore]
    public static class QModPatcher
    {
        [QModPatch]
        public static void Patch()
        {
            var assembly = Assembly.GetExecutingAssembly();
            new Harmony($"GurrenM4_{assembly.GetName().Name}").PatchAll(assembly);

        }
    }
}