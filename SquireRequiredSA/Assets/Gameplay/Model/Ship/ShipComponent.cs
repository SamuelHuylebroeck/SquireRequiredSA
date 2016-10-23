using UnityEngine;
using System.Collections;

namespace Assets.Model.Ship
{
    public enum ComponentType : byte { BASE, AMMO, MAINTHRUSTER, GENERATOR, DEFENSE, WEAPON, UTILITY, HEATSINK, MANEUVERTHRUSTER };
    public class ShipComponent
    {

        public ComponentType type
        {
            get; private set;
        }
        public int MaxHull { get; private set; }
        public int CurrentHull { get; private set; }

        public ShipComponent(int maxHull, ComponentType type)
        {
            this.type = type;
            this.MaxHull = maxHull;
            this.CurrentHull = maxHull;
        }

        public ShipComponent(ShipComponent toCopy)
        {
            this.type = type;
            this.MaxHull = toCopy.MaxHull;
            this.CurrentHull = toCopy.CurrentHull;
        }

        public override string ToString()
        {
            return "Type: " + type;
        }

    }
}
