namespace StatsCore.Extensions
{
    public static class SeaglideExt
    {
        public static float GetPropSpeed(this Seaglide seaglide) => seaglide.propSpeed;
        public static void AddPropSpeed(this Seaglide seaglide, float amount) => seaglide.propSpeed += amount;
        public static void SubtractPropSpeed(this Seaglide seaglide, float amount) => seaglide.propSpeed -= amount;


        public static float GetSpinUpSpeed(this Seaglide seaglide) => seaglide.spinUpSpeed;
        public static void AddSpinUpSpeed(this Seaglide seaglide, float amount) => seaglide.spinUpSpeed += amount;
        public static void SubtractSpinUpSpeed(this Seaglide seaglide, float amount) => seaglide.spinUpSpeed -= amount;


        public static float GetSpinDownSpeed(this Seaglide seaglide) => seaglide.spinDownSpeed;
        public static void AddSpinDownSpeed(this Seaglide seaglide, float amount) => seaglide.spinDownSpeed += amount;
        public static void SubtractSpinDownSpeed(this Seaglide seaglide, float amount) => seaglide.spinDownSpeed -= amount;


        public static float GetMaxSpinSpeed(this Seaglide seaglide) => seaglide.maxSpinSpeed;
        public static void AddMaxSpinSpeed(this Seaglide seaglide, float amount) => seaglide.maxSpinSpeed += amount;
        public static void SubtractMaxSpinSpeed(this Seaglide seaglide, float amount) => seaglide.maxSpinSpeed -= amount;
    }
}
