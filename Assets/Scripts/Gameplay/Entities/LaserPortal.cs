using Gameplay.Entities.Component;
using Project;
using UnityEngine;

namespace Gameplay.Entities
{
    [RequireComponent(typeof(LaserCaster))]
    [RequireComponent(typeof(LaserReciever))]
    public class LaserPortal : PuzzleElement
    {
        [SerializeField] private LaserPortal _pairedPortal;


        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            _pairedPortal.Caster.CastLaser(_pairedPortal.transform.position, directionFrom.Opposite);
        }
    }
}