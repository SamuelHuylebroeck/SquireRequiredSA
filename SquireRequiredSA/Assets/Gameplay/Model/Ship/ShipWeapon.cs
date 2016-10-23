using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship

{
    public class ShipWeapon:ShipComponent
    {
        public int HeatGeneratedPerShot { get; private set; }
        public int PowerConsumedPerShot { get; private set; }
        public int AmmoConsumedPerShot { get; private set; }

        public ShipWeapon(int maxHull) : base(maxHull,ComponentType.WEAPON)
        {

        }

        public ShipWeapon(ShipDefense toCopy) : base(toCopy)
        {

        }
    }
}
