using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Model.Ship;

namespace Assets.Controller.Factories
{
    public interface IShipFactory
    {
        ShipCore CreateShip();
        ShipCore CreateShip(List<ShipComponent> components);
    }
}
