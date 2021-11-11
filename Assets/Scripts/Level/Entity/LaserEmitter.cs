using Level.Entity.Component;
using Project;
using NyarlaEssentials;
using UnityEngine;

namespace Level.Entity
{
    [RequireComponent(typeof(LaserCaster))]
    public class LaserEmitter : PuzzleElement, IRecalculated
    {
        [SerializeField] private Transform _originPoint;

        public float GetRecalculationPriority() => 0;
        
        public void Recalculate()
        {
            Caster.CastLaser(_originPoint.position, Direction);
        }

        private void Awake()
        {
            LevelTurns.Instance.AddRecalculatedEntity(this);
        }
    }
}