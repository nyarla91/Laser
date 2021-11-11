using Level.Entity.Component;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Level.Entity
{
    [RequireComponent(typeof(LaserCaster))]
    [RequireComponent(typeof(LaserReciever))]
    public class LaserSplitter : PuzzleElement
    {
        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            if (Direction.Vector != directionFrom.Vector)
                return;

            OrtigraphicVector directionTo = Direction.RotateClockwise();
            Caster.CastLaser(transform.position, directionTo);
            Caster.CastLaser(transform.position, directionTo.Opposite);
        }
    }
}