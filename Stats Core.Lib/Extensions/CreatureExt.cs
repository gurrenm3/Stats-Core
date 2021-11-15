namespace Stats_Core.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Creature"/>.
    /// </summary>
    public static class CreatureExt
    {
        /// <summary>
        /// Returns a new string containing just the creatures actual name. Removes all extra characters from it
        /// </summary>
        /// <param name="__instance">Creature __instance</param>
        /// <returns>Cleaned creature name</returns>
        public static string GetName(Creature __instance)
        {
            return __instance.gameObject.name.Split('(')[0];
        }
    }
}
