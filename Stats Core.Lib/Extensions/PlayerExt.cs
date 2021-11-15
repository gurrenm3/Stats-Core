using StatsCore.Stats.player;
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
        /// Returns the <see cref="Survival"/> component attached to the Player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static Survival GetSurvival(this Player player) => player.GetComponent<Survival>();

        /// <summary>
        /// Returns the active PlayerMotor. It's a simplification of player.playerController.activeController.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static PlayerMotor GetActivePlayerMotor(this Player player) => player.playerController.activeController;

        /// <summary>
        /// Returns the current MotorMode for the player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static MotorMode GetMotorMode(this Player player) => player.motorMode;


        /// <summary>
        /// Returns whether or not the player is currently swimming on the surface of the ocean. 
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
        /// Returns whether or not the player is currently swimming underwater in the ocean. 
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
        /// Returns whether or not the player is currently swimming in the ocean.
        /// Will return true if they are swimming on the surface of the ocean or submerged underater.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsSwimmingInOcean(this Player player) => player.IsSwimmingOnWaterSurface() || player.IsSwimmingUnderwater();



        /// <summary>
        /// Returns all of the player's current damage resistances.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static Dictionary<DamageType, float> GetAllDamageResistances(this Player player) => DamageTypeResistance.allResistances;
        
        /// <summary>
        /// Returns the player's current resistance towards a specific type of damage.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="damageType">Resistance to get.</param>
        /// <returns></returns>
        public static float GetDamageResistance(this Player player, DamageType damageType) => DamageTypeResistance.allResistances[damageType];

        /// <summary>
        /// Raises the player's current resistance towards a specific type of damage.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="damageType">Resistance to modify.</param>
        /// <param name="amount">Amount to raise resistance by.</param>
        public static void RaiseDamageResistance(this Player player, DamageType damageType, float amount) => DamageTypeResistance.allResistances[damageType] += amount;

        /// <summary>
        /// Reduces the player's current resistance towards a specific type of damage.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="damageType">Resistance to modify.</param>
        /// <param name="amount">Amount to reduce resistance by.</param>
        public static void ReducetDamageResistance(this Player player, DamageType damageType, float amount) => DamageTypeResistance.allResistances[damageType] -= amount;
    }
}