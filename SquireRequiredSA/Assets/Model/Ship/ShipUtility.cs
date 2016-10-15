using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model.Ship
{
    public class ShipUtility:ShipComponent
    {
        public ShipUtility(int maxHull) : base(maxHull,ComponentType.UTILITY)
        {

        }

        public ShipUtility(ShipDefense toCopy) : base(toCopy)
        {

        }
    }
}
