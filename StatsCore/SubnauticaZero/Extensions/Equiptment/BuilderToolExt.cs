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
        /// Returns the maximum deconstruction distance.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <returns></returns>
        public static float GetDeconstructionRange(this BuilderTool builderTool) => DeconstructionRange;

        /// <summary>
        /// Raises the maximum deconstruction distance.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <param name="amount">Amount to raise max deconstruction distance by.</param>
        public static void RaiseDeconstructionRange(this BuilderTool builderTool, float amount) => DeconstructionRange += amount;

        /// <summary>
        /// Reduces the maximum deconstruction distance.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <param name="amount">Amount to reduce max deconstruction distance by.</param>
        public static void ReduceDeconstructionRange(this BuilderTool builderTool, float amount) => DeconstructionRange -= amount;
    }
}
