using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMob1: MonoBehaviour {
    public GameObject ExampleMobPrefab;
    void Start() {
        StartCoroutine("RandomMobSpawn");
    }
    IEnumerator RandomMobSpawn() {
        while(true) {
            float Spawn = 1;//Random.Range(1, 10);
            if(Spawn == 1) {
                //ExampleMob Mob = new ExampleMob();
                /*GameObject MobGO = */
                Instantiate(ExampleMobPrefab, Vector3.zero, transform.rotation);
                //StartCoroutine(Mob.GoToPlayer(MobGO, MobGO.transform));
            }
            yield return new WaitForSeconds(10F);
        }
    } // create an own script for each mob so that the coroutine will work
}
