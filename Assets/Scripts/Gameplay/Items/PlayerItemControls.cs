using Gameplay.Editing;
using Gameplay.Entities.Component;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Gameplay.Items
{
    public class PlayerItemControls : SingletonImplenentator
    {
        private static PlayerItemControls _instance;
        public static PlayerItemControls Instance => _instance;

        private PuzzleItem _currentPlacingItem;

        public bool Placing => _currentPlacingItem != null;
        
        public override void InitializeInstance()
        {
            _instance = this;
        }

        public void StartPlacingItem(PuzzleItem placingItem)
        {
            _currentPlacingItem = placingItem;
        }

        public void PlaceItem(Vector2Int position)
        {
            if (_currentPlacingItem == null || LevelSpace.GetEntityAtPosition(position) != null)
            {
                CancelPlacingItem();
                return;
            }
            GameObject placedEntity = Level.Instance.Builder.EntityForName(_currentPlacingItem.Entity.Name).gameObject;
            Vector3 worldPosition = new Vector3(position.x, position.y, LevelSpace.EntityLayerZ);
            EntityInfo newEntity = Creator.Create<EntityInfo>(placedEntity, worldPosition);
            EntityPlayerControl newEntityPlayerControl = newEntity.GetComponentInChildren<EntityPlayerControl>();
            newEntityPlayerControl.Init(_currentPlacingItem);
            
            Level.Instance.Turns.RecalculateAll();
            _currentPlacingItem.SpendOneItem();
            CancelPlacingItem();
        }

        public void CancelPlacingItem()
        {
            _currentPlacingItem = null;
        }
    }
}