using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallGR : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            rb.AddForce(Vector2.down * 1f);
            Destroy(gameObject, 0.2f);
        }
    }
}
