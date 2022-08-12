using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    Rigidbody2D myBody;
    public float speed = 2f;
    Vector3 vt;
    public int h = 1;
    // Start is called before the first frame update
    void Start()
    {
        vt = transform.position;
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    void Move()
    {
        if (transform.position.y - vt.y > 6)
        {
            h = -1;
        }
        else if (transform.position.y - vt.y < -6)
        {
            h = 1;
        }
        myBody.velocity = new Vector2(0, h * speed);
    }
}
