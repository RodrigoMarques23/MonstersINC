using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp_V : MonoBehaviour
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
        void OnTriggerEnter2D(Collider2D d)// é 'c' mas pode ser qlqr coisa 
        {
            if (d.gameObject.tag == "Teleport_V")
            {
                transform.position = teleportDestination.position;
                Debug.Log("colider");
            }
        }

}

