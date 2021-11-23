using System.Collections.Generic;
using Gameplay.Editing;
using Gameplay.Items;
using Project;
using UnityEngine;

namespace Gameplay
{
    public class LevelBuilder : MonoBehaviour
    {
        [SerializeField] private EntityPalette _entityPalette;
        [SerializeField] private TextAsset _level;
        [SerializeField] private RectTransform _puzzleItemsOrigin;
        [SerializeField] private GameObject _puzzleItemPrefab;

        private Dictionary<string, EntityInfo> _buildingPallete = new Dictionary<string, EntityInfo>();

        public EntityInfo EntityForName(string name)
        {
            return _buildingPallete.ContainsKey(name) ? _buildingPallete[name] : null;
        }

        private void Awake()
        {
            if (_level != null)
            {
                InitializePallete();
                string targetJson = _level.text;
                LevelData levelData = JsonUtility.FromJson<LevelData>(targetJson);
                BuildLevel(levelData.Entities);
                BuildPuzzleItems(levelData.Items);
                Level.Instance.Camera.Setup(levelData.Size.x);
            }
        }

        private void BuildLevel(List<EntitiyOnLevel> entities)
        {
            foreach (var entity in entities)
            {
                EntityInfo entityObject = EntityForName(entity.Name);
                float z = entityObject.Background ? LevelSpace.BackgroundLayerZ : LevelSpace.EntityLayerZ;
                Vector3 position = new Vector3(entity.GridPosition.x, entity.GridPosition.y, z);
                Quaternion rotation = Quaternion.Euler(0, 0, entity.Rotation);
                
                EntityInfo newEntity = Creator.Create<EntityInfo>(entityObject.gameObject, position, rotation);
                newEntity.Data = entity.Data;
            }
        }

        private void BuildPuzzleItems(List<PuzzleItemOnLevel> _puzzleItems)
        {
            float edgeX = 0.5f * (_puzzleItems.Count - 1);
            for (int i = 0; i < _puzzleItems.Count; i++)
            {
                float positionX = Mathf.Lerp(-edgeX, edgeX, (float) i / (_puzzleItems.Count - 1));
                PuzzleItem newPuzzleItem = Instantiate(_puzzleItemPrefab, _puzzleItemsOrigin).GetComponent<PuzzleItem>();
                newPuzzleItem.RectTransform.anchoredPosition = new Vector2(positionX * 250, 0);
                newPuzzleItem.Init(_puzzleItems[i]);
            }
        }

        private void InitializePallete()
        {
            foreach (var brush in _entityPalette.Brushes)
            {
                _buildingPallete.Add(brush.Name, brush);
            }
        }
    }
}