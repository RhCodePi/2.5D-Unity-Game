using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project
{
    public enum TransitionParameter
    {
        move,
    }
    public class CharacterControl : MonoBehaviour
    {

        [SerializeField] private float speed;
        [SerializeField] private Animator animator;
        void Update()
        {
            if (VirtualInputManager.Instance.MoveLeft && VirtualInputManager.Instance.MoveRight)
            {
                animator.SetBool(TransitionParameter.move.ToString(), false);
                return;
            }
            if (!VirtualInputManager.Instance.MoveLeft && !VirtualInputManager.Instance.MoveRight)
            {
                animator.SetBool(TransitionParameter.move.ToString(), false);
                return;
            }
            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 180f, 0);
                animator.SetBool(TransitionParameter.move.ToString(), true);
            }

            if (VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                animator.SetBool(TransitionParameter.move.ToString(), true);
            }
        }
    }
}

