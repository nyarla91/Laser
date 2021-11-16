using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Level.Entities;
using Project;
using UnityEngine;

namespace Level
{
    public class LevelTurns : SingletonImplenentator
    {
        private static LevelTurns _instance;
        public static LevelTurns Instance => _instance;
        
        private List<IRecalculated> _recalculatedEntities = new List<IRecalculated>();

        public void AddRecalculatedEntity(IRecalculated entityToAdd)
        {
            _recalculatedEntities.Add(entityToAdd);
        }

        public override void InitializeInstance()
        {
            _instance = this;
            StartCoroutine(FirstTurn());
        }

        private IEnumerator FirstTurn()
        {
            yield return new WaitForSeconds(0.5f);
            RecalculateAll();
        }

        public void RecalculateAll()
        {
            _recalculatedEntities = _recalculatedEntities.OrderBy(entity => -entity.GetRecalculationPriority()).ToList();
            foreach (var entity in _recalculatedEntities)
            {
                entity.Recalculate();
            }
        }
    }
}
