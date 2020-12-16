using Stats_Core.Stats.player;
using System.Collections.Generic;
using static Player;

namespace Stats_Core.Extensions
{
    public static class PlayerExt
    {
        public static Survival GetSurvival(this Player player) => Player.main.GetComponent<Survival>();
        public static PlayerMotor GetActivePlayerMotor(this Player player) => player.playerController.activeController;

        public static Dictionary<DamageType, float> GetAllDamageTypeResistances(this Player player) => DamageTypeResistance.allResistances;
        public static float GetDamageResistance(this Player player, DamageType damageType) => DamageTypeResistance.allResistances[damageType];
        public static void AddDamageResistance(this Player player, DamageType damageType, float amount) => DamageTypeResistance.allResistances[damageType] += amount;
        public static void SubtractDamageResistance(this Player player, DamageType damageType, float amount) => DamageTypeResistance.allResistances[damageType] -= amount;



        public static MotorMode GetMotorMode(this Player player) => player.motorMode;

        public static bool IsSwimmingOnWaterSurface(this Player player)
        {
            bool isPlayerDiving = (player.motorMode == MotorMode.Dive);
            bool isPlayerInWater = player.IsUnderwaterForSwimming();
            return (isPlayerInWater && !isPlayerDiving);
        }

        public static bool IsSwimmingUnderwater(this Player player)
        {
            bool isPlayerDiving = (player.motorMode == MotorMode.Dive);
            bool isPlayerInWater = player.IsUnderwaterForSwimming();
            return (isPlayerInWater && isPlayerDiving);
        }

        public static bool IsSwimmingInOcean(this Player player) => player.IsSwimmingOnWaterSurface() || player.IsSwimmingUnderwater();
    }
}