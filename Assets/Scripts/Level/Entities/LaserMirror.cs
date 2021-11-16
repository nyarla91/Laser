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
        private bool TopRightOriented
        {
            get
            {
                float z = transform.rotation.eulerAngles.z;
                return !z.Equals(90) && !z.Equals(270);
            }
        }
        
        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            Vector2 normal = TopRightOriented ? new Vector2(1, -1) : Vector2.one;
            OrtigraphicVector directionTo = new OrtigraphicVector(Vector2.Reflect(directionFrom.Vector, normal));
            Caster.CastLaser(transform.position, directionTo);
        }
    }
}