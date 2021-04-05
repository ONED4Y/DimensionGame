using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnoggerScript: Mob {
    public float JDetectPlayerRange;
    public float JAtPlayerRange;
    public LayerMask enemyLayers;
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Wuuuaaaah!! Ich LEBE!!");
        while(true) {
            JDoStuff();
        }
    }
    IEnumerator RandomMovement() {
        JDoRandomMovement(2, 1);
        yield return new WaitForSeconds(3);
    }
    void JDoStuff() {
        Transform JplayerTransf = GameObject.Find("Player").transform;
        //Debug.Log(Vector3.Distance(transform.position, JplayerTransf.position));
        if(Vector3.Distance(transform.position, JplayerTransf.position) < JDetectPlayerRange && Vector3.Distance(transform.position, JplayerTransf.position) > JAtPlayerRange) {
            Vector3 RoadToPlayer = JplayerTransf.position - transform.position;
            Debug.Log("Ich bin du und du bist ein kek!");
            transform.position = Vector3.MoveTowards(transform.position, JplayerTransf.position, JSpeed * Time.deltaTime);
            //transform.Translate((JplayerTransf.position - transform.position) * Time.deltaTime * JSpeed);
        }
        else {
            Mathf.RoundToInt(transform.position.x);
            Mathf.RoundToInt(transform.position.y);
            StartCoroutine("RandomMovement");
        }
    }
}
