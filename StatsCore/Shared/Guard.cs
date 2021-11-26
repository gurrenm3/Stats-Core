using UnityEngine;

namespace StatsCore
{
    public static class Guard
    {
        public static bool IsGamePaused() => Time.timeScale == 0;
    }
}
