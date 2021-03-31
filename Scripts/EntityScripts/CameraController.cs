using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cam;
    public Transform Up;
    public Transform Down;
    public Transform Left;
    public Transform Right;
    public int Speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if(Input.GetKey(KeyCode.W)){
            cam.position = Vector3.MoveTowards(cam.position, Up.position, Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            cam.position = Vector3.MoveTowards(cam.position, Left.position, Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            cam.position = Vector3.MoveTowards(cam.position, Down.position, Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            cam.position = Vector3.MoveTowards(cam.position, Right.position, Speed * Time.deltaTime);
        }

    }
}
