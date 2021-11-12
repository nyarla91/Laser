using System.Collections.Generic;
using System.IO;
using Project;
using UnityEngine;
using Level.Editing;

namespace Level
{
    public class LevelBuilder : SingletonImplenentator
    {

        private static LevelBuilder _instance;
        public static LevelBuilder Instance => _instance;

        [SerializeField] private EntityPalette _entityPalette;
        [SerializeField] private TextAsset _level;

        private Dictionary<string, EntityInfo> _buildingPallete = new Dictionary<string, EntityInfo>();
        
        public override void InitializeInstance()
        {
            _instance = this;
            foreach (var brush in _entityPalette.Brushes)
            {
                _buildingPallete.Add(brush.Name, brush);
            }
        }

        public EntityInfo EntityForName(string name)
        {
            return _buildingPallete.ContainsKey(name) ? _buildingPallete[name] : null;
        }

        private void Awake()
        {
            string targetJson = _level.text;
            LevelData levelData = JsonUtility.FromJson<LevelData>(targetJson);
            
            foreach (var entity in levelData.Entities)
            {
                EntityInfo entityObject = EntityForName(entity.Name);
                float z = entityObject.Background ? LevelSpace.BackgroundLayerZ : LevelSpace.EntityLayerZ;
                Vector3 position = new Vector3(entity.GridPosition.x, entity.GridPosition.y, z);
                Quaternion rotation = Quaternion.Euler(0, 0, entity.Rotation);
                
                EntityInfo newEntity = Creator.Create<EntityInfo>(entityObject.gameObject, position, rotation);
                newEntity.Data = entity.Data;
            }
        }
    }
}