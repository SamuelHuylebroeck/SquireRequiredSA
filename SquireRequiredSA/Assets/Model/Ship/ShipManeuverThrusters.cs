﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship
{
    public class ShipManeuverThrusters:ShipComponent
    {
        public int MaxAngularSpeed { get; private set; }
        public int AngularAcceleration { get; private set; }
        public int AccelerationEnergyReserved { get; private set; }
        public int AccelerationHeatGenerated { get; private set; }

        public ShipManeuverThrusters(int maxHull, int maxASpeed, int aAccel, int accelEnergy, int accelHeat):base(maxHull,ComponentType.MANEUVERTHRUSTER)
        {
            this.MaxAngularSpeed = maxASpeed;
            this.AngularAcceleration = aAccel;
            this.AccelerationEnergyReserved = accelEnergy;
            this.AccelerationHeatGenerated = accelHeat;
        }

        public ShipManeuverThrusters(ShipManeuverThrusters toCopy) : base(toCopy)
        {
            this.MaxAngularSpeed = toCopy.MaxAngularSpeed;
            this.AngularAcceleration = toCopy.AngularAcceleration;
            this.AccelerationEnergyReserved = toCopy.AccelerationEnergyReserved;
            this.AccelerationHeatGenerated = AccelerationHeatGenerated;

        }

    }
}
