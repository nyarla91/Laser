using System;
using System.Collections.Generic;
using System.Linq;
using NyarlaEssentials;
using UnityEngine;

namespace Level.Editor
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