using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnoggerScript : MonoBehaviour
{
    public float JDetectPlayerRange;
    public float JAtPlayerRange;
    public LayerMask enemyLayers;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Wuuuaaaah!! Ich LEBE!!");
    }

    // Update is called once per frame
    void Update()
    {
        Transform JplayerTransf = GameObject.Find("Player").transform;
        if(Vector3.Distance(transform.position, JplayerTransf.position) < JDetectPlayerRange && Vector3.Distance(transform.position, JplayerTransf.position) > JAtPlayerRange) {
            Vector3 RoadToPlayer = JplayerTransf.position - transform.position;
            Debug.Log("Ich bin du und du bist ein kek!");
        }
    }
}
