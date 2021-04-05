using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobFeatures {
    /*public static float MoveDir(float MobCoord, float PlayerCoord) {
        if(Mathf.Abs(PlayerCoord - MobCoord) < 1) { return PlayerCoord; }
        MobCoord = Mathf.Round(MobCoord); PlayerCoord = Mathf.Round(PlayerCoord);
        if(MobCoord < PlayerCoord) { return MobCoord + 1F; }
        else if(MobCoord > PlayerCoord) { return MobCoord - 1F; }
        else { return PlayerCoord; }
    }*/
}

public class Mob1: MobFeatures {
    public int Damage = 10;
    public int HP = 50;
    public float Size = 1F;
    public float Speed = 20F;
    public bool IsMelee = true;
    public float playerIsInRange = 1.5F;
    public IEnumerator GoToPlayer(Transform TF) {
        while(true) {
            GameObject Player = GameObject.Find("Player");
            Vector3 PlayerPos = Player.transform.position;
            if(Vector3.Distance(TF.position, PlayerPos) > playerIsInRange/*Diff != new Vector3(0, 0, 0)*/) {
                //Vector3 MoveTo = new Vector3(Mathf.Round(PlayerPos.x), Mathf.Round(PlayerPos.y), 0);
                //MoveTo.x = MoveDir(TF.position.x, PlayerPos.x);
                //MoveTo.y = MoveDir(TF.position.y, PlayerPos.y);
                TF.position = Vector3.MoveTowards(TF.position, PlayerPos, Speed * Time.deltaTime);
                Debug.Log(Speed * Time.deltaTime);
            }
            Debug.Log("B");
            yield return new WaitForSecondsRealtime(.1F);
        }
    }
}