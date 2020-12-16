using Stats_Core.Stats.player;
using System.Collections.Generic;

namespace Stats_Core.Extensions
{
    public static class OxygenMgrExt
    {
        /// <summary>
		/// Get all of the oxygen sources affecting the player. Player's lungs are the first source
		/// </summary>
        public static List<Oxygen> GetAllOxygenSources(this OxygenManager oxygenManager) => oxygenManager.sources;

        public static float GetO2UnitsPerSecondSurface(this OxygenManager oxygenManager) => oxygenManager.oxygenUnitsPerSecondSurface;
        public static void AddO2UnitsPerSecondSurface(this OxygenManager oxygenManager, float amount) => oxygenManager.oxygenUnitsPerSecondSurface += amount;
        public static void SubtractO2UnitsPerSecondSurface(this OxygenManager oxygenManager, float amount) => oxygenManager.oxygenUnitsPerSecondSurface -= amount;



        public static float GetBreathPeriod(this OxygenManager oxygenManager) => Air.BreathPeriod;
        public static void AddBreathPeriod(this OxygenManager oxygenManager, float amount) => Air.BreathPeriod += amount;
        public static void SubtractBreathPeriod(this OxygenManager oxygenManager, float amount) => Air.BreathPeriod -= amount;


        public static float GetOxygenPerBreath(this OxygenManager oxygenManager) => Air.OxygenPerBreath;
        public static void AddOxygenPerBreath(this OxygenManager oxygenManager, float amount) => Air.OxygenPerBreath += amount;
        public static void SubtractOxygenPerBreath(this OxygenManager oxygenManager, float amount) => Air.OxygenPerBreath -= amount;


        public static float GetSuffocationTime(this OxygenManager oxygenManager) => Air.SuffocationTime;
        public static void AddSuffocationTime(this OxygenManager oxygenManager, float amount) => Air.SuffocationTime += amount;
        public static void SubtractSuffocationTime(this OxygenManager oxygenManager, float amount) => Air.SuffocationTime -= amount;


        public static float GetSuffocationRecoveryTime(this OxygenManager oxygenManager) => Air.SuffocationRecoveryTime;
        public static void AddSuffocationRecoveryTime(this OxygenManager oxygenManager, float amount) => Air.SuffocationRecoveryTime += amount;
        public static void SubtractSuffocationRecoveryTime(this OxygenManager oxygenManager, float amount) => Air.SuffocationRecoveryTime -= amount;
    }
}