namespace Stats_Core.Extensions
{
    public static class FlareExt
    {
        public static bool IsThrowing(this Flare flare) => flare.isThrowing;


        public static float GetFlickerInterval(this Flare flare) => flare.flickerInterval;
        public static void SetFlickerInterval(this Flare flare, float newInterval) => flare.flickerInterval = newInterval;


        public static float GetThrowDuration(this Flare flare) => flare.throwDuration;
        public static void SetThrowDuration(this Flare flare, float newDuration ) => flare.throwDuration = newDuration;


        public static float GetOriginalLightIntensity(this Flare flare) => flare.originalIntensity;
        public static float SetOriginalLightIntensity(this Flare flare, float newIntensity) => flare.originalIntensity = newIntensity;


        public static float GetOriginalLightRange(this Flare flare) => flare.originalrange;
        public static float SetOriginalLightRange(this Flare flare, float newRange) => flare.originalrange = newRange;
    }
}
