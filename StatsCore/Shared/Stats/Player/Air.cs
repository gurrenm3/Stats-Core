namespace StatsCore.Stats
{
	public static class AirData
    {
		public const float default_SuffocationRecoverTime = 4f;
		public const float default_SuffocationTime = 8f;
		public const float default_O2UnitsPerSecondSurface = 30f;



		internal static float? newBreathPeriod;// = 99999f;
		public static float BreathPeriod
		{
			get { return Player.main.GetBreathPeriod(); }
			set { newBreathPeriod = value; }
		}

		internal static float? newOxygenPerBreath;// = 99999f;
		public static float OxygenPerBreath
		{
			get { return Player.main.GetOxygenPerBreath(BreathPeriod, (int)Player.main.GetDepthClass()); }
			set { newOxygenPerBreath = value; }
		}
	}
}
