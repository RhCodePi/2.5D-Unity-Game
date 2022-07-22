using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace project
{
    [CustomEditor(typeof(CharacterControl))]
    public class ChangeMaterial : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            CharacterControl control = (CharacterControl)target;

            if(GUILayout.Button("Change Materail"))
            {
                control.ChangeMaterial();
            }
        }
    }

}

