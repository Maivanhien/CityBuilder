using UnityEngine;

namespace Resource {
    public class ResourceHolder : MonoBehaviour {
        [SerializeField]
        protected ResourceName resourceName;
        [SerializeField]
        protected float resourceCurrent = 0f;
        [SerializeField]
        protected float resourceMax = float.MaxValue;
    }
}
