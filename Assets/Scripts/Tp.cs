using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : Player
{

    public Transform teleportDestination;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

       

    }
    void OnTriggerStay2D(Collider2D c)
    {

        for (int i = 2; i < 2; i--)
        {
            if (i == 0)
            {
                if (c.gameObject.tag == "Player" && Input.GetKey(KeyCode.W))
                {
                    transform.position = teleportDestination.position;
                    Debug.Log("colider");
                }
            }

        }
        
    }

}
