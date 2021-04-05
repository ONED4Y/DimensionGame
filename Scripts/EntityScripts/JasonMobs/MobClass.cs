using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob: MonoBehaviour {
    public int JDamage;
    public int JHp;
    public int JSpeed;

    public Vector3 JDoRandomMovement(int _Speed, int _Length) {
        int RandDir = Mathf.RoundToInt(Random.Range(0, 3));
        switch(RandDir) {
            case 0: 
                //Debug.Log("keek1");
                return Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + _Length, 0, 0), _Speed * Time.deltaTime);
            case 1: 
                //Debug.Log("keek2");
                return Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - _Length, 0, 0), _Speed * Time.deltaTime);
            case 2: 
                //Debug.Log("keek3");
                return Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y + _Length, 0), _Speed * Time.deltaTime);
            case 3: 
                //Debug.Log("keek4");
                return Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y - _Length, 0), _Speed * Time.deltaTime);
            default: return new Vector3(0, 0, 0);
        }
    }
}