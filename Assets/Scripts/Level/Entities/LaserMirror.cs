using System;
using Level.Entities.Component;
using Project;
using UnityEngine;

namespace Level.Entities
{
    [RequireComponent(typeof(LaserCaster))]
    [RequireComponent(typeof(LaserReciever))]
    public class LaserMirror : PuzzleElement
    {
        private bool _topRightOriented;
        
        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
            _topRightOriented = Direction.Vector.y == 0;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            Vector2 normal = _topRightOriented ? new Vector2(1, -1) : Vector2.one;
            OrtigraphicVector directionTo = new OrtigraphicVector(Vector2.Reflect(directionFrom.Vector, normal));
            Caster.CastLaser(transform.position, directionTo);
        }
    }
}