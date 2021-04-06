using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob: MonoBehaviour {
    public int JDamage;
    public int JHp;
    public int JSpeed;
    public LayerMask PlayerLayer;

    public Vector3 JDoRandomMovement(int _Length) {
        int RandDir = Mathf.RoundToInt(Random.Range(0, 3));
        Debug.Log(RandDir);
        switch(RandDir) {
            case 0: 
                //Debug.Log("keek1");
                return new Vector3(transform.position.x - _Length, transform.position.y, 0);//Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + _Length, transform.position.y, transform.position.z), _Speed);
            case 1: 
                //Debug.Log("keek2");
                return new Vector3(transform.position.x + _Length, transform.position.y, 0);
            case 2: 
                //Debug.Log("keek3");
                return new Vector3(transform.position.x, transform.position.y - _Length, 0);
            case 3: 
                //Debug.Log("keek4");
                return new Vector3(transform.position.x, transform.position.y + _Length, 0);
            default: return new Vector3(0, 0, 0);
        }
    }
    public void JAttackPlayer(string aAttackType, float aRange, int aDamage) {
        if(aAttackType == "A_Melee") { //Attack_Melee
            Collider2D[] Jplayer = Physics2D.OverlapCircleAll(transform.position, aRange, PlayerLayer);
            foreach(Collider2D APlayer in Jplayer) {
                //HealthScript JHealthScript = APlayer.GetComponent<HealthScript>;
                //JhealthScript.GetDamage(aDamage);
                Debug.Log(APlayer + "gets damage!");
            }
        }
    }
}