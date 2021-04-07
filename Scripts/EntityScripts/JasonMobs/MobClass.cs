using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob: MonoBehaviour {
    public int JDamage;
    public int JHp;
    public int JSpeed;
    public LayerMask PlayerLayer;

    public Vector3 JDoRandomMovement(int _Length) {
        int RandDir = Mathf.RoundToInt(Random.Range(0, 4));
        Debug.Log(RandDir);
        return RandDir switch {
            0 => new Vector3(transform.position.x - _Length, transform.position.y, 0),
            1 => new Vector3(transform.position.x + _Length, transform.position.y, 0),
            2 => new Vector3(transform.position.x, transform.position.y - _Length, 0),
            3 => new Vector3(transform.position.x, transform.position.y + _Length, 0),
            _ => Vector3.zero
        };
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