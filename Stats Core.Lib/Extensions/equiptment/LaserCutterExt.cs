using UnityEngine;

namespace Stats_Core.Extensions
{
    public static class LaserCutterExt
    {
        public static bool IsFxPlaying(this LaserCutter laserCutter) => laserCutter.fxIsPlaying;


        public static float GetHealthPerWeld(this LaserCutter laserCutter) => laserCutter.healthPerWeld;
        public static void SetHealthPerWeld(this LaserCutter laserCutter, float newHealthPerWeld) => laserCutter.healthPerWeld = newHealthPerWeld;


        public static Sealed GetActiveCuttingTarget(this LaserCutter laserCutter) => laserCutter.activeCuttingTarget;
        public static void SetActiveCuttingTarget(this LaserCutter laserCutter, Sealed newTarget) => laserCutter.activeCuttingTarget = newTarget;


        public static float GetLightIntensity(this LaserCutter laserCutter) => laserCutter.lightIntensity;
        public static void SetLightIntensity(this LaserCutter laserCutter, float newIntensity) => laserCutter.lightIntensity = newIntensity;


        public static Color GetLightbarColor(this LaserCutter laserCutter) => laserCutter.lightbarColor;
        public static void SetLightbarColor(this LaserCutter laserCutter, Color newColor) => laserCutter.lightbarColor = newColor;


        public static float GetMaxRandomIntensity(this LaserCutter laserCutter) => Stats.equiptment.LaserCutter.MaxRandomIntensity;
        public static void SetMaxRandomIntensity(this LaserCutter laserCutter, float newMaxIntensity) => Stats.equiptment.LaserCutter.MaxRandomIntensity = newMaxIntensity;


        public static float GetMinRandomIntensity(this LaserCutter laserCutter) => Stats.equiptment.LaserCutter.MinRandomIntensity;
        public static void SetMinRandomIntensity(this LaserCutter laserCutter, float newMinIntensity) => Stats.equiptment.LaserCutter.MinRandomIntensity = newMinIntensity;
    }
}
