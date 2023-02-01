using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb;

    void Go(){
        float random = Random.Range(0, 2);
        if(random < 1){
            rb.AddForce(new Vector2(3, -3));
        }
        else{
            rb.AddForce(new Vector2(-3, -3));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("Go", 2);
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.CompareTag("Player")){
            GetComponent<AudioSource>().Play();
            Vector2 vel;
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2) + (col.collider.attachedRigidbody.velocity.y / 3);
            rb.velocity = vel;
        }
    }
}
