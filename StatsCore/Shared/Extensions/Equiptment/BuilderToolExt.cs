using UnityEngine;
using static StatsCore.Stats.BuilderToolData;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="BuilderTool"/>.
    /// </summary>
    public static partial class BuilderToolExt
    {
        /// <summary>
        /// Returns the <see cref="BuilderTool.barMaterial"/>.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <returns></returns>
        public static Material GetBarMaterial(this BuilderTool builderTool) => builderTool.barMaterial;

        /// <summary>
        /// Set the <see cref="BuilderTool.barMaterial"/>.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <param name="material">Material to set it to.</param>
        public static void SetBarMaterial(this BuilderTool builderTool, Material material) => builderTool.barMaterial = material;

        /// <summary>
        /// Gets the Constructable currently being built.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <returns></returns>
        public static Constructable GetConstructable(this BuilderTool builderTool) => builderTool.constructable;

        /// <summary>
        /// Returns the maximum build distance.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <returns></returns>
        public static float GetRange(this BuilderTool builderTool) => HitRange;

        /// <summary>
        /// Raises the maximum build distance.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <param name="amount">Amount to raise max build distance by.</param>
        public static void RaiseRange(this BuilderTool builderTool, float amount) => HitRange += amount;

        /// <summary>
        /// Reduces the maximum build distance.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <param name="amount">Amount to reduce max build distance by.</param>
        public static void ReduceRange(this BuilderTool builderTool, float amount) => HitRange -= amount;
    }
}
