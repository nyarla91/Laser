using System.IO;
using Gameplay.Entities.Component;
using Project;
using UnityEngine;

namespace Gameplay.Entities
{
    [RequireComponent(typeof(LaserCaster))]
    [RequireComponent(typeof(LaserReciever))]
    [RequireComponent(typeof(VictoryPrerequsite))]
    public class LaserRelay : PuzzleElement
    {
        [SerializeField] private VictoryPrerequsite _prerequsite;
        
        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            Caster.CastLaser(transform.position, directionFrom.Opposite);
            _prerequsite.Check();
        }
    }
}