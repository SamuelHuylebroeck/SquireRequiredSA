using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Model.Ship;
using UnityEngine;
using Assets.Configuration;

namespace Assets.Gameplay.Controller.ShipControllers
{
    public class BasicShipController : MonoBehaviour
    {
        public ShipCore ship { get; private set; }
        public GameObject ship_go { get; private set; }
        public SpriteRenderer ship_sr { get; private set; }
        private bool initiliazed = false;

        public void SetSprite(Sprite sprite)
        {
            ship_sr.sprite = sprite;
        }

        // Use this for initialization
        void Start()
        {
            KillAccel();
            KillSpeed();
        }

        // Update is called once per frame
        void Update()
        {
            if (initiliazed)
            {
                //accelerate/deaccelerate
                UpdateSpeeds();
                //Do movement
                DoMovement();
            }
        }

        public void Init(ShipCore ship)
        {
            this.ship = ship;
            //Create gameObject
            ship_go = new GameObject();
            ship_go.name = "Test_Ship";
            //Add sprite
            ship_sr = ship_go.AddComponent<SpriteRenderer>();
            initiliazed = true;
            Debug.Log("Init called");

        }

        private void UpdateSpeeds()
        {
            //Turning speed
            float nexTurningSpeed = ship.CurrentTurningSpeed;
            //Debug.Log(nexTurningSpeed);
            //Debug.Log(Time.deltaTime);
            //Debug.Log(ship.CurrentTurningAcceleration);
            nexTurningSpeed += (ship.CurrentTurningAcceleration * 100 * Time.deltaTime) / 100;

            //Clamp to min and max
            nexTurningSpeed = Math.Min(Math.Max(-1 * ship.MaxTurningSpeed, nexTurningSpeed), ship.MaxTurningSpeed);

            ship.CurrentTurningSpeed = nexTurningSpeed;

            //Forward Speed
            float nextSpeed = ship.CurrentSpeed + (ship.CurrentAcceleration * 100 * Time.deltaTime) / 100;
            //Debug.Log(nextSpeed);
            //Clamp to min and max
            nextSpeed = Math.Min(Math.Max(-1 * ship.MaxSpeed, nextSpeed), ship.MaxSpeed);
            ship.CurrentSpeed = nextSpeed;
        }

        private void DoMovement()
        {
            Transform tf = ship_go.transform;
            //Turn
            Quaternion rot = ship_go.transform.rotation;
            float z = rot.eulerAngles.z;
            z += SpeedController.GetTurnSpeed(ship.CurrentTurningAcceleration) * Time.deltaTime;
            rot = Quaternion.Euler(0, 0, z);
            ship_go.transform.rotation = rot;
            //Move straight ahead
            Vector3 pos = tf.position;
            Vector3 veloctiy = new Vector3(SpeedController.GetSpeed(ship.CurrentSpeed) * Time.deltaTime, 0,0);
            pos += rot * veloctiy;
            ship_go.transform.position = pos;
        }

        public void Accelerate(int acceleration)
        {
            //Calculate next acceleration value
            float nextAccel = ship.CurrentAcceleration + acceleration;
            //Clamp to min and max
            nextAccel = Math.Min(Math.Max(ship.MaxAcceleration * -1, nextAccel), ship.MaxAcceleration);
            ship.CurrentAcceleration = nextAccel;
        }

        public void AccelerateTurn(int acceleration)
        {
            float nextAccel = ship.CurrentTurningAcceleration + acceleration;
            //Clamp to min and max
            nextAccel = Math.Min(Math.Max(ship.MaxTurningAcceleration * -1, nextAccel), ship.MaxTurningAcceleration);
            ship.CurrentTurningAcceleration = nextAccel;
        }

        public void KillSpeed()
        {
            Debug.Log("Speed was killed");
            ship.CurrentSpeed = 0;
            ship.CurrentAcceleration = 0;
            ship.CurrentTurningSpeed = 0;
            ship.CurrentTurningAcceleration = 0;
        }

        public void KillAccel()
        {
            Debug.Log("Acceleration was killed");
            ship.CurrentTurningAcceleration = 0;
            ship.CurrentAcceleration = 0;
        }

        public void DumpSpeedInfo()
        {
            Debug.Log(String.Format("Speed: {0}, Accel: {1}, RotationSpd: {2}, RotationAccel: {3}, init: {4}", ship.CurrentSpeed, ship.CurrentAcceleration, ship.CurrentTurningSpeed, ship.CurrentTurningAcceleration, initiliazed));

        }


    }
}
