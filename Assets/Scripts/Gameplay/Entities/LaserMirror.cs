using System;
using Gameplay.Entities.Component;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Gameplay.Entities
{
    [RequireComponent(typeof(LaserCaster))]
    [RequireComponent(typeof(LaserReciever))]
    public class LaserMirror : PuzzleElement
    {
        
        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            Vector2 normal = Direction.IsVertical ? new Vector2(1, -1) : Vector2.one;
            OrtigraphicVector directionTo = new OrtigraphicVector(Vector2.Reflect(directionFrom.Vector, normal));
            Caster.CastLaser(transform.position, directionTo);
        }
    }
}