using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    [CreateAssetMenu(menuName = "Level Pack")]
    public class LevelPack : ScriptableObject
    {
        [SerializeField] private List<TextAsset> _levels;

        public int LevelsCount => _levels.Count;

        public bool TryGetLevel(int index)
        {
            return index >= 0 && index < LevelsCount;
        }
        
        public bool TryGetLevel(int index, out TextAsset level)
        {
            if (index < 0 || index >= LevelsCount)
            {
                level = null;
                return false;
            }
            level = _levels[index];
            return true;
        }
    }
}