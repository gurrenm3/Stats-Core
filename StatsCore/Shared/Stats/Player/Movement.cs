namespace StatsCore.Stats
{
    public static partial class MovementData
    {
        public static float MovementSpeed
		{
			get { return Player.main.movementSpeed; }
			set { Player.main.movementSpeed = value; }
		}

		public static float ForwardMaxSpeed
		{
			get { return Player.main.playerController.activeController.forwardMaxSpeed; }
			set { Player.main.playerController.activeController.forwardMaxSpeed = value; }
		}

		public static float BackwardsMaxSpeed
		{
			get { return Player.main.playerController.activeController.backwardMaxSpeed; }
			set { Player.main.playerController.activeController.backwardMaxSpeed = value; }
		}

		public static float StrafeMaxSpeed
		{
			get { return Player.main.playerController.activeController.strafeMaxSpeed; }
			set { Player.main.playerController.activeController.strafeMaxSpeed = value; }
		}
	}
}
