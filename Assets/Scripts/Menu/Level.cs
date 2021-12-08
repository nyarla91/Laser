using NyarlaEssentials.Pointers;
using Project;
using UnityEngine;
using PointerType = NyarlaEssentials.Pointers.PointerType;

namespace Menu
{
    [RequireComponent(typeof(PointerTarget))]
    public class Level : MonoBehaviour
    {
        [SerializeField] private LevelPack _levelPackIn;
        [SerializeField] private int _levelIndex;

        private PointerTarget _pointerTarget;

        private void Awake()
        {
            _pointerTarget = GetComponent<PointerTarget>();
            _pointerTarget.OnClick += OnClick;
        }

        private void OnClick(PointerType pointer, Vector3 contactPoint)
        {
            Gameplay.Level.SetCurrentLevel(_levelPackIn, _levelIndex);
            SceneLoader.Load(SceneName.Gameplay);
        }
    }
}