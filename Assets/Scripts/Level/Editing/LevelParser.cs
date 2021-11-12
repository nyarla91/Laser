using System.IO;
using NyarlaEssentials;
using UnityEngine;

namespace Level.Editing
{
    public class LevelParser : Transformer
    {
        private void Start()
        {
            SaveLevel(ParseLevelData(LevelDataFromScene()));
        }

        private LevelData LevelDataFromScene()
        {
            LevelData newLevel = new LevelData();
            EditorPuzzleElement[] elements = transform.GetComponentsInChildren<EditorPuzzleElement>();
            foreach (var element in elements)
            {
                float rotation = element.transform.eulerAngles.z;
                Vector3 elementPosition = element.transform.position;
                Vector2Int gridPosition = new Vector2Int
                    (Mathf.RoundToInt(elementPosition.x), Mathf.RoundToInt(elementPosition.y));
                newLevel.AddEntity(new EntitiyOnLevel(element.Name, rotation, element.Data, gridPosition));
            }
            return newLevel;
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
}