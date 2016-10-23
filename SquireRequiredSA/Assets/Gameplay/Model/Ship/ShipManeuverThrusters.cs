using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship
{
    public class ShipManeuverThrusters:ShipComponent
    {
        public float MaxAngularSpeed { get; private set; }
        public float TurningAcceleration { get; private set; }
        public int AccelerationEnergyReserved { get; private set; }
        public int AccelerationHeatGenerated { get; private set; }

		public ShipManeuverThrusters(int maxHull, float maxASpeed, float aAccel, int accelEnergy, int accelHeat):base(maxHull,ComponentType.MANEUVERTHRUSTER)
        {
            this.MaxAngularSpeed = maxASpeed;
            this.TurningAcceleration = aAccel;
            this.AccelerationEnergyReserved = accelEnergy;
            this.AccelerationHeatGenerated = accelHeat;
        }

        public ShipManeuverThrusters(ShipManeuverThrusters toCopy) : base(toCopy)
        {
            this.MaxAngularSpeed = toCopy.MaxAngularSpeed;
            this.TurningAcceleration = toCopy.TurningAcceleration;
            this.AccelerationEnergyReserved = toCopy.AccelerationEnergyReserved;
            this.AccelerationHeatGenerated = AccelerationHeatGenerated;

        }

    }
}
