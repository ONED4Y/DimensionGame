using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class HostileMob {
    public int Damage;
    public int HP;
    public bool Melee;
    public float VSize;
    public float HSize;
}

enum AttackType {
    Melee, Ranged, AOE
}