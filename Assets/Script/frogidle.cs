using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogidle : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

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
