using UnityEngine;
using System.Collections;
using Assets.Controller.ShipControllers;
using Assets.Controller.Factories;
using Assets.Controller.PlayerControllers;


namespace Assets.Controller.SceneControllers
{
    public class SandBoxController : MonoBehaviour
    {

        public SandboxPlayerController pc { get; set; }
        public BasicShipController testShip { get; private set; }
        public Sprite shipSprite;

        // Use this for initialization
        void Start()
        {
            initBasicShip();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void initBasicShip()
        {
            BasicShipFactory fac = new BasicShipFactory();
            this.testShip = new BasicShipController(fac.CreateShip());
            Debug.Log("Created: \n" + testShip.ship);
            Debug.Log("Adding sprite");
            testShip.SetSprite(shipSprite);
            if(pc != null)
            {
                pc.testShip = testShip;
            }

        }
    }

}
