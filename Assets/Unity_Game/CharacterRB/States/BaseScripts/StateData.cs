using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project
{
    public abstract class StateData : ScriptableObject
    {
        public float duration;

        public abstract void UpdateAbility(CharacterState characterState, Animator animator);
    }

}