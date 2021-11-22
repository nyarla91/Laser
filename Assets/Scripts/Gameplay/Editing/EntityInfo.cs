using NyarlaEssentials;
using UnityEngine;

namespace Gameplay.Editing
{
    public class EntityInfo : Transformer
    {
        [SerializeField] private string _name;
        [SerializeField] private int _data;
        [SerializeField] private bool _background;
        
        public string Name => _name;
        public int Data
        {
            get => _data;
            set => _data = value;
        }
        public bool Background => _background;
    }
}