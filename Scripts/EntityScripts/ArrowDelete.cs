using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDelete: MonoBehaviour {
    // Start is called before the first frame update

    Rigidbody2D myRb;
    public Animator anim;
    void Start()
    {
        StartCoroutine(Destuction());
    }
    /*
    public void Shoot(float speed) {
        myRb.AddForce(transform.right * speed * Time.deltaTime);
    }*/
    IEnumerator Destuction() { 
        yield return new WaitForSeconds(3F);
        anim.SetBool("OnDestruction", true);
        yield return new WaitForSeconds(5/2/6F);
        Destroy(gameObject);
    }
}

