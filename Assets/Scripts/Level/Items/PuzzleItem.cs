using Level.Editing;
using NyarlaEssentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Level.Items
{
    public class PuzzleItem : Transformer
    {
        [SerializeField] private TextMeshProUGUI _numberCounter;
        [SerializeField] private EntityInfo _entity;
        [SerializeField] private int _number;

        public EntityInfo Entity => _entity;

        private int Number
        {
            get => _number;
            set
            {
                _number = value;
                _numberCounter.text = value.ToString();
            }
        }
        
        public void Select()
        {
            if (_number > 0)
            {
                PlayerItemControls.Instance.StartPlacingItem(this);
            }
        }

        public void SpendOneItem() => Number--;
        public void AddOneItem() => Number++;
    }
}