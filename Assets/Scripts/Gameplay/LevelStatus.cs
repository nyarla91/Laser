using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Entities.Component;
using UnityEngine;

namespace Gameplay
{
    public class LevelStatus : MonoBehaviour
    {
        private List<VictoryPrerequsite> _prerequsites = new List<VictoryPrerequsite>();
        private Action OnVictory;

        public void AddPrerequisite(VictoryPrerequsite prerequsiteToAdd)
        {
            _prerequsites.Add(prerequsiteToAdd);
        }

        public void StartVictoryCheck()
        {
            StartCoroutine(VictoryCheck());
        }

        private IEnumerator VictoryCheck()
        {
            yield return null;
            foreach (var prerequsite in _prerequsites)
            {
                if (!prerequsite.Checked)
                {
                    yield break;
                }
            }
            OnVictory?.Invoke();
        }
    }
}