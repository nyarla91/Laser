using System.Collections;
using System.Collections.Generic;
using Level.Entity;
using Level.Entity.Component;
using UnityEngine;

public class PuzzleElement : Entity
{
    private LaserReciever _reciever;
    private LaserCaster _caster;

    public LaserReciever Reciever =>  _reciever ?? (_reciever = GetComponent<LaserReciever>());
    public LaserCaster Caster =>  _caster ?? (_caster = GetComponent<LaserCaster>());
}
