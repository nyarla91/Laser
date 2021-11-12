using Level.Entities;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Level
{
    public class LevelSpace : SingletonImplenentator
    {
        public const float BackgroundLayerZ = 10;
        public const float EntityLayerZ = 0;
        public const float LaserLayerZ = -1;
        
        private static LevelSpace _instance;
        public static LevelSpace Instance => _instance;
        
        public override void InitializeInstance()
        {
            _instance = this;
        }

        public static Entity GetEntityAtPosition(Vector2Int position)
        {
            print(NEVectors.IntToFloat(position));
            Collider2D[] colliders = Physics2D.OverlapCircleAll(
                NEVectors.IntToFloat(position), 0.5f);
            foreach (var collider in colliders)
            {
                Entity entity;
                if (collider.TryGetComponent(out entity))
                {
                    return entity;
                }
            }
            return null;
        }
    }
}