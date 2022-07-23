using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project
{
    public class CharacterState : StateMachineBehaviour
    {
        public List<StateData> listAbilityData = new List<StateData>();

        public void UpdateAll(CharacterState characterState, Animator animator)
        {
            foreach(StateData data in listAbilityData)
            {
                data.UpdateAbility(characterState, animator);
            }
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) {
            UpdateAll(this, animator);
        }

        private CharacterControl characterControl;
        public CharacterControl GetCharacterControl(Animator animator)
        {
            if(characterControl == null)
            {
                characterControl = animator.GetComponentInParent<CharacterControl>(); 
            }
            return characterControl;
        }
    }
}

