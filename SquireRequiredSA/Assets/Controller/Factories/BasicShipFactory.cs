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
            ShipHeatSink sink = new ShipHeatSink(10, 20, 2);
            components.Add(sink);
            //Main Thruster
            ShipMainThruster thrust = new ShipMainThruster(10, 10, 1, 1, 1);
            components.Add(thrust);
            //Maneuver Thruster
            ShipManeuverThrusters mThrust = new ShipManeuverThrusters(10, 5, 1, 1, 1);
            components.Add(mThrust);
            //Build ship
            return Build(components);
        }

        public ShipCore CreateShip(List<ShipComponent> components)
        {
            throw new NotImplementedException();
        }

        private ShipCore Build(List<ShipComponent> components)
        {
            int maxHull = 0, maxPower = 0, maxHeat = 0, maxAmmo = 0, maxSpeed = 0, maxTurningSpeed = 0;

            foreach(ShipComponent comp in components)
            {
                //Hull
                maxHull += comp.MaxHull;
                //Other stats
                switch (comp.type)
                {
                    case ComponentType.GENERATOR:
                        maxPower += ((ShipGenerator)comp).PowerProvided;
                        break;
                    case ComponentType.HEATSINK:
                        maxHeat += ((ShipHeatSink)comp).HeatCapacity;
                        break;
                    case ComponentType.AMMO:
                        maxAmmo += ((ShipAmmoStore)comp).AmmoCapacity;
                        break;
                    case ComponentType.MAINTHRUSTER:
                        maxSpeed += ((ShipMainThruster)comp).MaxSpeed;
                        break;
                    case ComponentType.MANEUVERTHRUSTER:
                        maxTurningSpeed += ((ShipManeuverThrusters)comp).MaxAngularSpeed;
                        break;
                    default:
                        break;
                }
            }
            return new ShipCore(maxHull, maxPower, maxHeat, maxAmmo, maxSpeed, maxTurningSpeed, components);

        }
    }
}
