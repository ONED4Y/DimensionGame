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
            Instantiate(ExampleMobPrefab, Vector3.zero, transform.rotation);
            yield return new WaitForSeconds(10F);
        }
    } // create an own script for each mob so that the coroutine will work
}
