namespace StatsCore.Extensions
{
    public static class PlayerToolExt
    {
        /// <summary>
        /// Returns the <see cref="EnergyMixin"/> attached to this tool.
        /// </summary>
        /// <param name="playerTool"></param>
        /// <returns></returns>
        public static EnergyMixin GetEnergyMixin(this PlayerTool playerTool) => playerTool.energyMixin;

        /// <summary>
        /// Returns the <see cref="Player"/> that is using the tool.
        /// </summary>
        /// <param name="playerTool"></param>
        /// <returns></returns>
        public static Player GetOwningPlayer(this PlayerTool playerTool) => playerTool.usingPlayer;
    }
}
