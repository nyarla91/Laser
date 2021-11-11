using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace NyarlaEssentials
{
    public class NEMath : MonoBehaviour
    {
        public static void Normalize(ref float value)
        {
            value = Normalize(value);
        }

        public static float Normalize(float value) => value == 0 ? 0 : value / Mathf.Abs(value);

        public static bool InBounds(float number, float max, float min) => (number >= min && number <= max);

        public static bool InBounds(float number, float bound) =>  InBounds(number, bound, -bound);

        public static float Evaluate(float value, float min, float max) => Mathf.Clamp((value - min) / (max - min), 0, 1);

        public static float Snap(float value, float step) => step == 0 ? value : Mathf.Round(value / step) * step;

        public static void Snap(ref float value, float step) => value = Snap(value, step);
        
        public static float TimeSin(float min, float max, float timeScale, float timeOffset)
        {
            float sin = Mathf.Sin(Time.time * timeScale + timeOffset);
            return Mathf.Lerp(min, max, (sin + 1) / 2);
        }
        public static float TimeSin(float min, float max, float timeScale) => TimeSin(min, max, timeScale, 0);
        public static float TimeSin(float min, float max) => TimeSin(min, max, 1);

        public static float Average(float[] numbers)
        {
            if (numbers.Length == 0)
                return 0;
            if (numbers.Length == 1)
                return numbers[0];
            float total = 0;
            foreach (var number in numbers)
            {
                total += number;
            }
            return total / numbers.Length;
        }
    }
}