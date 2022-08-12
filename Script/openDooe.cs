using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDooe : MonoBehaviour
{
    Animator anim;
    public GameObject mapHiden;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("up", true);
            mapHiden.SetActive(false);
        }
    }
}
