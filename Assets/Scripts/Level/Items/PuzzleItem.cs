using Level.Editing;
using NyarlaEssentials;
using UnityEngine;
using UnityEngine.UI;

namespace Level.Items
{
    public class PuzzleItem : Transformer
    {
        [SerializeField] private EntityInfo _entity;
        [SerializeField] private int _number;

        public EntityInfo Entity => _entity;
        
        public void Select()
        {
            PlayerItemControls.Instance.StartPlacingItem(this);
        }
    }
}