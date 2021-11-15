using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCore.Stats
{
	internal static class SeaglideData
    {
		public static float ForwardMaxSpeed { get; set; }
		public static float BackwardsMaxSpeed { get; set; }
		public static float StrafeMaxSpeed { get; set; }
		public static float Acceleration { get; set; }
	}
}
