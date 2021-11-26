using UnityEngine;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="FlashLight"/>.
    /// </summary>
    public static class FlashlightExt
    {
        /// <summary>
        /// Returns the current light color of the flashlight.
        /// </summary>
        /// <param name="flashLight"></param>
        /// <returns></returns>
        public static Color GetFlashlightColor(this FlashLight flashLight) => flashLight.lightColor;

        /// <summary>
        /// Sets the current light color of the flashlight.
        /// </summary>
        /// <param name="flashLight"></param>
        /// <param name="newColor">Color to set light to.</param>
        public static void SetFlashlightColor(this FlashLight flashLight, Color newColor) => flashLight.lightColor = newColor;
    }
}