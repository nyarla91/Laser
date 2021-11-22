using System;
using System.Collections.Generic;
using System.IO;
using NyarlaEssentials;
using UnityEngine;

namespace Gameplay.Editing
{
    public class LevelParser : Transformer
    {
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
            foreach (var element in elements)
            {
                float rotation = element.transform.eulerAngles.z;
                Vector3 elementPosition = element.transform.position;
                Vector2Int gridPosition = new Vector2Int
                    (Mathf.RoundToInt(elementPosition.x), Mathf.RoundToInt(elementPosition.y));
                level.AddEntity(new EntitiyOnLevel(element.Name, rotation, element.Data, gridPosition));
            }
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
            File.WriteAllText(Application.dataPath + "/level.json", json);
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