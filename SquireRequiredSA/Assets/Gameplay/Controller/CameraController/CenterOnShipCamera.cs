using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Gameplay.Controller.PlayerControllers;
using UnityEngine;

namespace Assets.Gameplay.Controller.CameraController
{
    public class CenterOnShipCamera : MonoBehaviour
    {
        public SandboxPlayerController playerController;
        public GameObject camera_go;

        void Start()
        {

        }

        void Update()
        {
            //Retrieve ship position
            Transform ship_tf = playerController.testShip.transform;
            camera_go.transform.position = ship_tf.transform.position;
            camera_go.transform.rotation = ship_tf.transform.rotation;
        }
    }
}
