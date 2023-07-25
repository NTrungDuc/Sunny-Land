using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backFollow : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, 1);
        if (Player.position.x <= 0)
        {
            transform.position = new Vector3(0, Player.transform.position.y, 1);
        }
    }
}
