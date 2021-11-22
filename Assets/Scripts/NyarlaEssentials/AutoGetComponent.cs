using UnityEngine;

namespace NyarlaEssentials
{
    public class AutoGetComponent<T> where T : MonoBehaviour
    {
        private GameObject _owner;

        private T _v;
        public T V => _v ?? (_v = _owner.GetComponent<T>());
        
        public AutoGetComponent(GameObject owner)
        {
            _owner = owner;
        }
    }
}