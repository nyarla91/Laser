using System;
using System.Numerics;
using Gameplay.Items;
using NyarlaEssentials;
using NyarlaEssentials.Pointers;
using UnityEngine;
using PointerType = NyarlaEssentials.Pointers.PointerType;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

namespace Gameplay.Entities.Component
{
    [RequireComponent(typeof(PointerTarget))]
    public class EntityPlayerControl : Transformer
    {
        private const float RemoveHoldTime = 0.5f;
        
        private PointerTarget _pointerTarget;
        private PuzzleItem _puzzleItem;
        private float _removeTimer;

        public void Init(PuzzleItem puzzleItem)
        {
            _puzzleItem = puzzleItem;
        }
        
        private void Awake()
        {
            _pointerTarget = GetComponent<PointerTarget>();
            _pointerTarget.OnClick += OnClick;
            _pointerTarget.OnDrag += OnDrag;
            _pointerTarget.OnDragEnd += OnDragEnd;
            _pointerTarget.OnUp += OnUp;
        }

        private void OnClick(PointerType pointer, Vector3 position)
        {
            Rotate();
        } 

        private void OnDrag(PointerType pointer) => _removeTimer += _pointerTarget.DeltaDragTime;

        private void OnUp(PointerType pointer, Vector3 position)
        {
            if (_removeTimer >= 0.3f)
            {
                Remove();
            }
            OnDragEnd(pointer);
        }

        private void OnDragEnd(PointerType pointer) => _removeTimer = 0;

        private void Remove()
        {
            _puzzleItem.AddOneItem();
            Destroy(transform.parent.gameObject);
            Level.Instance.Turns.RecalculateAll();
        }

        private void Rotate()
        {
            transform.parent.Rotate(0, 0, -90);
            Level.Instance.Turns.RecalculateAll();
        }
    }
}