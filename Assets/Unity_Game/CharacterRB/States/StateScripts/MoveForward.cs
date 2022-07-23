using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace project
{
    [CreateAssetMenu(fileName = "New State", menuName = "Game/AbilityData/MoveForward")]
    public class MoveForward : StateData
    {
        public float speed; 
        public override void UpdateAbility(CharacterState characterState, Animator animator)
        {
            CharacterControl character = characterState.GetCharacterControl(animator);

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
                character.transform.Translate(Vector3.forward * speed* Time.deltaTime);
                character.transform.rotation = Quaternion.Euler(0, 180f, 0);
            }

            if (VirtualInputManager.Instance.MoveRight)
            {
                character.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                character.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
}

