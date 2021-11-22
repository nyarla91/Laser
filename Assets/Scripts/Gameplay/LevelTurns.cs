using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gameplay.Entities;
using Project;
using UnityEngine;

namespace Gameplay
{
    public class LevelTurns : MonoBehaviour
    {
        
        private List<IRecalculated> _recalculatedEntities = new List<IRecalculated>();

        public void AddRecalculatedEntity(IRecalculated entityToAdd)
        {
            _recalculatedEntities.Add(entityToAdd);
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
            Level.Instance.Status.StartVictoryCheck();
        }
    }
}
