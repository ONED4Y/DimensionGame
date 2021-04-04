using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1: MonoBehaviour {
    public GameObject ExampleMobPrefab;
    void Update() {
        StartCoroutine(RandomMobSpawn());
    }
    IEnumerator RandomMobSpawn() {
        float Spawn = Random.Range(1, 100);
        if(Spawn == 1) {
            ExampleMob Mob = new ExampleMob();
            GameObject MobGO = Instantiate(ExampleMobPrefab, Vector3.zero, transform.rotation);
            StartCoroutine(Mob.GoToPlayer(MobGO, MobGO.transform));
            Debug.Log("Mob spawned");
        } else {
            Debug.Log($"Random number was: {Spawn}");
        }
        yield return new WaitForSecondsRealtime(1F);//does not work currently
    } // create an own script for each mob so that the coroutine will work
}
