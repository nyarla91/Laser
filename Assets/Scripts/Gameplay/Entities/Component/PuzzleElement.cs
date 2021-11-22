using Gameplay.Entities;
using Gameplay.Entities.Component;

namespace Gameplay.Entities.Component
{
    public class PuzzleElement : Entity
    {
        private LaserReciever _reciever;
        private LaserCaster _caster;

        public LaserReciever Reciever =>  _reciever ?? (_reciever = GetComponent<LaserReciever>());
        public LaserCaster Caster =>  _caster ?? (_caster = GetComponent<LaserCaster>());
    }
}
