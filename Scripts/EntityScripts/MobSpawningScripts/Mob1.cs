using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1: MonoBehaviour {
    public GameObject ExampleMobPrefab;
    void Start() {
        StartCoroutine(RandomMobSpawn());
    }
    IEnumerator RandomMobSpawn() {
        float Spawn = Random.Range(1, 10);
        if(Spawn == 1) {
            ExampleMob mob = new ExampleMob();
            Instantiate(ExampleMobPrefab, Vector3.zero, transform.rotation);
        }
    }
}
