using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagleRe : MonoBehaviour
{
    Rigidbody2D myBody;
    public float speed = 2f;
    Vector3 vt;
    int h = 1;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        vt = transform.position;
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    void Move()
    {
        if (transform.position.y - vt.y > 3)
        {
            h = -1;
        }
        else if (transform.position.y - vt.y < -3)
        {
            h = 1;
        }
        myBody.velocity = new Vector2(0,h * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            myBody.velocity = new Vector2(0, 0);
            anim.SetBool("death", true);
            Destroy(gameObject, 0.6f);
        }
    }
}
