using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crank : MonoBehaviour
{
    Animator anim;
    public GameObject HidenGR;
    public GameObject HidenBlockMove;
    public GameObject HidenSpikes;
    public GameObject HidenEnem;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
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
            HidenGR.SetActive(true);
            HidenBlockMove.SetActive(true);
            HidenSpikes.SetActive(true);
            HidenEnem.SetActive(true);
        }
    }
}
