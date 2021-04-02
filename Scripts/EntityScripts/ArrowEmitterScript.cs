using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowEmitterScript: MonoBehaviour {
    private float KeyTimeDown;
    private float CurrentTimeDown;
    private float LoadedTime;
    public GameObject arrow;
    void Start() {
        
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.I)) {
            KeyTimeDown = Time.time;
        }
        if(Input.GetKeyUp(KeyCode.I)) {
            LoadedTime = Time.time - KeyTimeDown;
            GameObject Arrow = Instantiate(arrow, transform.position, Quaternion.identity);
            //Arrow.GetComponent<ArrowScript>.Move();
            ArrowScript as = Arrow.GetComponent<ArrowScript>;
        }
        
    }
}
