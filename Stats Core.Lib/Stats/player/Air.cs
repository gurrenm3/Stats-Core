namespace StatsCore.Stats.player
{
	public static class Air
    {
		public static readonly float default_SuffocationRecoverTime = 4f;
		public static readonly float default_SuffocationTime = 8f;
		public static readonly float default_O2UnitsPerSecondSurface = 30f;



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

		public static float SuffocationTime
		{
			get { return Player.main.suffocationTime; }
			set { Player.main.suffocationTime = value; }
		}

		public static float SuffocationRecoveryTime
		{
			get { return Player.main.suffocationRecoveryTime; }
			set { Player.main.suffocationRecoveryTime = value; }
		}

		public static float O2UnitsPerSecondSurface
		{
			get { return Player.main.oxygenMgr.oxygenUnitsPerSecondSurface; }
			set { Player.main.oxygenMgr.oxygenUnitsPerSecondSurface = value; }
		}
	}
}
