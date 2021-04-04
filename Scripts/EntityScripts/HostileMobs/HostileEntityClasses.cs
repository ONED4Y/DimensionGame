using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobFeatures {
    public static int MoveDir(float Diff, float Coord) {
        if(Diff < 0) {
            return Mathf.RoundToInt(Coord + 1);
        }
        return Mathf.RoundToInt(Coord - 1);
    }
}

public class Mob1: MobFeatures {
    public int Damage = 10;
    public int HP = 50;
    public float Size = 1F;
    public float Speed = 80F;
    public bool IsMelee = true;
    public float playerIsInRange = 1.5F;
    public void GoToPlayer(GameObject GO, Transform TF) {
        GameObject Player = GameObject.Find("Player");
        Vector3 PlayerPos = Player.transform.position;
        /*
        float xDiff = TF.position.x - PlayerPos.x;
        float yDiff = TF.position.y - PlayerPos.y;
        !!! DU UNTERMENSCH !!!!!!
        */
        // Vector3 Diff = TF.position - PlayerPos;
        while(Vector3.Distance(TF.position, PlayerPos) > playerIsInRange/*Diff != new Vector3(0, 0, 0)*/) {
            TF.position = Vector3.MoveTowards(TF.position, PlayerPos, Speed * Time.deltaTime);
            /*
            int MoveDirX = MoveDir(xDiff, TF.position.x);
            int MoveDirY = MoveDir(yDiff, TF.position.y);#
            DU UNTERMENSCH!!!!!!
            */
            Debug.Log("At player's location");
            //yield return null;
        }
    }
}