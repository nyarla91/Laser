using System;
using System.Collections.Generic;
using NyarlaEssentials;
using UnityEngine;

namespace Project
{
    public class FpsCounter : MonoBehaviour
    {
        private const int DeltasLength = 30;

        private static FpsCounter _instance;
        public static FpsCounter Instance => _instance;
        
        private float[] _lastDeltas = new float[DeltasLength];
        private int _currentDelta;
        private float _fps;

        public float FPS => _fps;

        private void Awake()
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            RecountDeltas();
            RecountFps();
            print(FPS);
        }

        private void RecountDeltas()
        {
            _lastDeltas[_currentDelta] = Time.deltaTime;
            _currentDelta++;
            if (_currentDelta == DeltasLength)
                _currentDelta = 0;
        }

        private void RecountFps()
        {
            _fps = 1 / NEMath.Average(_lastDeltas);
        }
    }
}