namespace Stats_Core.Extensions
{
    public static class FlareExt
    {
        public static bool IsThrowing(this Flare flare) => flare.isThrowing;


        public static float GetFlickerInterval(this Flare flare) => flare.flickerInterval;
        public static void AddFlickerInterval(this Flare flare, float amount) => flare.flickerInterval += amount;
        public static void SubtractFlickerInterval(this Flare flare, float amount) => flare.flickerInterval -= amount;


        public static float GetThrowDuration(this Flare flare) => flare.throwDuration;
        public static void AddThrowDuration(this Flare flare, float amount) => flare.throwDuration += amount;
        public static void SubtractThrowDuration(this Flare flare, float amount) => flare.throwDuration -= amount;


        public static float GetOriginalLightIntensity(this Flare flare) => flare.originalIntensity;
        public static void AddOriginalLightIntensity(this Flare flare, float amount) => flare.originalIntensity += amount;
        public static void SubtractOriginalLightIntensity(this Flare flare, float amount) => flare.originalIntensity -= amount;


        public static float GetOriginalLightRange(this Flare flare) => flare.originalrange;
        public static void AddOriginalLightRange(this Flare flare, float amount) => flare.originalrange += amount;
        public static void SubtractOriginalLightRange(this Flare flare, float amount) => flare.originalrange -= amount;
    }
}
