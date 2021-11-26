using UnityEngine;
using static StatsCore.Stats.LaserCutterData;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="LaserCutter"/>.
    /// </summary>
    public static class LaserCutterExt
    {
        /// <summary>
        /// Returns whether or not Laser Cutter Effects are playing.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <returns></returns>
        public static bool IsFxPlaying(this LaserCutter laserCutter) => laserCutter.fxIsPlaying;

        /// <summary>
        /// Returns the amount of health removed per weld.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <returns></returns>
        public static float GetHealthPerWeld(this LaserCutter laserCutter) => laserCutter.healthPerWeld;

        /// <summary>
        /// Raises the amount of health removed per weld.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseHealthPerWeld(this LaserCutter laserCutter, float amount) => laserCutter.healthPerWeld += amount;

        /// <summary>
        /// Reduces the amount of health removed per weld.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceHealthPerWeld(this LaserCutter laserCutter, float amount) => laserCutter.healthPerWeld -= amount;


        /// <summary>
        /// Gets the current cutting target.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <returns></returns>
        public static Sealed GetActiveCuttingTarget(this LaserCutter laserCutter) => laserCutter.activeCuttingTarget;

        /// <summary>
        /// Sets the current cutting target.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="newTarget"></param>
        public static void SetActiveCuttingTarget(this LaserCutter laserCutter, Sealed newTarget) => laserCutter.activeCuttingTarget = newTarget;


        /// <summary>
        /// Gets the light intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <returns></returns>
        public static float GetLightIntensity(this LaserCutter laserCutter) => laserCutter.lightIntensity;

        /// <summary>
        /// Raises the light intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseLightIntensity(this LaserCutter laserCutter, float amount) => laserCutter.lightIntensity += amount;

        /// <summary>
        /// Reduces the light intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceLightIntensity(this LaserCutter laserCutter, float amount) => laserCutter.lightIntensity -= amount;


        /// <summary>
        /// Returns the light bar color.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <returns></returns>
        public static Color GetLightbarColor(this LaserCutter laserCutter) => laserCutter.lightbarColor;

        /// <summary>
        /// Sets the light bar color.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="newColor"></param>
        public static void SetLightbarColor(this LaserCutter laserCutter, Color newColor) => laserCutter.lightbarColor = newColor;


        /// <summary>
        /// Returns the max random intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <returns></returns>
        public static float GetMaxRandomIntensity(this LaserCutter laserCutter) => MaxRandomIntensity;

        /// <summary>
        /// Raises the max random intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseMaxRandomIntensity(this LaserCutter laserCutter, float amount) => MaxRandomIntensity += amount;

        /// <summary>
        /// Reduces the max random intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceMaxRandomIntensity(this LaserCutter laserCutter, float amount) => MaxRandomIntensity -= amount;

        /// <summary>
        /// Returns the minimum random intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <returns></returns>
        public static float GetMinRandomIntensity(this LaserCutter laserCutter) => MinRandomIntensity;

        /// <summary>
        /// Raises the minimum random intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseMinRandomIntensity(this LaserCutter laserCutter, float amount) => MinRandomIntensity += amount;

        /// <summary>
        /// Reduces the minimum random intensity.
        /// </summary>
        /// <param name="laserCutter"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceMinRandomIntensity(this LaserCutter laserCutter, float amount) => MinRandomIntensity -= amount;
    }
}
