using static Stats_Core.Stats.equiptment.AirBladder;

namespace Stats_Core.Extensions
{
    public static class AirBladderExt
    {
        public static bool IsDeflating(this AirBladder airBladder) => airBladder.deflating;
        public static bool IsInflating(this AirBladder airBladder) => airBladder.inflating;
        public static bool IsFirstUse(this AirBladder airBladder) => airBladder.firstUse;
        
        
        public static float GetOxygen(this AirBladder airBladder) => airBladder.oxygen;
        public static float AddOxygen(this AirBladder airBladder, float amount) => airBladder.oxygen += amount;
        public static float RemoveOxygen(this AirBladder airBladder, float amount) => airBladder.oxygen -= amount;


        public static float GetMaxOxygenConsumption(this AirBladder airBladder) => MaxOxygenConsumption;
        public static float AddMaxOxygenConsumption(this AirBladder airBladder, float amount) => MaxOxygenConsumption += amount;
        public static float SubtractMaxOxygenConsumption(this AirBladder airBladder, float amount) => MaxOxygenConsumption -= amount;


        public static float GetO2TransferPerSecond(this AirBladder airBladder) => O2TransferPerSecond;
        public static float AddO2TransferPerSecond(this AirBladder airBladder, float amount) => O2TransferPerSecond += amount;
        public static float SubtractO2TransferPerSecond(this AirBladder airBladder, float amount) => O2TransferPerSecond -= amount;


        public static float GetBuoyancyForce(this AirBladder airBladder) => airBladder.forceConstant;
        public static void AddBuoyancyForce(this AirBladder airBladder, float amount) => airBladder.forceConstant += amount;
        public static void SubtractBuoyancyForce(this AirBladder airBladder, float amount) => airBladder.forceConstant -= amount;
    }
}
