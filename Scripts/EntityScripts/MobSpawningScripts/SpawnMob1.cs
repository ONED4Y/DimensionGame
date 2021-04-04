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
            float Spawn = Random.Range(1, 10);
            if(Spawn == 1) {
                //ExampleMob Mob = new ExampleMob();
                /*GameObject MobGO = */
                Instantiate(ExampleMobPrefab, Vector3.zero, transform.rotation);
                //StartCoroutine(Mob.GoToPlayer(MobGO, MobGO.transform));
                Debug.Log("Mob spawned");
            } else {
                Debug.Log($"Random number was: {Spawn}");
            }
            yield return new WaitForSecondsRealtime(1F);
        }
        //does not work currently
    } // create an own script for each mob so that the coroutine will work
}
