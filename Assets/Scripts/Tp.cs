﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
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
    void OnTriggerEnter2D(Collider2D c)// é 'c' mas pode ser qlqr coisa 
    {
        if (c.gameObject.tag == "Teleport")
        {
            transform.position = teleportDestination.position;
            Debug.Log("colider");
        }
    }

} 
