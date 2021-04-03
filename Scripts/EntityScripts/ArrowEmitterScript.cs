using UnityEngine;

public class ArrowEmitterScript: MonoBehaviour {
    private float KeyTimeDown;
    private float CurrentTimeDown;
    private float LoadedTime;
    public GameObject arrow;
    public float speedMultiplier;
    private float speed;
    void Start() {
        
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.I)) {
            KeyTimeDown = Time.time;
        }
        if(Input.GetKeyUp(KeyCode.I)) {
            LoadedTime = Time.time - KeyTimeDown;
            GameObject Arrow = Instantiate(arrow, transform.position, transform.rotation);
            Rigidbody2D rb = Arrow.GetComponent<Rigidbody2D>();
            //Arrow.GetComponent<ArrowScript>.Move();
            //Arrow.GetComponent<ArrowScript>
            /*
            speed = LoadedTime * speedMultiplier;
            
            if(LoadedTime > 1.5F) {
                speed = 1.5F;
            }
            Debug.Log(speed);
            */
            if(LoadedTime <= 1) {
                speed = 50F;
            }
            if(LoadedTime > 1 && LoadedTime <= 2) {
                speed = 100F;
            }
            if(LoadedTime > 2) {
                speed = 500F;
            }
            Debug.Log(speed);
            Debug.Log(LoadedTime);
            Debug.Log(Arrow);
            Debug.Log(rb);
            //rb.velocity = transform.right * speed * Time.deltaTime;
            rb.AddForce(transform.right * speed * Time.deltaTime * speedMultiplier, ForceMode2D.Impulse);
            //Arrow.transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
    }
}
