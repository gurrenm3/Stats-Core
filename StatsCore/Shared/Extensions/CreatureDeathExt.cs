namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="CreatureDeath"/>.
    /// </summary>
    public static class CreatureDeathExt
    {
        /// <summary>
        /// (Cross-Game compatible) Returns a new string containing just the creatures actual name. Removes all extra characters from it
        /// </summary>
        /// <param name="__instance">CreatureDeath __instance</param>
        /// <returns>Cleaned creature name</returns>
        public static string GetName(CreatureDeath __instance)
        {
            return __instance.gameObject.name.Split('(')[0];
        }
    }
}
