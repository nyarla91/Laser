using Project;
using UnityEngine;

namespace Gameplay.UI
{
    public class MenuButton : MonoBehaviour
    {
        public void OnClick()
        {
            SceneLoader.Load(SceneName.Menu);
        }
    }
}