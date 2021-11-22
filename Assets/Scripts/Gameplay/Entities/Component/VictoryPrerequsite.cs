using System;
using UnityEngine;

namespace Gameplay.Entities.Component
{
    public class VictoryPrerequsite : MonoBehaviour, IRecalculated
    {
        [SerializeField] private bool _checked;
        public bool Checked => _checked;

        public void Check() => _checked = true;
        public void Uncheck() => _checked = false;

        public float GetRecalculationPriority() => 9;
        public void Recalculate() => Uncheck();

        private void Awake()
        {
            Level.Instance.Turns.AddRecalculatedEntity(this);
            Level.Instance.Status.AddPrerequisite(this);
        }
    }
}