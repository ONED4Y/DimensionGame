using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDelete: MonoBehaviour {
    // Start is called before the first frame update

    Rigidbody2D myRb;
    void Start()
    {
        Destroy(gameObject, 3F);
    }
    /*
    public void Shoot(float speed) {
        myRb.AddForce(transform.right * speed * Time.deltaTime);
    }*/
    void Update() {
    }
}

