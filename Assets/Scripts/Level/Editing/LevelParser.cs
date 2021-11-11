using NyarlaEssentials;
using UnityEngine;

namespace Level.Editing
{
    public class LevelParser : MonoBehaviour
    {
        [SerializeField] private Transformer _level;
        
        private void Start()
        {
            GenerateLevel();
        }

        private void GenerateLevel()
        {
            LevelData newLevel = new LevelData();
            Transform[] entities = _level.AllChildren;
            foreach (var entity in entities)
            {
                
            }
        }

        private void SaveLevel(string json)
        {
            
        }
    }
}