using NyarlaEssentials;
using UnityEngine;

namespace Level.Graphic
{
    public class Laser : MonoBehaviour
    {
        [SerializeField] private LineRenderer _lineRenderer;

        public void Init(Vector2 originPoint, Vector2 targetPoint)
        {
            Vector3[] linePoints = new[]
            {
                NEVectors.WithZ(originPoint, LevelSpace.LaserLayerZ),
                NEVectors.WithZ(targetPoint, LevelSpace.LaserLayerZ),
            };
            _lineRenderer.SetPositions(linePoints);
        }
    }
}