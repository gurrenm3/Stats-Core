using Stats_Core.Events;
using Stats_Core.Extensions;
using Stats_Core.Stats.player;

namespace Stats_Core
{
    internal class TempMod
    {
        Survival survival;
        int count;
        public void PlayerUpdated(object sender, Player_Events.PlayerEventArgs e)
        {
            //SetMovementSpeed();
            /*SetMovementSpeed();
            survival = Player.main.GetSurvival();


            var mode = Player.main.GetMotorMode();

            const int maxCount = 20;
            if (count >= maxCount)
            {
                ErrorMessage.AddMessage(mode.ToString());
                count = 0;
            }
            count++;

            Player.main.SetDamageResistance(DamageType.Radiation, 100);*/



            /*SetStartingFood(100f);
            SetStartingWater(100f);*/


            //SetWaterOverfillAmount(200f);

            /*SetFoodWaterHealThreshold(1f);
            SetBaseRegenRate(1f);*/

            /*var hunger = 10;
            var newSize = hunger + 5;
            SetStomachSize(newSize);
            SetStomachOverfillSize(newSize*2);
            SetMaxWater(1000f);
            if (!hungerSet)
            {
                SetHunger(hunger);
                hungerSet = true;
            }*/

            //SetWater(1f);

            //SetAcidResistance(100f);

            //SetMaxHealth(1000);
            //SetHealth(1000f);
            //SetHealthRegenAmount(10f);
            //SetHealthRegenDelay(1f);

            //SetMaxAir(1);
            //SetOxygenPerBreath(8);
            //SetSuffocationTime(1f);
            //SetBreathPeriod(0.1f);



            //PlayerStats.Water = 1000f;
            //PlayerStats.UpdateHungerInterval = 1000f;
            //PlayerStats.Stomach = 40f;
            //PlayerStats.Food = 200f

        }

        private void SetWaterOverfillAmount(float amount)
        {
            survival.SetWaterOverfillSize(amount);
        }

        private void SetBaseRegenRate(float amount)
        {
            survival.SetBaseRegenRate(amount);
        }

        private void SetFoodWaterHealThreshold(float amount)
        {
            survival.SetFoodWaterHealThreshold(amount);
        }

        private void SetStomachOverfillSize(float amount)
        {
            survival.SetStomachOverfillSize(amount);
        }

        private void SetStartingWater(float amount)
        {
            survival.SetStartingWater(amount);
        }

        private void SetStartingFood(float amount)
        {
            survival.SetStartingFood(amount);
        }

        private void SetStomachSize(float amount)
        {
            survival.SetStomachSize(amount);
        }

        private void SetMaxWater(float amount)
        {
            survival.SetWaterCapacity(amount);
        }

        private void SetHunger(float amount)
        {
            survival.food = amount;
        }

        private void SetWater(float amount)
        {
            survival.water = amount;
        }

        private void SetAcidResistance(float amount)
        {
            DamageTypeResistance.allResistances[DamageType.Acid] = amount;
        }

        private void SetHealthRegenDelay(float amount)
        {
            Health.HealthRegenDelay = amount;
        }

        private void SetHealthRegenAmount(float amount)
        {
            Health.HealthRegenAmount = amount;
        }

        private void SetHealth(float amount)
        {
            Player.main.liveMixin.health = amount;
        }

        private void SetMaxHealth(float amount)
        {
            Health.MaxHealth = amount;
        }


        private void SetSuffocationTime(float amount)
        {
            Air.SuffocationTime = amount;
        }

        private void SetOxygenPerBreath(float amount)
        {
            Air.OxygenPerBreath = amount;
        }

        private void SetMaxAir(float value)
        {
            var lungs = Player.main.oxygenMgr.GetAllOxygenSources()[0];
            lungs.oxygenCapacity = value;
        }

        private void SetSuffocationRecoveryTime(float time)
        {
            Air.SuffocationRecoveryTime = time;
        }

        private void SetBreathPeriod(float amount)
        {
            Air.BreathPeriod = amount;
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
