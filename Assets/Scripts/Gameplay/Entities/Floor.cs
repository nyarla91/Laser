using System;
using Gameplay.Items;
using NyarlaEssentials;
using NyarlaEssentials.Pointers;
using UnityEngine;
using PointerType = NyarlaEssentials.Pointers.PointerType;

namespace Gameplay.Entities
{
    [RequireComponent(typeof(PointerTarget))]
    public class Floor : MonoBehaviour
    {
        private PointerTarget _pointerTarget;

        private void Awake()
        {
            _pointerTarget = GetComponent<PointerTarget>();
            _pointerTarget.OnUp += OnUp;
        }

        private void OnUp(PointerType pointerType, Vector3 position)
        {
            PlayerItemControls.Instance.PlaceItem((Vector2Int) NEVectors.FloatToInt(transform.position));
        }
    }
}