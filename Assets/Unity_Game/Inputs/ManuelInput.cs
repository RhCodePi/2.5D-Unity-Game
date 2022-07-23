using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project
{
    public class ManuelInput : MonoBehaviour
    {
        private CharacterControl characterControl;
        private void Awake() {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }
        void Update()
        {
            GetInputs();
        }

        void GetInputs()
        {
            if(VirtualInputManager.Instance.MoveRight)
            {
                characterControl.MoveRight = true;
            }
            else {
                characterControl.MoveRight = false;
            }

            if(VirtualInputManager.Instance.MoveLeft)
            {
                characterControl.MoveLeft = true;
            }
            else {
                characterControl.MoveLeft = false;
            }
        }
    }
}

