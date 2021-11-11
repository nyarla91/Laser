using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class Singleton : MonoBehaviour
    {
        [SerializeField] private List<SingletonImplenentator> _implementators;
        
        private void Awake()
        {
            foreach (var implenentator in _implementators)
            {
                implenentator.InitializeInstance();
            }
        }
    }
}
