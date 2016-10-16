using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace Assets.Model.Ship{
    public class ShipCore {

        public List<ShipComponent> Components { get; private set; }
        public int MaxHull { get; private set; }
        public int CurrentHull { get; set; }
        public int MaxHeat { get; private set; }
        public int CurrentHeat { get; set; }
        public int MaxPower { get; private set; }
        public int CurrentPower { get; private set; }
        public int MaxAmmo { get; private set; }
        public int CurrentAmmo { get; private set; }

        public int MaxSpeed { get; private set; }
        public int CurrentSpeed { get; private set; }

        public int MaxTurningSpeed { get; private set; }
        public int CurrentTurningSpeed { get; private set; }

        public ShipCore(int maxHull,int maxPower, int maxHeat, int maxAmmo, int maxSpeed, int maxTurningSpeed, List<ShipComponent> components)
        {

            this.MaxHull = maxHull;
            this.CurrentHull = maxHull;
            this.MaxHeat = maxHeat;
            this.CurrentHeat = 0;
            this.MaxPower = maxPower;
            this.CurrentPower = maxPower;
            this.MaxAmmo = maxAmmo;
            this.CurrentAmmo = maxAmmo;
            this.MaxSpeed = maxSpeed;
            this.CurrentSpeed = 0;
            this.MaxTurningSpeed = maxTurningSpeed;
            this.MaxTurningSpeed = 0;
            this.Components = components;
        }

        public ShipCore(ShipCore toCopy):this(toCopy.MaxHull,toCopy.MaxPower, toCopy.MaxHeat, toCopy.MaxAmmo,  toCopy.MaxSpeed, toCopy.MaxTurningSpeed,toCopy.Components)
        {
           
        }

        public override string ToString()
        {
            string shipAsString = string.Format("Ship, MHu:{0}, MP:{1}, MHe:{2}, MA:{3}, MS: {4}, MAS: {5}\n", MaxHull, MaxPower, MaxHeat,MaxAmmo,MaxSpeed,MaxTurningSpeed);
            shipAsString += "Componenents:\n";
            foreach(ShipComponent comp in this.Components)
            {
                shipAsString += comp + "\n";
            }
            return shipAsString;
        }

    }
}
