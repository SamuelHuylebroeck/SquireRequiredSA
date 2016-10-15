using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship
{
    public class ShipAmmoStore:ShipComponent
    {
        public int AmmoCapacity { get; private set; }

        public ShipAmmoStore(int maxHull, int ammoCapacity):base(maxHull, ComponentType.AMMO)
        {
            this.AmmoCapacity = ammoCapacity;
        }

        public ShipAmmoStore(ShipAmmoStore toCopy) : base(toCopy)
        {
            this.AmmoCapacity = toCopy.AmmoCapacity;
        }
    }
}
