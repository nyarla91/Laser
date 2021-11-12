using System;
using System.Collections.Generic;
using UnityEngine;

namespace Level.Editing
{
    [CreateAssetMenu(menuName = "Entity Palette")]
    public class EntityPalette : ScriptableObject
    {
        [SerializeField] private List<EntityInfo> _brushes;
        public List<EntityInfo> Brushes => _brushes;
    }
}
