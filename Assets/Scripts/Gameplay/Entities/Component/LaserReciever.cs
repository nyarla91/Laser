using System.Collections;
using System.Collections.Generic;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Gameplay.Entities.Component
{
    public class LaserReciever : MonoBehaviour
    {
        public delegate void LaserHitHandler(OrtigraphicVector directionFrom);

        public LaserHitHandler OnLaserHit;
    }
}
