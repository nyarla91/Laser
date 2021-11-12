using System.IO;
using Level.Entities.Component;
using Project;
using UnityEngine;

namespace Level.Entities
{
    [RequireComponent(typeof(LaserCaster))]
    [RequireComponent(typeof(LaserReciever))]
    public class LaserRelay : PuzzleElement
    {
        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            Caster.CastLaser(transform.position, directionFrom.Opposite);
        }
    }
}