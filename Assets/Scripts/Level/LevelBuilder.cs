using System;
using System.Collections.Generic;
using Project;
using UnityEngine;
using Level.Editing;

namespace Level
{
    public class LevelBuilder : SingletonImplenentator
    {
        public const float BackgroundLayerZ = 10;
        public const float EntityLayerZ = 0;
        public const float LaserLayerZ = -1;

        private static LevelBuilder _instance;

        [SerializeField] private EntityPalette _entityPalette;

        private Dictionary<string, GameObject> _buildingPallete = new Dictionary<string, GameObject>();
        private Dictionary<GameObject, string> _parsingPalette = new Dictionary<GameObject, string>();
        
        public override void InitializeInstance()
        {
            _instance = this;
            foreach (var brush in _entityPalette.Brushes)
            {
                _buildingPallete.Add(brush.Name, brush.Entity);
                _parsingPalette.Add(brush.Entity, brush.Name);
            }
        }
    }
}