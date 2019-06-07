using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public bool canGoUp = true;
    public bool canGoDown = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*    void OnTriggerStay2D(Collider2D p)
    {
        if (p.tag == "Player" && Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
            p.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            Debug.Log("cliquei");
        }
        else if (p.tag == "Player" && Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            p.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
       
    }*/
}
