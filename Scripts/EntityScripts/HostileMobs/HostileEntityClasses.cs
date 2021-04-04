using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMob {
    public int Damage = 10;
    public int HP = 50;
    public float Size = 1F;
    public float Speed = 1F;
    public bool IsMelee = true;
    public IEnumerator GoToPlayer(GameObject GO, Transform TF) {
        GameObject Player = GameObject.Find("Player");
        Vector3 PlayerPos = Player.transform.position;
        /*
        float xDiff = TF.position.x - PlayerPos.x;
        float yDiff = TF.position.y - PlayerPos.y;
        while(xDiff != 0 && yDiff != 0) {
            TF.position = Vector3.MoveTowards(TF.position, PlayerPos, Speed);
            yield return null;
            Schande über dich dukek!
        }
        */
        Vector3 Diff = TF.position - PlayerPos;
        while(Diff != new Vector3(0, 0, 0)) {
            TF.position = Vector3.MoveTowards(TF.position, PlayerPos, Speed * Time.deltaTime);
            yield return null;
        }
    }
}