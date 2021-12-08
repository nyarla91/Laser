using Project;
using UnityEngine;

namespace Gameplay.UI
{
    public class RestartButton : MonoBehaviour
    {
        public void OnClick()
        {
            SceneLoader.Load(SceneName.Gameplay);
        }
    }
}