using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private GameObject _sceneTransitionPrefab;
        private static SceneLoader _instance;
        private bool _loading;
        private RectTransform _canvas;
        

        public static SceneLoader Instance => _instance;
        public static bool Loading => Instance._loading;
        public static bool NotLoading => !Instance._loading;

        private void Awake()
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            FindCanvas();
            Load(SceneName.Menu);
        }

        public static void Load(int index)
        {
            Instance.StartCoroutine(Instance.TransitScene(SceneManager.GetSceneByBuildIndex(index).name));
        }

        public static void Load(string scene)
        {
            Instance.StartCoroutine(Instance.TransitScene(scene));
        }

        private IEnumerator TransitScene(string scene)
        {
            const float FadeDuration = 0.4f;
            
            if (Loading)
                yield break;
            
            _loading = true;
            yield return StartCoroutine(CreateTransition(FadeDuration, false));

            SceneManager.LoadScene(scene);
            yield return null; 
            yield return StartCoroutine(CreateTransition(FadeDuration, true));
            _loading = false;
        }

        private IEnumerator CreateTransition(float duration, bool isOut)
        {
            if (!FindCanvas())
                yield break;
            
            RectTransform transition = Instantiate(_sceneTransitionPrefab, _canvas).GetComponent<RectTransform>();
            float x = ConstantScreen.Width * 1.3f;
            float startingX = isOut ? 0 : -x;
            float endingX = isOut ? x : 0;
            for (float i = 0; i < 1; i += Time.deltaTime / duration)
            {
                transition.anchoredPosition = new Vector2(Mathf.Lerp(startingX, endingX, i), 0);
                yield return null;
            }
        }

        private bool FindCanvas()
        {
            _canvas = GameObject.FindObjectOfType<MainCanvas>()?.RectTransform;
            return _canvas != null;
        }
    }
}