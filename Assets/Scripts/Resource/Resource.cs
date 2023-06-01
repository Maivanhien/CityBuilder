using System;
using UnityEngine;

namespace Resource {
    [Serializable]
    public class Resource {
        [SerializeField]
        ResourceName resourceName;
        [SerializeField]
        int number;

        public ResourceName ResourceName {
            get {
                return resourceName;
            }
        }

        public int Number {
            get {
                return number;
            }
            set {
                if (value >= 0) {
                    number = value;
                }
            }
        }

        public Resource (ResourceName resourceName, int number) {
            this.resourceName = resourceName;
            this.number = number;
        }
    }

    public enum ResourceName {
        NoResource,
        Gold,
        Diamond,
        LogWood,
        Stone,
        Water
    }
}
