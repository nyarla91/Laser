using Project;
using UnityEngine;

namespace Menu
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private LevelPack _packIn;
        [SerializeField] private int _levelIndex;

        public void OnClick()
        {
            Gameplay.Level.SetCurrentLevel(_packIn, _levelIndex);
            SceneLoader.Load(SceneName.Gameplay);
        }
    }
}