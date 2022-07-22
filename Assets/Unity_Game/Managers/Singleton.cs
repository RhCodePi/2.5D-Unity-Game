using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace project
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T _instance;

        public static T Instance {
            get {
                _instance = (T)FindObjectOfType(typeof(T));
                if(_instance == null)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<T>();
                    obj.name = typeof(T).Name;
                }
                return _instance;
            }

        }
    }

}

