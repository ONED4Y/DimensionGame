using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobOne: MonoBehaviour {
    public GameObject ExampleMobPrefab;
    void Start() {
        StartCoroutine(RandomMobSpawn());
    }
    IEnumerator RandomMobSpawn() {
        float Spawn = Random.Range(1, 10);
        if(Spawn == 1) {
            ExampleMob Mob = new ExampleMob();
            GameObject MobGO = Instantiate(ExampleMobPrefab, Vector3.zero, transform.rotation);
            StartCoroutine(Mob.GoToPlayer(MobGO, MobGO.transform));
        }
        yield return new WaitForSeconds(.5F);
    }
}
