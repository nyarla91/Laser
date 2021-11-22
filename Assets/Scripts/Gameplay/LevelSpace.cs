using Gameplay.Entities;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Gameplay
{
    public class LevelSpace : MonoBehaviour
    {
        public const float BackgroundLayerZ = 10;
        public const float EntityLayerZ = 0;
        public const float LaserLayerZ = -1;

        public static Entity GetEntityAtPosition(Vector2Int position)
        {
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