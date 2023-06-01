using System;
using UnityEngine;

namespace Resource {
    public class ResourceGenerator : MonoBehaviour {
        [SerializeField]
        ResourceName resourceName;
        [SerializeField]
        int number = 1;
        [SerializeField]
        float interval = 2f;
        private float timer = 0f;

        void Update () {
            Generating();
        }

        void Generating () {
            if (resourceName == ResourceName.NoResource) {
                return;
            }
            timer += Time.deltaTime;
            if (timer < interval) {
                return;
            }
            timer = 0f;
            //Addition resource in list resources
            ResourceManager.Instance.AddResource(resourceName, number);
        }
    }
}
