using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript: MonoBehaviour {
    // Start is called before the first frame update
    public int speed;
    // Update is called once per frame
    void Update() {
        transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
    }
}
