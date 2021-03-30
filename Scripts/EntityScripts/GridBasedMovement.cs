using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridBasedMovement: MonoBehaviour {

    public int Speed = 1;
    public float GridDistance;
    public Transform positionPoint;
    // Start is called before the first frame update
    void Start() {
        positionPoint.parent = null;
    }

    // Update is called once per frame
    void Update() {
        if(Vector3.Distance(transform.position, positionPoint.position) <= GridDistance * 0.05F) {
            
            positionPoint.position += new Vector3((Convert.ToInt32(Input.GetKey(KeyCode.D)) - Convert.ToInt32(Input.GetKey(KeyCode.A))) * GridDistance, (Convert.ToInt32(Input.GetKey(KeyCode.W)) - Convert.ToInt32(Input.GetKey(KeyCode.S))) * GridDistance, 0);

        }
        transform.position = Vector3.MoveTowards(transform.position, positionPoint.position, Speed * Time.deltaTime);
        //transform.Translate(Vector3.MoveTowards(transform.position, positionPoint.position, Speed * Time.deltaTime));
    }
}
