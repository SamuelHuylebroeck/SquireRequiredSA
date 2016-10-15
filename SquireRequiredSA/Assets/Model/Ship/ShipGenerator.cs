using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship
{
    public class ShipGenerator:ShipComponent
    {
        public int PowerProvided { get; private set; }
        public int PowerRegenRate { get; private set; }

        public ShipGenerator(int maxHull, int powerProvided, int powerRegenRate):base(maxHull, ComponentType.GENERATOR)
        {
            this.PowerProvided = powerProvided;
            this.PowerRegenRate = powerRegenRate;
        }

        public ShipGenerator(ShipGenerator toCopy) : base(toCopy)
        {
            this.PowerProvided = toCopy.PowerProvided;
            this.PowerRegenRate = toCopy.PowerRegenRate;
        }
    }
}
