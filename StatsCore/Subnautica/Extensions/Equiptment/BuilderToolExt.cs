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
        /// Returns the value of <see cref="BuilderTool.deconstructText"/>.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <returns></returns>
        public static string GetDeconstructionText(this BuilderTool builderTool) => builderTool.deconstructText;

        /// <summary>
        /// Sets the value of <see cref="BuilderTool.deconstructText"/>.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <param name="text">Value to set <see cref="BuilderTool.deconstructText"/> to.</param>
        public static void SetDeconstructionText(this BuilderTool builderTool, string text) => builderTool.deconstructText = text;

        /// <summary>
        /// Returns the value of <see cref="BuilderTool.constructText"/>.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <returns></returns>
        public static string GetConstructionText(this BuilderTool builderTool) => builderTool.constructText;


        /// <summary>
        /// Sets the value of <see cref="BuilderTool.constructText"/>.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <param name="text">Value to set <see cref="BuilderTool.constructText"/> to.</param>
        public static void SetConstructionText(this BuilderTool builderTool, string text) => builderTool.constructText = text;

        /// <summary>
        /// Get the value of <see cref="BuilderTool.noPowerText"/>. 
        /// </summary>
        /// <param name="builderTool"></param>
        /// <returns></returns>
        public static string GetNoPowerText(this BuilderTool builderTool) => builderTool.noPowerText;

        /// <summary>
        /// Sets the value of <see cref="BuilderTool.noPowerText"/>.
        /// </summary>
        /// <param name="builderTool"></param>
        /// <param name="text">Value to set <see cref="BuilderTool.noPowerText"/></param>
        public static void SetNoPowerText(this BuilderTool builderTool, string text) => builderTool.noPowerText = text;
    }
}
