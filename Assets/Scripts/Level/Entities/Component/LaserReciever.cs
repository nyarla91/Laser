using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

namespace Level.Entities.Component
{
    public class LaserReciever : MonoBehaviour
    {
        public delegate void LaserHitHandler(OrtigraphicVector directionFrom);

        public LaserHitHandler OnLaserHit;
    }
}
