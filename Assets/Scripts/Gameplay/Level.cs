using System;
using Gameplay.Editing;
using Menu;
using Project;
using UnityEngine;

namespace Gameplay
{
    public class Level : SingletonImplenentator
    {
        private static Level _instance;
        public static Level Instance => _instance;
        
        private static LevelPack _currentLevelPack;
        private static int _currentLevelIndex = 1;

        public static LevelPack CurrentLevelPack => _currentLevelPack;
        public static int CurrentLevelIndex => _currentLevelIndex;
        
        [SerializeField] private LevelBuilder _builder;
        [SerializeField] private LevelTurns _turns;
        [SerializeField] private LevelSpace _space;
        [SerializeField] private LevelStatus _status;
        [SerializeField] private LevelCamera _camera;

        public LevelBuilder Builder => _builder;
        public LevelTurns Turns => _turns;
        public LevelSpace Space => _space;
        public LevelStatus Status => _status;
        public LevelCamera Camera => _camera;

        public static void SetCurrentLevel(LevelPack levelPack, int levelIndex)
        {
            _currentLevelPack = levelPack;
            _currentLevelIndex = levelIndex;
        }

        public static void IncrementLevelIndex() => _currentLevelIndex++;

        public override void InitializeInstance()
        {
            _instance = this;
        }

        private void Awake()
        {
            TextAsset level;
            if (CurrentLevelPack.TryGetLevel(CurrentLevelIndex, out level))
            {
                Builder.InitializeLevel(level);
            }
        }
    }
}