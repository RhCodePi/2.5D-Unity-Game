using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project
{
    [CreateAssetMenu(fileName = "New State", menuName = "Game/AbilityData/Idle")]
    public class Idle : StateData
    {
        public override void UpdateAbility(CharacterState characterState, Animator animator)
        {
            if (VirtualInputManager.Instance.MoveLeft)
            {
                animator.SetBool(TransitionParameter.move.ToString(), true);
            }

            if (VirtualInputManager.Instance.MoveRight)
            {
                animator.SetBool(TransitionParameter.move.ToString(), true);
            }
        }
    }
}

