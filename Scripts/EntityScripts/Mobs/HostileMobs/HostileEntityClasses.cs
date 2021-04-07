using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobFeatures {
    public static Vector3 WalkDir(Vector3 CurrentPos, int R) {
        int MoveDistance = Mathf.RoundToInt(Random.Range(1, 3));
        return R switch {
            1 => new Vector3(CurrentPos.x + MoveDistance, CurrentPos.y, 0),
            2 => new Vector3(CurrentPos.x - MoveDistance, CurrentPos.y, 0),
            3 => new Vector3(CurrentPos.x, CurrentPos.y + MoveDistance, 0),
            4 => new Vector3(CurrentPos.x, CurrentPos.y - MoveDistance, 0),
            _ => CurrentPos
        };
    }
}

public class Mob1: MobFeatures {
    public int Damage = 10;
    public int HP = 50;
    public float Size = 1F;
    public float FastSpeed = 5F;
    public float SlowSpeed = 2F;
    public bool IsMelee = true;
    public float PlayerIsInRange = 1.5F;
    public IEnumerator GoToPlayer(Transform TF, LayerMask CollisionLayer) {
        int RandomWalkDir = Mathf.RoundToInt(Random.Range(1, 5));
        float LifeTime = Time.time;
        Vector3 Destination = WalkDir(TF.position, Mathf.RoundToInt(Random.Range(1, 5)));
        WaitForSecondsRealtime ShouldWalk = new WaitForSecondsRealtime(0);

        while(true) {
            GameObject Player = GameObject.Find("Player");
            Vector3 PlayerPos = Player.transform.position;
            float Dist = Vector3.Distance(TF.position, PlayerPos);

            if(Dist > PlayerIsInRange && Dist < 15 && LifeTime > 1.5) {
                TF.position = Vector3.MoveTowards(TF.position, PlayerPos, FastSpeed * Time.deltaTime);
                ShouldWalk = new WaitForSecondsRealtime(0);
            } else if(Dist >= 15 && LifeTime > 1.5) {
                TF.position = Vector3.MoveTowards(TF.position, Destination, SlowSpeed * Time.deltaTime);
                if(TF.position == Destination) {
                    ShouldWalk = new WaitForSecondsRealtime(3F);
                    //RandomWalkDir = Mathf.RoundToInt(Random.Range(1, 5));
                    Destination = WalkDir(TF.position, Mathf.RoundToInt(Random.Range(1, 5)));
                    while(Physics2D.OverlapCircle(Destination, .2F, CollisionLayer)) {
                    //while(Physics.Raycast(TF.position, Destination, 20.0f, CollisionLayer)) {
                        Destination = WalkDir(TF.position, Mathf.RoundToInt(Random.Range(1, 5)));
                        Debug.Log("Mob1 is trying to run into a wall");
                    }
                } else {
                    ShouldWalk = new WaitForSecondsRealtime(0);
                }
            }

            LifeTime = Time.time;
            yield return ShouldWalk;
        }
    }
}