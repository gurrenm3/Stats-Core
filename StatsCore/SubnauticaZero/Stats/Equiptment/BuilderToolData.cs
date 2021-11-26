namespace StatsCore.Stats
{
    /// <summary>
    /// Contains extra methods/variables for manipulating <see cref="BuilderTool"/>. 
    /// Needed because some values are hard coded in Subnautica and therefore new variables/methods are needed.
    /// </summary>
    public static partial class BuilderToolData
    {
        /// <summary>
        /// A placeholder variable for manually adjusting the maximum deconstruction distance for the builder tool.
        /// </summary>
        public static float DeconstructionRange { get; set; } = 11f;
    }
}
