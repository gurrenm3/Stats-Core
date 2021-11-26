namespace StatsCore.Stats
{
    public static partial class MovementData
    {
		public static float Acceleration
		{
			get { return Player.main.playerController.activeController.acceleration; }
			set { Player.main.playerController.activeController.acceleration = value; }
		}
	}
}
