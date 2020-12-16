using Stats_Core.Events;
using Stats_Core.Extensions;
using Stats_Core.Stats.player;
using static Stats_Core.Stats.equiptment.BuilderTool;

namespace Stats_Core
{
    internal class TempMod
    {
        public void PlayerUpdated(object sender, Player_Events.PlayerEventArgs e)
        {
            HitRange = 30000;
        }

        private static float? defaultSpeed;
        private void SetMovementSpeed()
        {
            if (!defaultSpeed.HasValue)
                defaultSpeed = Movement.Acceleration;

            var multiplier = 6;
            var newSpeed = defaultSpeed.Value * multiplier;

            Movement.MovementSpeed = newSpeed;
            Movement.ForwardMaxSpeed = newSpeed;
            Movement.BackwardsMaxSpeed = newSpeed;
            Movement.StrafeMaxSpeed = newSpeed;
            Movement.Acceleration = newSpeed;
        }
    }
}
