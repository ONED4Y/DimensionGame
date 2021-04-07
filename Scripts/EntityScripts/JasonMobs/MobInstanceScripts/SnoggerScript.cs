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
    private bool JIsAttacking;

    public Transform JpositionPoint;


    void Start() {
        //Debug.Log("Wuuuaaaah!! Ich LEBE!!");
        JpositionPoint.parent = null;
    }


    IEnumerator WaitForMovement(float Jsec) {
        yield return new WaitForSeconds(Jsec);
        JIsMoving = false;
    }


    IEnumerator WaitForAttack(float Jsec) {
        yield return new WaitForSeconds(Jsec);
        JIsAttacking = false;
    }


    void Update() {
        Transform JplayerTransf = GameObject.Find("Player").transform;
        if(Vector3.Distance(transform.position, JplayerTransf.position) < JDetectPlayerRange && Vector3.Distance(transform.position, JplayerTransf.position) > JAtPlayerRange) {
            JpositionPoint.position = gameObject.transform.position;
            JpositionPoint.parent = gameObject.transform;
            transform.position = Vector3.MoveTowards(transform.position, JplayerTransf.position, JSpeed * Time.deltaTime);
        }else if (Vector3.Distance(transform.position, JplayerTransf.position) < JAtPlayerRange && !JIsAttacking) {
            JpositionPoint.position = gameObject.transform.position;
            JpositionPoint.parent = gameObject.transform;
            JIsAttacking = true;
            StartCoroutine("WaitForAttack", 3);
            JAttackPlayer("A_Melee", JAtPlayerRange, JDamage);
            Debug.Log("Wahhrio");
        } else {
            JpositionPoint.parent = null;
            if(Vector3.Distance(transform.position, JpositionPoint.position) <= JGridDistance * 0.05F && !JIsMoving && Vector3.Distance(transform.position, JplayerTransf.position) > JDetectPlayerRange) {
                JIsMoving = true;
                StartCoroutine("WaitForMovement", 3);
                JpositionPoint.position = JDoRandomMovement(1);
            }
            transform.position = Vector3.MoveTowards(transform.position, JpositionPoint.position, JSpeed * Time.deltaTime);
        }
    }

    
}
