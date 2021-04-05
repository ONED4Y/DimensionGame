using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobFeatures {
    public static Vector3 WalkDir(Vector3 CurrentPos, int R) {
        switch(R) {
            case 1:
                return new Vector3(CurrentPos.x + 1, CurrentPos.y, 0);
            case 2:
                return new Vector3(CurrentPos.x - 1, CurrentPos.y, 0);
            case 3:
                return new Vector3(CurrentPos.x, CurrentPos.y + 1, 0);
            case 4:
                return new Vector3(CurrentPos.x, CurrentPos.y - 1, 0);
        }
    }
}

public class Mob1: MobFeatures {
    public int Damage = 10;
    public int HP = 50;
    public float Size = 1F;
    public float Speed = 20F;
    public bool IsMelee = true;
    public float PlayerIsInRange = 1.5F;
    public IEnumerator GoToPlayer(Transform TF) {
        int RandomWalkDir = Mathf.RoundToInt(Random.Range(1, 5));
        float LifeTime = Time.time;

        while(true) {
            GameObject Player = GameObject.Find("Player");
            Vector3 PlayerPos = Player.transform.position;
            float Dist = Vector3.Distance(TF.position, PlayerPos);

            if(Dist > PlayerIsInRange && Dist < 15 && LifeTime > 1.5) {
                TF.position = Vector3.MoveTowards(TF.position, PlayerPos, Speed * Time.deltaTime);
            } else if(Dist >= 15 && LifeTime > 1.5) {
                TF.position = Vector3.MoveTowards(TF.position, WalkDir(TF.position, RandomWalkDir), Speed * Time.deltaTime);
            }

            if(Mathf.Round(Random.Range(1, 6)) == 1) {
                RandomWalkDir = Mathf.RoundToInt(Random.Range(1, 5));
            }
            LifeTime = Time.time;
            yield return new WaitForSecondsRealtime(.1F);
        }
    }
}