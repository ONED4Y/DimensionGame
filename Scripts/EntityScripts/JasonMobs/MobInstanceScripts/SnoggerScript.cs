using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnoggerScript: Mob {
    public float JDetectPlayerRange;
    public float JAtPlayerRange;
    public LayerMask enemyLayers;
    private Vector3 JdirSave;
    public float JGridDistance;
    private bool JIsMoving;
    public Transform JpositionPoint;
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Wuuuaaaah!! Ich LEBE!!");
        JpositionPoint.parent = null;
    }
    IEnumerator Wait(float Jsec) {
        yield return new WaitForSeconds(3);
        JIsMoving = false;
    }
    void JDoStuff() {
        Transform JplayerTransf = GameObject.Find("Player").transform;
        //Debug.Log(Vector3.Distance(transform.position, JplayerTransf.position));
        if(Vector3.Distance(transform.position, JplayerTransf.position) < JDetectPlayerRange && Vector3.Distance(transform.position, JplayerTransf.position) > JAtPlayerRange) {
            JpositionPoint.parent = gameObject.transform;
            Vector3 RoadToPlayer = JplayerTransf.position - transform.position;
            Debug.Log("Ich bin du und du bist ein kek!");
            transform.position = Vector3.MoveTowards(transform.position, JplayerTransf.position, JSpeed * Time.deltaTime);
            //transform.Translate((JplayerTransf.position - transform.position) * Time.deltaTime * JSpeed);
        }
        else {
            JpositionPoint.parent = null;
            if(Vector3.Distance(transform.position, JpositionPoint.position) <= JGridDistance * 0.05F && !JIsMoving) {
                JIsMoving = true;
                StartCoroutine("Wait", 3);
                JpositionPoint.position = JDoRandomMovement(1);
                //StartCoroutine("RandomMovement");
            }
            transform.position = Vector3.MoveTowards(transform.position, JpositionPoint.position, JSpeed * Time.deltaTime);
        }
    }
    void Update() {
        JDoStuff();
    }
}
