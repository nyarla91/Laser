using System;
using System.Collections.Generic;
using UnityEngine;

namespace Level.Editing
{
    [CreateAssetMenu(menuName = "Entity Palette")]
    public class EntityPalette : ScriptableObject
    {
        [SerializeField] private List<EditorPuzzleElement> _brushes;
        public List<EditorPuzzleElement> Brushes => _brushes;
    }
}
