using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementScript: MonoBehaviour {
    // Start is called before the first frame update
    public int speed;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 movement = Vector3.zero;

        movement.x = Convert.ToInt32(Input.GetKey(KeyCode.D)) - Convert.ToInt32(Input.GetKey(KeyCode.A));
        movement.y = Convert.ToInt32(Input.GetKey(KeyCode.W)) - Convert.ToInt32(Input.GetKey(KeyCode.S));

        transform.Translate(movement * Time.deltaTime * speed);
    }
}
