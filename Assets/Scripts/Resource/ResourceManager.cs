using Prototype;
using System.Collections.Generic;
using UnityEngine;

namespace Resource {
    public class ResourceManager : SingletonBehaviour<ResourceManager> {
        [SerializeField]
        List<Resource> resources;

        public void AddResource (ResourceName resourceName, int number) {
            Resource resource = resources.Find(x => x.ResourceName == resourceName);
            if (resource == null) {
                resources.Add(new Resource(resourceName, number));
            } else {
                resource.Number += number;
            }
        }
    }
}
