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

        public float speed;
        public Animator animator;
        public Material material;

        public void ChangeMaterial()
        {
            if(material == null)
            {
                Debug.LogError("No material specifeid");
            }

            Renderer[] arrMaterials = this.gameObject.GetComponentsInChildren<Renderer>();

            foreach (Renderer r in arrMaterials)
            {
                if(r.gameObject != this.gameObject)
                {
                    r.material = material;
                }
            }
        }
    }
}

