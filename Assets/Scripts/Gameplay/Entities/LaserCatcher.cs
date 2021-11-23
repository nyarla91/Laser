using System;
using Gameplay.Entities.Component;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Gameplay.Entities
{
    [RequireComponent(typeof(LaserReciever))]
    [RequireComponent(typeof(VictoryPrerequsite))]
    public class LaserCatcher : PuzzleElement
    {
        [SerializeField] private VictoryPrerequsite _prerequsite;
        
        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            if (!Direction.Equals(directionFrom))
                return;
            
            _prerequsite.Check();
        }
    }
}
