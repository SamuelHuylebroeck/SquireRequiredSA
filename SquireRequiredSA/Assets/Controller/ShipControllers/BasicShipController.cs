using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Model.Ship;
using UnityEngine;

namespace Assets.Controller.ShipControllers
{
    public class BasicShipController:MonoBehaviour
    {
        public ShipCore ship { get; private set; }
        public GameObject ship_go { get; private set; }
        public SpriteRenderer ship_sr { get; private set; }

        public BasicShipController(ShipCore ship)
        {
            this.ship = ship;            
            //Create gameObject
            ship_go = new GameObject();
            ship_go.name = "Test_Ship";
            //Add sprite
            ship_sr = ship_go.AddComponent<SpriteRenderer>();
        }

        // Use this for initialization
        void Start()
        {

            
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetSprite(Sprite sprite)
        {
            ship_sr.sprite = sprite;
        }


    }
}
