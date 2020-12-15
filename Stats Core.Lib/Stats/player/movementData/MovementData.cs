/*using Stats_Core.Stats.player.movementData;
using static Player;

namespace Stats_Core.Stats.player
{
    internal class MovementData
    {
        public MotorMode DefaultMotorMode { get; private set; }
        public MovementType MovementType { get; set; }
        public VehicleType Vehicle { get; set; } = VehicleType.None;
        public StructureType InsideStructure { get; set; } = StructureType.None;
        public EnvironmentType Environment { get; set; } = EnvironmentType.Water;


        public MovementData()
        {
            SetMotorMode();
        }
        
        private void SetMotorMode()
        {
            switch (Vehicle)
            {
                case VehicleType.None:
                    DefaultMotorMode = MotorMode.Run;
                    break;
                case VehicleType.Seaglide:
                    DefaultMotorMode = MotorMode.Seaglide;
                    break;
                case VehicleType.Seamoth:
                    DefaultMotorMode = MotorMode.Vehicle;
                    break;
                case VehicleType.Cyclops:
                    DefaultMotorMode = MotorMode.Vehicle;
                    break;
                case VehicleType.Exosuit:
                    DefaultMotorMode = MotorMode.Mech;
                    break;
                case VehicleType.Neptune_Rocket:
                    break;
                case VehicleType.Vehicle_Bay:
                    DefaultMotorMode = MotorMode.Run;
                    break;
                case VehicleType.In_Creature_Mouth:
                    DefaultMotorMode = MotorMode.Dive;
                    break;
                case VehicleType.Aurora:
                    DefaultMotorMode = MotorMode.Walk;
                    break;
                default:
                    break;
            }
        }

        public MovementType GetPlayerMovementType()
        {

        }

        public VehicleType GetPlayerVehicleType()
        {

        }

        public StructureType GetPlayerStructureType()
        {

        }

        public EnvironmentType GetPlayerEnvironment()
        {

        }
    }
}
*/