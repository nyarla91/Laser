using System.Collections;
using System.Collections.Generic;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Level.Entity
{
    public class Entity : Transformer
    {
        private OrtigraphicVector _direction;

        public OrtigraphicVector Direction => _direction ??
            (_direction = new OrtigraphicVector(NEVectors.DegreesToVector2(transform.rotation.eulerAngles.z)));
    }
}
