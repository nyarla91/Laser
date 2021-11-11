﻿using NyarlaEssentials;
using UnityEngine;

namespace Project
{
    public class OrtigraphicVector
    {
        private Vector2 _vector;

        public Vector2 Vector
        {
            get => _vector;
            set => _vector = NEVectors.Align(value, 90);
        }

        public OrtigraphicVector Opposite => new OrtigraphicVector(_vector * -1);

        public OrtigraphicVector(Vector2 vector)
        {
            Vector = vector;
        }

        public override bool Equals(object obj)
        {
            return obj is OrtigraphicVector && Vector == ((OrtigraphicVector) obj).Vector;
        }

        public override string ToString()
        {
            return Vector.ToString();
        }

        public OrtigraphicVector RotateClockwise()
        {
            Vector = NEVectors.Rotate(Vector, -90);
            return this;
        }
        
        public OrtigraphicVector RotateCounterClockwise()
        {
            Vector = NEVectors.Rotate(Vector, 90);
            return this;
        }
    }
}