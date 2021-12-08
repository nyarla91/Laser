using NyarlaEssentials;
using UnityEngine;

namespace Gameplay
{
    public class LevelCamera : Transformer
    {
        [SerializeField] private RectTransform _screenCenter;
        public Camera Camera => CameraProperties.Main;

        public void Setup(int levelWidth)
        {
            float scale = levelWidth + 0.4f;
            transform.localScale = Vector3.one * scale;
            Camera.orthographicSize = scale;
            if (NEMath.IsEven(levelWidth))
            {
                transform.Translate(Vector3.right * 0.5f);
            }
        }
    }
}