using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArrowDirScript: MonoBehaviour {
    // Start is called before the first frame update
    public int DirY = -1;
    public int DirX = -1;
    public Rigidbody2D rb;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
    /*    if(Input.GetKeyDown(KeyCode.A) && DirY == 1) {
            DirY *= -1;
            Flip(0);
        }
        if(Input.GetKeyDown(KeyCode.D) && DirY == -1) {
            DirY *= -1;
            Flip(0);
        }
        if(Input.GetKeyDown(KeyCode.W) && DirX == -1) {
            DirY *= -1;
            Flip(1);
        }
        if(Input.GetKeyDown(KeyCode.S) && DirX == 1) {
            DirY *= -1;
            Flip(1);
        }
    }
    void Flip(int Axies) {
        switch(Axies){
            case 0: 
                transform.Rotate(0, 180, 0);
                break;
            case 1:
                transform.Rotate(180, 0, 0);
                break;
        }
    }
    */
    Vector2 movement = Vector2.zero;

    movement.x = Convert.ToInt32(Input.GetKey(KeyCode.D)) - Convert.ToInt32(Input.GetKey(KeyCode.A));
    movement.y = Convert.ToInt32(Input.GetKey(KeyCode.W)) - Convert.ToInt32(Input.GetKey(KeyCode.S));

    if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A)) {
        float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
        

    }
}





























