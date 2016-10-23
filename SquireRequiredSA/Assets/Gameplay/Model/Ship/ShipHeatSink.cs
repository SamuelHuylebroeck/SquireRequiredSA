using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship
{
    class ShipHeatSink:ShipComponent
    {
        public int HeatCapacity { get; private set; }
        public int HeatCoolingRate { get; private set; }

        public ShipHeatSink(int maxHull, int heatCapacity, int heatCoolingRate) : base(maxHull,ComponentType.HEATSINK)
        {
            this.HeatCapacity = heatCapacity;
            this.HeatCoolingRate = HeatCoolingRate;
        }

        public ShipHeatSink(ShipHeatSink toCopy) : base(toCopy)
        {
            this.HeatCapacity = toCopy.HeatCapacity;
            this.HeatCoolingRate = toCopy.HeatCoolingRate;
        }
    }
}
