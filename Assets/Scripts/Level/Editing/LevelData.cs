using System;
using System.Collections.Generic;

namespace Level.Editing
{
    [Serializable]
    public class LevelData
    {
        private List<EntitiyOnLevel> _entities;

        public void AddEntity(EntitiyOnLevel entityToAdd)
        {
            _entities.Add(entityToAdd);
        }
    }

    [Serializable]
    public class EntitiyOnLevel
    {
        private string _entity;
        private float _rotation;
        private int _data;

        public EntitiyOnLevel(string entity, float rotation, int data)
        {
            _entity = entity;
            _rotation = rotation;
            _data = data;
        }
    }
}