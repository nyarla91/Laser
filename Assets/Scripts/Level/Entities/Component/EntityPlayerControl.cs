using System;
using Level.Items;
using NyarlaEssentials;
using NyarlaEssentials.Pointers;
using UnityEngine;
using PointerType = NyarlaEssentials.Pointers.PointerType;

namespace Level.Entities.Component
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
                transform.parent.Rotate(0, 0, -90);
                LevelTurns.Instance.RecalculateAll();
            }
            else if (pointer == PointerType.Right)
            {
                _puzzleItem.AddOneItem();
                Destroy(transform.parent.gameObject);
                LevelTurns.Instance.RecalculateAll();
            }
        }
    }
}