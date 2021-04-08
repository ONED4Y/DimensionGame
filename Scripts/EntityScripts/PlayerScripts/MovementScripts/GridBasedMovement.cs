using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridBasedMovement: MonoBehaviour {

    public float Speed = 3;
    public float GridDistance = 1;
    public Transform positionPoint;
    public LayerMask CollisionLayers;
    // Start is called before the first frame update
    void Start() {
        positionPoint.parent = null;
    }

    // Update is called once per frame
    void Update() {
        if(Vector3.Distance(transform.position, positionPoint.position) <= GridDistance * 0.05F) {
            
            if(!Physics2D.OverlapCircle(positionPoint.position + new Vector3((Convert.ToInt32(Input.GetKey(KeyCode.D)) - Convert.ToInt32(Input.GetKey(KeyCode.A))) * GridDistance, (Convert.ToInt32(Input.GetKey(KeyCode.W)) - Convert.ToInt32(Input.GetKey(KeyCode.S))) * GridDistance, 0), 0.2F, CollisionLayers)) {
                positionPoint.position += new Vector3((Convert.ToInt32(Input.GetKey(KeyCode.D)) - Convert.ToInt32(Input.GetKey(KeyCode.A))) * GridDistance, (Convert.ToInt32(Input.GetKey(KeyCode.W)) - Convert.ToInt32(Input.GetKey(KeyCode.S))) * GridDistance, 0);
            }
            

        }
        transform.position = Vector3.MoveTowards(transform.position, positionPoint.position, Speed * Time.deltaTime);
        //transform.Translate(Vector3.MoveTowards(transform.position, positionPoint.position, Speed * Time.deltaTime));
        if(Input.GetKey(KeyCode.U)) {
            Speed = 0.5F;
        }else {
            Speed = 3;
        }
    
    }
}
