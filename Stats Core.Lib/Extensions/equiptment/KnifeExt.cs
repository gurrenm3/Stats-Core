namespace Stats_Core.Extensions
{
    public static class KnifeExt
    {
        public static void SetUsesPerHit(this Knife knife, int amount) => Stats.equiptment.Knife.UsesPerHit = amount;


        public static int GetBaseResourceOnDamage(this Knife knife) => Stats.equiptment.Knife.BaseResourceOnDamage;
        public static void SetBaseResourceOnDamage(this Knife knife, int amount) => Stats.equiptment.Knife.BaseResourceOnDamage = amount;


        public static bool GetSpawnResourceIfCantAdd(this Knife knife) => Stats.equiptment.Knife.SpawnResourceIfCantAdd;
        public static void SetSpawnResourceIfCantAdd(this Knife knife, bool spawnIfCantAdd) => Stats.equiptment.Knife.SpawnResourceIfCantAdd = spawnIfCantAdd;
    }
}