using System;

namespace Stats_Core.Events
{
	/// <summary>
	/// This class is used for testing purposes and not apart of the official API
	/// </summary>
	internal class Player_Events
    {
		public static event EventHandler<PlayerEventArgs> PlayerUpdated;
		public static event EventHandler<PlayerEventArgs> DamageTaken;

		public class PlayerEventArgs : EventArgs
		{
			public Player Player = Player.main;
			public DamageInfo damageInfo = null;
		}

		public void OnPlayerUpdated(PlayerEventArgs e)
		{
			EventHandler<PlayerEventArgs> handler = PlayerUpdated;
			if (handler != null)
				handler(this, e);
		}

		public void OnDamageTaken(PlayerEventArgs e)
		{
			EventHandler<PlayerEventArgs> handler = DamageTaken;
			if (handler != null)
				handler(this, e);
		}
	}
}
