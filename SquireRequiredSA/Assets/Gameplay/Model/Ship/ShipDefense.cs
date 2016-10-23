using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship
{
    public class ShipDefense:ShipComponent
    {

        public ShipDefense(int maxHull) : base(maxHull, ComponentType.DEFENSE)
        {

        }

        public ShipDefense(ShipDefense toCopy) : base(toCopy)
        {

        }
    }
}
