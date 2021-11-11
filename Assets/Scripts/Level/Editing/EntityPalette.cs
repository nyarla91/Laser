using System;
using System.Collections.Generic;
using UnityEngine;

namespace Level.Editing
{
    [CreateAssetMenu(menuName = "Entity Palette")]
    public class EntityPalette : ScriptableObject
    {
        [SerializeField] private List<NameEntityPair> _brushes;
        public List<NameEntityPair> Brushes => _brushes;
    }
    
    [Serializable]
    public class NameEntityPair
    {
        [SerializeField] private string _name;
        [SerializeField] private GameObject _entity;

        public string Name => _name;
        public GameObject Entity => _entity;

        public NameEntityPair(string name, GameObject entity)
        {
            _name = name;
            _entity = entity;
        }
    }
}
