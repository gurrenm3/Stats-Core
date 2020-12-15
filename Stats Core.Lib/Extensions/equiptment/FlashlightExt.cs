using UnityEngine;

namespace Stats_Core.Extensions
{
    public static class FlashlightExt
    {
        public static Color GetFlashlightColor(this FlashLight flashLight) => flashLight.lightColor;
        public static void SetFlashlightColor(this FlashLight flashLight, Color newColor) => flashLight.lightColor = newColor;
    }
}