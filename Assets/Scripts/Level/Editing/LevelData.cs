using System;
using System.Collections.Generic;
using UnityEngine;

namespace Level.Editing
{
    [Serializable]
    public class LevelData
    {
        [SerializeField] private List<EntitiyOnLevel> _entities = new List<EntitiyOnLevel>();
        public List<EntitiyOnLevel> Entities => _entities;

        public void AddEntity(EntitiyOnLevel entityToAdd)
        {
            _entities.Add(entityToAdd);
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
}