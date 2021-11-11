using System;
using UnityEngine;

namespace Project
{
    public class Creator : SingletonImplenentator
    {
        private static Creator _instance;

        [SerializeField] private GameObject _laserPrefab;
        
        public static GameObject LaserPrefab => _instance._laserPrefab;

        public override void InitializeInstance()
        {
            _instance = this;
        }

        public static T Create<T>(GameObject prefab, Vector3 position) =>
            Create<T>(prefab, position, Quaternion.identity);

        public static T Create<T>(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            return Instantiate(prefab, position, rotation).GetComponent<T>();
        }
    }
}