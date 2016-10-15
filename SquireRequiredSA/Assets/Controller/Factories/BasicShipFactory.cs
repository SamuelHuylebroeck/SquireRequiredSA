using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Model.Ship;

namespace Assets.Controller.Factories
{
    public class BasicShipFactory : IShipFactory
    {
        public ShipCore CreateShip()
        {
            List<ShipComponent> components = new List<ShipComponent>();
            //Generator
            ShipGenerator gen = new ShipGenerator(10, 10, 1);
            components.Add(gen);
            //Heatsink
            //Main Thruster
            //Maneuver Thruster
            throw new NotImplementedException();
        }

        public ShipCore CreateShip(List<ShipComponent> components)
        {
            throw new NotImplementedException();
        }
    }
}
