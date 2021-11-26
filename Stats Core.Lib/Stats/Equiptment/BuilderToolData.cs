namespace StatsCore.Stats
{
    /// <summary>
    /// Contains extra methods/variables for manipulating <see cref="BuilderTool"/>. 
    /// Needed because some values are hard coded in Subnautica and therefore new variables/methods are needed.
    /// </summary>
    public static class BuilderToolData
    {
        /// <summary>
        /// A placeholder variable for manually adjusting the maximum build distance for the builder tool.
        /// </summary>
        public static float HitRange { get; set; } = 30f;
    }
}
