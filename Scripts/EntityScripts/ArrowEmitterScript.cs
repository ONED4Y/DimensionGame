using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowEmitterScript: MonoBehaviour {
    private float KeyTimeDown;
    private float CurrentTimeDown;
    private float LoadedTime;
    public GameObject arrow;
    public float speedMultiplier;
    private float speed;
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
            //Arrow.GetComponent<ArrowScript>
            speed = LoadedTime * speed;
            if(LoadedTime > 3) {
                speed = 3;
            }
            Arrow.transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
    }
}
