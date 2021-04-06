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
    void Start() {
        Debug.Log("Wuuuaaaah!! Ich LEBE!!");
        JpositionPoint.parent = null;
    }
    IEnumerator Wait(float Jsec) {
        yield return new WaitForSeconds(3);
        JIsMoving = false;
    }
    void Update() {
        Transform JplayerTransf = GameObject.Find("Player").transform;
        if(Vector3.Distance(transform.position, JplayerTransf.position) < JDetectPlayerRange && Vector3.Distance(transform.position, JplayerTransf.position) > JAtPlayerRange) {
            JpositionPoint.parent = gameObject.transform;
            transform.position = Vector3.MoveTowards(transform.position, JplayerTransf.position, JSpeed * Time.deltaTime);
        }else {
            JpositionPoint.parent = null;
            if(Vector3.Distance(transform.position, JpositionPoint.position) <= JGridDistance * 0.05F && !JIsMoving) {
                JIsMoving = true;
                StartCoroutine("Wait", 3);
                JpositionPoint.position = JDoRandomMovement(1);
            }
            transform.position = Vector3.MoveTowards(transform.position, JpositionPoint.position, JSpeed * Time.deltaTime);
        }
    }
}
