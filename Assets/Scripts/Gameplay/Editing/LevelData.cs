using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Editing
{
    [Serializable]
    public class LevelData
    {
        [SerializeField] private List<EntitiyOnLevel> _entities = new List<EntitiyOnLevel>();
        [SerializeField] private List<PuzzleItemOnLevel> _items = new List<PuzzleItemOnLevel>();
        [SerializeField] private Vector2Int size;

        public List<EntitiyOnLevel> Entities => _entities;

        public List<PuzzleItemOnLevel> Items => _items;

        public Vector2Int Size
        {
            get => size;
            set => size = value;
        }

        public void AddEntity(EntitiyOnLevel entityToAdd)
        {
            _entities.Add(entityToAdd);
        }
        
        public void AddPuzzleItem(PuzzleItemOnLevel puzzleItemToAdd)
        {
            _items.Add(puzzleItemToAdd);
        }

        public override string ToString()
        {
            string result = "";
            foreach (var entity in _entities)
            {
                result += entity + "\n";
            }
            return result;
        }
    }

    [Serializable]
    public class EntitiyOnLevel
    {
        [SerializeField] private string _name;
        [SerializeField] private float _rotation;
        [SerializeField] private int _data;
        [SerializeField] private Vector2Int _gridPosition;

        public string Name => _name;
        public float Rotation => _rotation;
        public int Data => _data;
        public Vector2Int GridPosition => _gridPosition;

        public EntitiyOnLevel(string name, float rotation, int data, Vector2Int gridPosition)
        {
            _name = name;
            _rotation = rotation;
            _data = data;
            _gridPosition = gridPosition;
        }

        public override string ToString()
        {
            return $"{_name} : {_rotation} degrees, Data-{_data}, {_gridPosition}";
        }
    }

    [Serializable]
    public class PuzzleItemOnLevel
    {
        [SerializeField] private string _entityName;
        [SerializeField] private int _ammount;

        public string EntityName => _entityName;
        public int Ammount => _ammount;

        public PuzzleItemOnLevel(EntityInfo entity, int ammount)
        {
            _entityName = entity.Name;
            _ammount = ammount;
        }
    }
}