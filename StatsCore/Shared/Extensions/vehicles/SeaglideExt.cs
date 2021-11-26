namespace StatsCore.Extensions
{
    public static class SeaglideExt
    {
        public static float GetPropSpeed(this Seaglide seaglide) => seaglide.propSpeed;
        public static void RaisePropSpeed(this Seaglide seaglide, float amount) => seaglide.propSpeed += amount;
        public static void ReducePropSpeed(this Seaglide seaglide, float amount) => seaglide.propSpeed -= amount;


        public static float GetSpinUpSpeed(this Seaglide seaglide) => seaglide.spinUpSpeed;
        public static void RaiseSpinUpSpeed(this Seaglide seaglide, float amount) => seaglide.spinUpSpeed += amount;
        public static void ReduceSpinUpSpeed(this Seaglide seaglide, float amount) => seaglide.spinUpSpeed -= amount;


        public static float GetSpinDownSpeed(this Seaglide seaglide) => seaglide.spinDownSpeed;
        public static void RaiseSpinDownSpeed(this Seaglide seaglide, float amount) => seaglide.spinDownSpeed += amount;
        public static void ReduceSpinDownSpeed(this Seaglide seaglide, float amount) => seaglide.spinDownSpeed -= amount;


        public static float GetMaxSpinSpeed(this Seaglide seaglide) => seaglide.maxSpinSpeed;
        public static void RaiseMaxSpinSpeed(this Seaglide seaglide, float amount) => seaglide.maxSpinSpeed += amount;
        public static void ReduceMaxSpinSpeed(this Seaglide seaglide, float amount) => seaglide.maxSpinSpeed -= amount;
    }
}
