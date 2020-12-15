using System.Reflection;
using HarmonyLib;
using Stats_Core.Events;
using QModManager.API.ModLoading;

namespace Stats_Core
{
    [QModCore]
    public static class QModPatcher
    {
        [QModPatch]
        public static void Patch()
        {
            var assembly = Assembly.GetExecutingAssembly();
            new Harmony($"GurrenM4_{assembly.GetName().Name}").PatchAll(assembly);

            TempMod temp = new TempMod();
            Player_Events.PlayerUpdated += temp.PlayerUpdated;
        }
    }
}