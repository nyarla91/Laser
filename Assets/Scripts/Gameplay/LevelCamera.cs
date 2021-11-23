using NyarlaEssentials;
using UnityEngine;

namespace Gameplay
{
    public class LevelCamera : Transformer
    {
        public void Setup(int levelWidth)
        {
            float scale = levelWidth + 0.4f;
            transform.localScale = Vector3.one * scale;
            CameraProperties.Main.orthographicSize = scale;
            if (NEMath.IsEven(levelWidth))
            {
                transform.Translate(Vector3.right * 0.5f);
            }
        }
    }
}