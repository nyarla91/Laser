using System;
using Level.Entity.Component;
using Project;
using UnityEngine;

namespace Level.Entity
{
    [RequireComponent(typeof(LaserReciever))]
    public class LaserCatcher : PuzzleElement
    {
        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            if (!Direction.Equals(directionFrom))
                return;
        }
    }
}
