using System;
using Level.Entities.Component;
using Project;
using UnityEngine;

namespace Level.Entities
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
