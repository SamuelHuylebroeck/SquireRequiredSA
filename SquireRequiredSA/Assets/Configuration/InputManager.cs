using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Configuration
{
    public class InputManager : MonoBehaviour
    {
        Dictionary<String, KeyCode> buttonKeys;

        private InputManager() {

        }

        void OnEnable() {
            buttonKeys = new Dictionary<string, KeyCode>();

            //TODO: read from preference file
            buttonKeys["Forward"] = KeyCode.UpArrow;
            buttonKeys["Backwards"] = KeyCode.DownArrow;
            buttonKeys["Left"] = KeyCode.LeftArrow;
            buttonKeys["Right"] = KeyCode.RightArrow;
            buttonKeys["Stop"] = KeyCode.Space;
        }
        //Initialise
        void Start()
        {

        }

        void Update()
        {

        }

        public bool GetButtonDown(string buttonName)
        {
            if(buttonKeys.ContainsKey(buttonName) == false)
            {
                Debug.Log("Inputmanager::GetButtonDown - button not mapped: " + buttonName);
                return false;
            }
            return (Input.GetKeyDown(buttonKeys[buttonName]));
        }

        public bool GetButtonUp(string buttonName)
        {
            if (buttonKeys.ContainsKey(buttonName) == false)
            {
                Debug.Log("Inputmanager::GetButtonUp button not mapped: " + buttonName);
                return false;
            }
            return (Input.GetKeyUp(buttonKeys[buttonName]));
        }
    }


}
