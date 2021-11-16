using Level.Entities;
using Level.Entities.Component;

namespace Level.Entities.Component
{
    public class PuzzleElement : Entity
    {
        private LaserReciever _reciever;
        private LaserCaster _caster;

        public LaserReciever Reciever =>  _reciever ?? (_reciever = GetComponent<LaserReciever>());
        public LaserCaster Caster =>  _caster ?? (_caster = GetComponent<LaserCaster>());
    }
}
