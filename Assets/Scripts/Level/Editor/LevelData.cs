using System;
using System.Collections.Generic;

namespace Level.Editor
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

        public EntitiyOnLevel(string entity, float rotation)
        {
            _entity = entity;
            _rotation = rotation;
        }
    }
}