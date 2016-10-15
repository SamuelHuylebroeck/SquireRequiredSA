﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship
{
    public class ShipMainThruster:ShipComponent
    {
        public int MaxSpeed { get; private set; }
        public int Acceleration { get; private set; }
        public int AccelerationEnergyReserved { get; private set; }
        public int AccelerationHeatGenerated { get; private set; }

        public ShipMainThruster(int maxHull, int maxSpeed, int accel, int accelEnergy, int accelHeat):base(maxHull,ComponentType.MAINTHRUSTER)
        {
            this.MaxSpeed = maxSpeed;
            this.Acceleration = accel;
            this.AccelerationEnergyReserved = accelEnergy;
            this.AccelerationHeatGenerated = accelHeat;
        }

        public ShipMainThruster(ShipMainThruster toCopy) : base(toCopy)
        {
            this.MaxSpeed = toCopy.MaxSpeed;
            this.Acceleration = toCopy.Acceleration;
            this.AccelerationEnergyReserved = toCopy.AccelerationEnergyReserved;
            this.AccelerationHeatGenerated = AccelerationHeatGenerated;

        }
    }
}
