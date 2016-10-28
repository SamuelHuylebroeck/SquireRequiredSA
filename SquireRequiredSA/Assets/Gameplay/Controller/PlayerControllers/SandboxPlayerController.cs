using System;
using UnityEngine;
using Assets.Gameplay.Controller.ShipControllers;
using Assets.Configuration;

namespace Assets.Gameplay.Controller.PlayerControllers
{
    public class SandboxPlayerController : MonoBehaviour
    {
        public BasicShipController testShip { get; set; }
        private InputManager inputManager;
        public float reportInterval = 5000f;
        private float timeAfterReport = 0f;

        public SandboxPlayerController()
        {

        }
        //
        void Start()
        {
            inputManager = GameObject.FindObjectOfType<InputManager>();
        }

        //
        void Update()
        {
            if (inputManager.GetButtonDown("Forward"))
            {
                Debug.Log("Pressing Forward");
                testShip.Accelerate(1);
            }
            if (inputManager.GetButtonDown("Backward"))
            {
                Debug.Log("Pressing Backward");
                testShip.Accelerate(-1);
            }
            if (inputManager.GetButtonDown("Left"))
            {
                Debug.Log("Pressing Left");
                testShip.AccelerateTurn(1);
            }
            if (inputManager.GetButtonDown("Right"))
            {
                Debug.Log("Pressing Right");
                testShip.AccelerateTurn(-1);
            }
            if (inputManager.GetButtonDown("Stop"))
            {
                Debug.Log("Pressing Stop");
                testShip.KillSpeed();
            }
            if (inputManager.GetButtonDown("Dump")){
                testShip.DumpSpeedInfo();
            }
            if (timeAfterReport > reportInterval)
            {
                Debug.Log("Dumping info");
                timeAfterReport = 0f;
                testShip.DumpSpeedInfo();

            }
            timeAfterReport += Time.deltaTime;

            
        }
    }
}


