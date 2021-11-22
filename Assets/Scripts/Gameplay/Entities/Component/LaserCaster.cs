using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Graphic;
using Project;
using NyarlaEssentials;
using UnityEngine;

namespace Gameplay.Entities.Component
{
    public class LaserCaster : Transformer, IRecalculated
    {
        private List<Laser> _myLasers = new List<Laser>();

        public float GetRecalculationPriority() => 10;

        public void Recalculate()
        {
            foreach (var laser in _myLasers)
            {
                Destroy(laser.gameObject);
            }
            _myLasers = new List<Laser>();
        }

        public void CastLaser(Vector2 originPosition, OrtigraphicVector direction)
        {
            gameObject.layer = (int) Layer.IngoreRaycast;
            
            direction.Vector = direction.Vector.normalized;
            RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, direction.Vector, 500, (int) LayerPowered.Entity);
            gameObject.layer = (int) Layer.Entity;

            if (raycastHit.collider != null)
            {
                LaserReciever reciever = raycastHit.collider.GetComponent<LaserReciever>();
                reciever?.OnLaserHit?.Invoke(direction.Opposite);
                CreateLaser(originPosition, raycastHit.point);
            }
        }

        private void CreateLaser(Vector2 originPoint, Vector2 targetPoint)
        {
            Laser newLaser = Creator.Create<Laser>(Creator.LaserPrefab, Vector3.zero);
            _myLasers.Add(newLaser);
            if (newLaser != null)
            {
                newLaser.Init(originPoint, targetPoint);
            }
        }

        private void Awake()
        {
            Level.Instance.Turns.AddRecalculatedEntity(this);
        }
    }
}
