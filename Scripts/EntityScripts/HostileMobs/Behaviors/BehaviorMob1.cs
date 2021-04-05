using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorMob1: MonoBehaviour {
    private Mob1 Mob = new Mob1();

    void Update() {
        StartCoroutine(Mob.GoToPlayer(gameObject, transform));
        //Mob.GoToPlayer(gameObject, transform);
    }
}
