using System.IO;
using Gameplay.Entities.Component;
using NyarlaEssentials;
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
        [SerializeField] private OrtographicMatrix<Transform> _laserOrigins;

        private void Awake()
        {
            Reciever.OnLaserHit += OnLaserHit;
        }

        private void OnLaserHit(OrtigraphicVector directionFrom)
        {
            Vector2 position = _laserOrigins.ElementFromVector(directionFrom.Opposite).position;
            Caster.CastLaser(position, directionFrom.Opposite);
            _prerequsite.Check();
        }
    }
}