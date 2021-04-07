using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorMob1: MonoBehaviour {
    private Mob1 Mob = new Mob1();

    void Start() {
        StartCoroutine(Mob.GoToPlayer(transform, LayerMask.GetMask("Water")));
        Debug.Log("Spawned new mob");
        //Mob.GoToPlayer(gameObject, transform);
    }
}
