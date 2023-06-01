using System;
using UnityEngine;

namespace Prototype {
    public class SingletonBehaviour<T> : MonoBehaviour where T:Component {
        private static T instance;
        public static T Instance {
            get {
                if (instance == null) {
                    instance = FindObjectOfType<T>();
                    if (instance == null) {
                        GameObject gameObject = new GameObject(typeof(T).Name);
                        instance = gameObject.AddComponent<T>();
                    }
                }
                return instance;
            }
        }

        void Awake () {
            if (instance == null) {
                instance = this as T;
            } else {
                if (instance != this) {
                    Destroy(gameObject);
                }
            }
        }
    }
}
