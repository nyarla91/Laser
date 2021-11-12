using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace NyarlaEssentials
{
    public static class NEVectors
    {
        private static Dictionary<Axis, Vector2> _axes2;
        public static Dictionary<Axis, Vector2> Axes2
        {
            get
            {
                if (_axes2 == null)
                {
                    _axes2 = new Dictionary<Axis, Vector2>();
                    _axes2.Add(Axis.X, Vector2.right);
                    _axes2.Add(Axis.Y, Vector2.up);
                }
                return _axes2;
            }
        }

        private static Dictionary<Axis, Vector3> _axes3;
        public static Dictionary<Axis, Vector3> Axes3
        {
            get
            {
                if (_axes3 == null)
                {
                    _axes3 = new Dictionary<Axis, Vector3>();
                    _axes3.Add(Axis.X, Vector3.right);
                    _axes3.Add(Axis.Y, Vector3.up);
                    _axes3.Add(Axis.Z, Vector3.forward);
                }
                return _axes3;
            }
        }
        
        public static Vector2 WithX(Vector2 vector, float newX) => new Vector2(newX, vector.y);

        public static Vector2 WithY(Vector2 vector, float newY) => new Vector2(vector.x, newY);

        public static Vector3 WithX(Vector3 vector, float newX) => new Vector3(newX, vector.y, vector.z);

        public static Vector3 WithY(Vector3 vector, float newY) => new Vector3(vector.x, newY, vector.z);

        public static Vector3 WithZ(Vector3 vector, float newZ) => new Vector3(vector.x, vector.y, newZ);
        
        public static Vector2 DegreesToVector2(float z) =>
            new Vector2(Mathf.Cos(z * Mathf.Deg2Rad), Mathf.Sin(z * Mathf.Deg2Rad));

        public static float Vector2ToDegrees(Vector2 vector)
        {
            vector.Normalize();
            return Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        }

        public static void Rotate(ref Vector2 vector, float degrees)
        {
            float oldDegrees = Vector2ToDegrees(vector);
            float oldDistance = Vector2.Distance(Vector2.zero, vector);
            vector = DegreesToVector2(oldDegrees + degrees) * oldDistance;
        }

        public static Vector2 Rotate(Vector2 vector, float degrees)
        {
            Rotate(ref vector, degrees);
            return vector;
        }

        public static Transform LookAt2D(Transform targetTransform, Vector2 lookAtPosition)
        {
            Vector2 direction = (lookAtPosition - (Vector2) targetTransform.position).normalized;
            targetTransform.rotation = Quaternion.Euler(0, 0, Vector2ToDegrees(direction));
            return targetTransform;
        }

        public static void SnapToGrid(ref Vector2 point, Vector2 gridSize)
        {
            float x = point.x;
            float y = point.y;
            NEMath.Snap(ref x, gridSize.x);
            NEMath.Snap(ref y, gridSize.y);
            point = new Vector2(x, y);
        }

        public static Vector2 SnapToGrid(Vector2 point, Vector2 gridSize)
        {
            SnapToGrid(ref point, gridSize);
            return point;
        }

        public static Vector2 Clamp(Vector2 vector, Vector2 minValues, Vector2 maxValues)
        {
            vector.x = Mathf.Clamp(vector.x, minValues.x, maxValues.x);
            vector.y = Mathf.Clamp(vector.y, minValues.y, maxValues.y);
            return vector;
        }

        public static void Clamp(ref Vector2 vector, Vector2 minValues, Vector2 maxValues)
        {
            vector = Clamp(vector, minValues, maxValues);
        }

        public static Vector2 XZtoXY(Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }

        public static Vector3 XYtoXZ(Vector2 vector)
        {
            return new Vector3(vector.x, 0, vector.y);
        }

        public static Vector2 RandomPointInBounds(Bounds bounds)
        {
            Vector2 max = bounds.max;
            Vector2 min = bounds.min;
            return new Vector2(Random.Range(min.x, max.x), Random.Range(min.y, max.y));
        }

        public static Vector3 LerpMulti(Vector3[] vectors)
        {
            float[] xs = new float[vectors.Length];
            float[] ys = new float[vectors.Length];
            float[] zs = new float[vectors.Length];
            for (int i = 0; i < vectors.Length; i++)
            {
                xs[i] = vectors[i].x;
                ys[i] = vectors[i].y;
                zs[i] = vectors[i].z;
            }
            return new Vector3(NEMath.Average(xs), NEMath.Average(ys), NEMath.Average(zs));
        }

        public static Vector2 LerpMulti(Vector2[] vectors2)
        {
            Vector3[] vectors3 = new Vector3[vectors2.Length];
            for (int i = 0; i < vectors2.Length; i++)
            {
                vectors3[i] = vectors2[i];
            }
            return LerpMulti(vectors3);
        }

        public static Vector2 Align(Vector2 vector, float step)
        {
            float angle = NEVectors.Vector2ToDegrees(vector);
            float magnitude = vector.magnitude;
            NEMath.Snap(ref angle, step);
            return NEVectors.DegreesToVector2(angle) * magnitude;
        }

        public static void Align(ref Vector2 vector, float step) => vector = Align(vector, step);

        public static Vector2 IntToFloat(Vector2Int intVector) => new Vector2(intVector.x, intVector.y);
        public static Vector3 IntToFloat(Vector3Int intVector) => new Vector3(intVector.x, intVector.y, intVector.z);
        public static Vector2Int FloatToInt(Vector2 floatVector) => new Vector2Int(
            Mathf.RoundToInt(floatVector.x),
            Mathf.RoundToInt(floatVector.y));
        public static Vector3Int FloatToInt(Vector3 floatVector) => new Vector3Int(
            Mathf.RoundToInt(floatVector.x),
            Mathf.RoundToInt(floatVector.y),
            Mathf.RoundToInt(floatVector.z));
    }

    public enum Axis
    {
        X,
        Y,
        Z
    }

}