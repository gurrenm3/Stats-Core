using StatsCore.Stats;
using System.Collections.Generic;
using static Player;

namespace StatsCore.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Player"/>.
    /// </summary>
    public static class PlayerExt
    {
        /// <summary>
        /// (Cross-Game compatible) Returns the <see cref="Survival"/> component attached to the Player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static Survival GetSurvival(this Player player) => player.GetComponent<Survival>();

        /// <summary>
        /// (Cross-Game compatible) Returns the active PlayerMotor. It's a simplification of player.playerController.activeController.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static PlayerMotor GetActivePlayerMotor(this Player player) => player.playerController.activeController;

        /// <summary>
        /// (Cross-Game compatible) Returns the current MotorMode for the player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static MotorMode GetMotorMode(this Player player) => player.motorMode;


        /// <summary>
        /// (Cross-Game compatible) Returns whether or not the player is currently swimming on the surface of the ocean. 
        /// Will return false if the player is submerged underwater.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsSwimmingOnWaterSurface(this Player player)
        {
            bool isPlayerDiving = (player.GetMotorMode() == MotorMode.Dive);
            bool isPlayerInWater = player.IsUnderwaterForSwimming();
            return (isPlayerInWater && !isPlayerDiving);
        }

        /// <summary>
        /// (Cross-Game compatible) Returns whether or not the player is currently swimming underwater in the ocean. 
        /// Will return false if the player is swimming on the surface of the ocean.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsSwimmingUnderwater(this Player player)
        {
            bool isPlayerDiving = (player.GetMotorMode() == MotorMode.Dive);
            bool isPlayerInWater = player.IsUnderwaterForSwimming();
            return (isPlayerInWater && isPlayerDiving);
        }

        /// <summary>
        /// (Cross-Game compatible) Returns whether or not the player is currently swimming in the ocean.
        /// Will return true if they are swimming on the surface of the ocean or submerged underater.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsSwimmingInOcean(this Player player) => player.IsSwimmingOnWaterSurface() || player.IsSwimmingUnderwater();



        /// <summary>
        /// (Cross-Game compatible) Returns all of the player's current damage resistances.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static Dictionary<DamageType, float> GetAllDamageResistances(this Player player) => DamageTypeResistance.allResistances;

        /// <summary>
        /// (Cross-Game compatible) Returns the player's current resistance towards a specific type of damage.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="damageType">Resistance to get.</param>
        /// <returns></returns>
        public static float GetDamageResistance(this Player player, DamageType damageType) => DamageTypeResistance.allResistances[damageType];

        /// <summary>
        /// (Cross-Game compatible) Raises the player's current resistance towards a specific type of damage.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="damageType">Resistance to modify.</param>
        /// <param name="amount">Amount to raise resistance by.</param>
        public static void RaiseDamageResistance(this Player player, DamageType damageType, float amount) => DamageTypeResistance.allResistances[damageType] += amount;

        /// <summary>
        /// (Cross-Game compatible) Reduces the player's current resistance towards a specific type of damage.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="damageType">Resistance to modify.</param>
        /// <param name="amount">Amount to reduce resistance by.</param>
        public static void ReducetDamageResistance(this Player player, DamageType damageType, float amount) => DamageTypeResistance.allResistances[damageType] -= amount;


#if Subnautica
        public static Oxygen GetLungs(this Player player) => player.oxygenMgr.GetAllSources()[0];
#elif BelowZero
        public static Oxygen GetLungs(this Player player) => player.oxygenMgr.GetAllSources()[0];
#endif


        /// <summary>
        /// (Cross-Game compatible) Returns the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static float GetSuffocationTime(this Player player) => player.suffocationTime;

        /// <summary>
        /// (Cross-Game compatible) Raises the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseSuffocationTime(this Player player, float amount) => player.suffocationTime += amount;

        /// <summary>
        /// (Cross-Game compatible) Reduces the amount of time it takes for the player to suffocate to death after completely running out of Oxygen.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceSuffocationTime(this Player player, float amount) => player.suffocationTime -= amount;


        /// <summary>
        /// (Cross-Game compatible) Returns the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static float GetSuffocationRecoveryTime(this Player player) => player.suffocationRecoveryTime;

        /// <summary>
        /// (Cross-Game compatible) Raises the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="amount">Amount to raise by.</param>
        public static void RaiseSuffocationRecoveryTime(this Player player, float amount) => player.suffocationRecoveryTime += amount;

        /// <summary>
        /// (Cross-Game compatible) Reduces the amount of time it takes for the player to recover after suffocating for any amount of time.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="amount">Amount to reduce by.</param>
        public static void ReduceSuffocationRecoveryTime(this Player player, float amount) => player.suffocationRecoveryTime -= amount;


        /// <summary>
        /// Returns whether or not the player is currently suffocating.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsSuffocating(this Player player) => player.GetOxygenAvailable() <= 0;


        /// <summary>
        /// Returns the Player's inventory. Equivelant to Inventory.Get();
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static Inventory GetInventory(this Player player) => Inventory.Get();


        /// <summary>
        /// Returns the currently held tool in the Player's hand
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static PlayerTool GetHeldTool(this Player player) => player.GetInventory().GetHeldTool();
    }
}