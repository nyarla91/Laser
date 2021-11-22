using Project;
using UnityEngine;

namespace Gameplay
{
    public class Level : SingletonImplenentator
    {
        private static Level _instance;
        public static Level Instance => _instance;

        [SerializeField] private LevelBuilder _builder;
        [SerializeField] private LevelTurns _turns;
        [SerializeField] private LevelSpace _space;
        [SerializeField] private LevelStatus _status;

        public LevelBuilder Builder => _builder;
        public LevelTurns Turns => _turns;
        public LevelSpace Space => _space;
        public LevelStatus Status => _status;
        public override void InitializeInstance()
        {
            _instance = this;
        }
    }
}