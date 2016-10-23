using System;
using UnityEngine;
using Assets.Controller.ShipControllers;
using Assets.Configuration;

namespace Assets.Controller.PlayerControllers
{
	public class SandboxPlayerController:MonoBehaviour
	{
		public BasicShipController testShip{ get; set; }
        private InputManager inputManager;
        public float reportInterval = 5000f;
        private float timeAfterReport = 0f;

		public SandboxPlayerController ()
		{
            inputManager = GameObject.FindObjectOfType<InputManager>();
		}
        //
		void Start(){
		}

        //
		void Update(){
            if (inputManager.GetButtonDown("Forward"))
            {
                testShip.Accelerate(1);
            }
            if (inputManager.GetButtonDown("Backward"))
            {
                testShip.Accelerate(-1);
            }
            if (inputManager.GetButtonDown("Left"))
            {
                testShip.AccelerateTurn(1);
            }
            if (inputManager.GetButtonDown("Right"))
            {
                testShip.AccelerateTurn(-1);
            }
            if (inputManager.GetButtonDown("Stop"))
            {
                testShip.KillSpeed();
            }
            if(timeAfterReport > reportInterval)
            {
                testShip.DumpSpeedInfo();
                timeAfterReport = 0f;
            }
            timeAfterReport += Time.deltaTime;
		}

	}
}

