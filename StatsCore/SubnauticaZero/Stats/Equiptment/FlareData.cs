namespace StatsCore.Stats
{
    /// <summary>
    /// Contains extra methods/variables for manipulating <see cref="Flare"/>. 
    /// Needed because some values are hard coded in Subnautica and therefore new variables/methods are needed.
    /// </summary>
    public static class FlareData
    {
        /// <summary>
        /// A placeholder variable for manually adjusting the fliker interval of a Flare. 
        /// <br/>This is needed because the original <see cref="Flare.flickerInterval"/> is a constant and therefore unchangable.
        /// </summary>
        public static float FlickerInterval { get; set; } = 0.25f;
    }
}
