using System.Collections.Generic;

namespace StatsCore.Stats
{
	public static class DamageTypeResistance
    {
		/// <summary>
		/// Resistances to each damage type. Value is treated as a percentage between 0 and 100% resistance.
		/// </summary>
		public static Dictionary<DamageType, float> allResistances = new Dictionary<DamageType, float>()
		{
			{DamageType.Acid, 0f },
			{DamageType.Cold, 0f },
			{DamageType.Collide, 0f },
			{DamageType.Drill, 0f },
			{DamageType.Electrical, 0f },
			{DamageType.Explosive, 0f },
			{DamageType.Fire, 0f },
			{DamageType.Heat, 0f },
			{DamageType.LaserCutter, 0f },
			{DamageType.Normal, 0f },
			{DamageType.Poison, 0f },
			{DamageType.Pressure, 0f },
			{DamageType.Puncture, 0f },
			{DamageType.Radiation, 0f },
			{DamageType.Smoke, 0f },
			{DamageType.Starve, 0f },
			{DamageType.Undefined, 0f },
		};
	}
}
