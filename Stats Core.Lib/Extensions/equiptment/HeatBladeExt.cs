namespace Stats_Core.Extensions
{
    public static class HeatBladeExt
    {
        public static void SetUsesPerHit(this HeatBlade heatBlade, int amount) => Stats.equiptment.HeatBlade.UsesPerHit = amount;
    }
}
