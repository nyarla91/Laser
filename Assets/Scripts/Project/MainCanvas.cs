using NyarlaEssentials;
using UnityEngine;

namespace Project
{
    public class MainCanvas : MonoBehaviour
    {
        [SerializeField] private RectTransform _rectTransform;
        public RectTransform RectTransform => _rectTransform;
    }
}