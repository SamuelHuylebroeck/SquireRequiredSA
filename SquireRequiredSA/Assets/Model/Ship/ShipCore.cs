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

        public int MaxSpeed { get; private set; }
        public int CurrentSpeed { get; private set; }

        public int MaxTurningSpeed { get; private set; }
        public int CurrentTurningSpeed { get; private set; }

        public ShipCore(List<ShipComponent> components)
        {

            this.Components = components;
            InitializeStats();
        }

        public ShipCore(ShipCore toCopy):this(toCopy.Components)
        {
           
        }

        private bool initialized = false;

        private void InitializeStats()
        {
            UpdateStats();
            initialized = true;
        }

        private void UpdateStats()
        {
            this.MaxHull = 0;
            this.MaxPower = 0;
            this.MaxHeat = 0;
            this.MaxSpeed = 0;
            this.MaxTurningSpeed = 0;
            foreach (ShipComponent comp in Components){
                //Hull update
                MaxHull += comp.MaxHull;
                //Other stats update
                AddStats(comp);
                
            }
        }

        private void AddStats(ShipComponent comp)
        {
            switch (comp.type)
            {
                default:
                    break;
            }
        }

    }
}
