using System.Collections.Generic;
using System.IO;
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
        [SerializeField] [TextArea(10, 20)] private string _level;

        private Dictionary<string, EditorPuzzleElement> _buildingPallete = new Dictionary<string, EditorPuzzleElement>();
        
        public override void InitializeInstance()
        {
            _instance = this;
            foreach (var brush in _entityPalette.Brushes)
            {
                _buildingPallete.Add(brush.Name, brush);
            }
        }

        public EditorPuzzleElement EntityForName(string name)
        {
            return _buildingPallete.ContainsKey(name) ? _buildingPallete[name] : null;
        }

        private void Awake()
        {
            string targetJson = File.Exists(Application.dataPath + "/level.json")
                ? File.ReadAllText(Application.dataPath + "/level.json") : _level;
            LevelData levelData = JsonUtility.FromJson<LevelData>(targetJson);
            
            foreach (var entity in levelData.Entities)
            {
                EditorPuzzleElement entityObject = EntityForName(entity.Name);
                float z = entityObject.Background ? BackgroundLayerZ : EntityLayerZ;
                Vector3 position = new Vector3(entity.GridPosition.x, entity.GridPosition.y, z);
                Quaternion rotation = Quaternion.Euler(0, 0, entity.Rotation);
                EditorPuzzleElement newEntity = Creator.Create<EditorPuzzleElement>(entityObject.gameObject, position, rotation);
                newEntity.Data = entity.Data;
            }
        }
    }
}