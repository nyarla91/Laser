using System;
using System.Collections.Generic;
using System.IO;
using NyarlaEssentials;
using UnityEngine;

namespace Gameplay.Editing
{
    public class LevelParser : Transformer
    {
        [SerializeField] private string _levelName;
        [SerializeField] private List<PuzzleItemInEditor> _puzzleItems;
        
        private void Start()
        {
            LevelData newLevel = new LevelData();
            AddEntitiesToLevel(ref newLevel);
            AddPuzzleItemsToLevel(ref newLevel);
            SaveLevel(ParseLevelData(newLevel));
        }

        private void AddEntitiesToLevel(ref LevelData level)
        {
            EntityInfo[] elements = transform.GetComponentsInChildren<EntityInfo>();
            
            Vector2Int mostPositions = new Vector2Int(Int32.MinValue, Int32.MinValue);
            Vector2Int leastPositions = new Vector2Int(Int32.MaxValue, Int32.MaxValue);
            
            foreach (var element in elements)
            {
                float rotation = element.transform.eulerAngles.z;
                Vector3 elementPosition = element.transform.position;
                Vector2Int gridPosition = new Vector2Int
                    (Mathf.RoundToInt(elementPosition.x), Mathf.RoundToInt(elementPosition.y));
                level.AddEntity(new EntitiyOnLevel(element.Name, rotation, element.Data, gridPosition));
                
                mostPositions.x = Mathf.Max(mostPositions.x, gridPosition.x);
                mostPositions.y = Mathf.Max(mostPositions.y, gridPosition.y);
                leastPositions.x = Mathf.Min(leastPositions.x, gridPosition.x);
                leastPositions.y = Mathf.Min(leastPositions.y, gridPosition.y);
            }
            level.Size = mostPositions - leastPositions + Vector2Int.one;
        }

        private void AddPuzzleItemsToLevel(ref LevelData level)
        {
            foreach (var puzzleItem in _puzzleItems)
            {
                level.AddPuzzleItem(puzzleItem.ToLevel);
            }
        }

        private string ParseLevelData(LevelData levelData)
        {
            print(levelData);
            return JsonUtility.ToJson(levelData, true);
        }

        private void SaveLevel(string json)
        {
            print(json);
            File.WriteAllText( $"{Application.dataPath}/Levels/{_levelName}.json", json);
        }
    }

    [Serializable]
    public class PuzzleItemInEditor
    {
        [SerializeField] private EntityInfo _entity;
        [SerializeField] private int _ammount;

        public PuzzleItemOnLevel ToLevel => new PuzzleItemOnLevel(_entity, _ammount);
    }
}