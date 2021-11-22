using System;
using Gameplay.Items;
using NyarlaEssentials;
using NyarlaEssentials.Pointers;
using UnityEngine;
using PointerType = NyarlaEssentials.Pointers.PointerType;

namespace Gameplay.Entities.Component
{
    [RequireComponent(typeof(PointerTarget))]
    public class EntityPlayerControl : Transformer
    {
        private PointerTarget _pointerTarget;
        private PuzzleItem _puzzleItem;

        public void Init(PuzzleItem puzzleItem)
        {
            _puzzleItem = puzzleItem;
        }
        
        private void Awake()
        {
            _pointerTarget = GetComponent<PointerTarget>();
            _pointerTarget.OnClick += OnClick;
        }

        private void OnClick(PointerType pointer, Vector3 position)
        {
            if (pointer == PointerType.Left)
            {
                Rotate();
            }
            else if (pointer == PointerType.Right)
            {
                Remove();
            }
        }

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