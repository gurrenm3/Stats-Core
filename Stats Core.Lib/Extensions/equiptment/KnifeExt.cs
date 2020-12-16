using static Stats_Core.Stats.equiptment.Knife;

namespace Stats_Core.Extensions
{
    public static class KnifeExt
    {
        public static void AddUsesPerHit(this Knife knife, int amount) => UsesPerHit += amount;
        public static void SubtractUsesPerHit(this Knife knife, int amount) => UsesPerHit -= amount;


        public static int GetBaseResourceOnDamage(this Knife knife) => BaseResourceOnDamage;
        public static void AddBaseResourceOnDamage(this Knife knife, int amount) => BaseResourceOnDamage += amount;
        public static void SubtractBaseResourceOnDamage(this Knife knife, int amount) => BaseResourceOnDamage -= amount;


        public static bool GetSpawnResourceIfCantAdd(this Knife knife) => SpawnResourceIfCantAdd;
        public static void SetSpawnResourceIfCantAdd(this Knife knife, bool spawnIfCantAdd) => SpawnResourceIfCantAdd = spawnIfCantAdd;
    }
}