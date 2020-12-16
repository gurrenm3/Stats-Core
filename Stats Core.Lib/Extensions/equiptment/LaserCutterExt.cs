using UnityEngine;
using static Stats_Core.Stats.equiptment.LaserCutter;

namespace Stats_Core.Extensions
{
    public static class LaserCutterExt
    {
        public static bool IsFxPlaying(this LaserCutter laserCutter) => laserCutter.fxIsPlaying;


        public static float GetHealthPerWeld(this LaserCutter laserCutter) => laserCutter.healthPerWeld;
        public static void AddHealthPerWeld(this LaserCutter laserCutter, float amount) => laserCutter.healthPerWeld += amount;
        public static void SubtractHealthPerWeld(this LaserCutter laserCutter, float amount) => laserCutter.healthPerWeld -= amount;


        public static Sealed GetActiveCuttingTarget(this LaserCutter laserCutter) => laserCutter.activeCuttingTarget;
        public static void SetActiveCuttingTarget(this LaserCutter laserCutter, Sealed newTarget) => laserCutter.activeCuttingTarget = newTarget;


        public static float GetLightIntensity(this LaserCutter laserCutter) => laserCutter.lightIntensity;
        public static void AddLightIntensity(this LaserCutter laserCutter, float amount) => laserCutter.lightIntensity += amount;
        public static void SubtractLightIntensity(this LaserCutter laserCutter, float amount) => laserCutter.lightIntensity -= amount;


        public static Color GetLightbarColor(this LaserCutter laserCutter) => laserCutter.lightbarColor;
        public static void SetLightbarColor(this LaserCutter laserCutter, Color newColor) => laserCutter.lightbarColor = newColor;


        public static float GetMaxRandomIntensity(this LaserCutter laserCutter) => MaxRandomIntensity;
        public static void AddMaxRandomIntensity(this LaserCutter laserCutter, float amount) => MaxRandomIntensity += amount;
        public static void SubtractMaxRandomIntensity(this LaserCutter laserCutter, float amount) => MaxRandomIntensity -= amount;


        public static float GetMinRandomIntensity(this LaserCutter laserCutter) => MinRandomIntensity;
        public static void AddMinRandomIntensity(this LaserCutter laserCutter, float amount) => MinRandomIntensity += amount;
        public static void SubtractMinRandomIntensity(this LaserCutter laserCutter, float amount) => MinRandomIntensity -= amount;
    }
}
