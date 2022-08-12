using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : MonoBehaviour
{
    public float idleTime = 0;
    public float speed = 2f;
    public float jumpHeight = 5f;
    Animator anim;
    Rigidbody2D rb;
    Vector3 vt;
    bool grounded;
    int h = 1;
    // Start is called before the first frame update
    void Start()
    {
        vt = transform.position;
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (grounded)
        {
            idleTime += Time.deltaTime;

            
            if (idleTime >= 3)
            {
                if (transform.position.x - vt.x > 2)
                {
                    gameObject.transform.localScale = new Vector3(1, 1, 1);
                    h = -1;
                }
                else if (transform.position.x - vt.x < -2)
                {
                    gameObject.transform.localScale = new Vector3(-1, 1, 1);
                    h = 1;
                }
                grounded = false;
                idleTime = 0;
                anim.SetBool("ground", true);
                rb.velocity = new Vector2(h*speed, jumpHeight);

            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "grounded")
        {
            grounded = true;
            anim.SetBool("ground", false);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.velocity = new Vector2(0, 0);
            anim.SetBool("death", true);
            Destroy(gameObject, 0.6f);
        }
    }
}
