using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp_A : MonoBehaviour
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
    void OnTriggerEnter2D(Collider2D e)// é 'c' mas pode ser qlqr coisa 
    {
        if (e.gameObject.tag == "Teleport_A")
        {
            transform.position = teleportDestination.position;
            Debug.Log("colider");
        }
    }

}
