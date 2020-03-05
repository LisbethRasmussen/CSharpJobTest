using UnityEngine;

namespace com.brainplus.jobtest.monobehaviour.scenario1
{
    [RequireComponent(typeof(Inventory))]
    public class Player : MonoBehaviour
    {
        /// <summary>
        /// You are not allowed to change this property.
        /// </summary>
        public Inventory Inventory { get; private set; }

        void Awake() //<-- changed that to awake. Also, for next time, please, camelsBack.
        {
            CacheComponentReferences();
        }

        /// <summary>
        /// You are not allowed to change this function.
        /// </summary>
        void CacheComponentReferences()
        {
            Inventory = GetComponent<Inventory>();
        }
    }
}
