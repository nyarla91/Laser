using Gameplay.Editing;
using NyarlaEssentials;
using TMPro;
using UnityEngine;

namespace Gameplay.Items
{
    public class PuzzleItem : Transformer
    {
        [SerializeField] private TextMeshProUGUI _numberCounter;

        private EntityInfo _entity;
        private int _ammount;
        
        public EntityInfo Entity => _entity;

        private int Ammount
        {
            get => _ammount;
            set
            {
                _ammount = value;
                _numberCounter.text = value.ToString();
            }
        }

        public void Init(PuzzleItemOnLevel source)
        {
            _entity = Level.Instance.Builder.EntityForName(source.EntityName);
            Ammount = source.Ammount;
        }
        
        public void Select()
        {
            if (_ammount > 0)
            {
                PlayerItemControls.Instance.StartPlacingItem(this);
            }
        }

        public void SpendOneItem() => Ammount--;
        public void AddOneItem() => Ammount++;
    }
}