using UnityEngine;
using System.Collections;
using Assets.Gameplay.Controller.ShipControllers;
using Assets.Controller.Factories;
using Assets.Gameplay.Controller.PlayerControllers;


namespace Assets.Gameplay.Controller.SceneControllers
{
    public class SandBoxController : MonoBehaviour
    {

        public SandboxPlayerController PC;
        public BasicShipController testShip;
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
            this.testShip = Instantiate(testShip);
            this.testShip.Init(fac.CreateShip());
            Debug.Log("Created: \n" + testShip.ship);
            Debug.Log("Adding sprite");
            testShip.SetSprite(shipSprite);
            Debug.Log("Linking to controller");
            if(PC != null)
            {
                Debug.Log("Assigning ship to controller");
                PC.testShip = testShip;
            }
            else
            {
                Debug.Log("Link failed");
                Debug.Log(PC);
            }

        }
    }

}
