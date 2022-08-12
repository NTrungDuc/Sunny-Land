using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public Transform Player;
    public Canvas Move;
    public Canvas Jump;
    public Canvas Crouch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x <= 2)
        {
            Move.gameObject.SetActive(true);
        }else if(Player.transform.position.x > 2)
        {
            Move.gameObject.SetActive(false);
        }
        if (Player.transform.position.x >=6 && Player.transform.position.x < 13)
        {
            Jump.gameObject.SetActive(true);
        }else if(Player.transform.position.x <6 || Player.transform.position.x >= 13.5)
        {
            Jump.gameObject.SetActive(false);
        }
        if(Player.transform.position.x >= 19 && Player.transform.position.x < 28)
        {
            Crouch.gameObject.SetActive(true);
        }else if(Player.transform.position.x < 19 || Player.transform.position.x >= 28)
        {
            Crouch.gameObject.SetActive(false);
        }
    }
}
