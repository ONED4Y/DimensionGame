using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    public MainPlayerCombatScript MPCS;
    public float Attackrange = 0.5F;
    public LayerMask enemyLayers;
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */
    // Update is called once per frame
    
    void Update()
    {
        if(Input.GetKey(KeyCode.I)) {
            switch(MPCS.SelectedTool) {
                case "Sword":
                    Collider2D[] allHitEnemies = Physics2D.OverlapCircleAll(transform.position, Attackrange, enemyLayers);
                    foreach(Collider2D enemy in allHitEnemies) {
                        Debug.Log("Ich hab " + enemy.name + " getroffen. Nimm ihm Hp ab 1Tag dukek!");
                    }
                    return;
                default:

                    return;
            }
        }
    }
    void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(transform.position, Attackrange); // draws Circle like attack circle
    }
}
