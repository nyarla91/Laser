using System.Collections;
using System.Collections.Generic;
using NyarlaEssentials;
using Project;
using UnityEngine;

namespace Level.Entities
{
    public class Entity : Transformer
    {
        public OrtigraphicVector Direction => new OrtigraphicVector(NEVectors.DegreesToVector2(transform.rotation.eulerAngles.z));
    }
}
