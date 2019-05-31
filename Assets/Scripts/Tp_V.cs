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
        void OnTriggerStay2D(Collider2D d)// é preferivel fazer um overLap, estudar opções.
        {
            if (d.gameObject.tag == "Teleport_V"  && Input.GetKey(KeyCode.W))
            {
                transform.position = teleportDestination.position;
                Debug.Log("colider");
            }
        }

}

