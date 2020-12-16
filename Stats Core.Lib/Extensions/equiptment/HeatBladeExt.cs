namespace Stats_Core.Extensions
{
    public static class HeatBladeExt
    {
        public static void AddUsesPerHit(this HeatBlade heatBlade, int amount) => Stats.equiptment.HeatBlade.UsesPerHit += amount;
        public static void SubtractUsesPerHit(this HeatBlade heatBlade, int amount) => Stats.equiptment.HeatBlade.UsesPerHit -= amount;
    }
}
