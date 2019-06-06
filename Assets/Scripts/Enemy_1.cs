﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Transform groundSensor;
    [SerializeField] Transform wallSensor;
    [SerializeField] Collider2D damageCollider;

    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();   
    }
  
    void FixedUpdate()
    {
        Vector3 currentVelocity = rigidBody.velocity;

        currentVelocity.x = transform.right.x * moveSpeed;

        rigidBody.velocity = currentVelocity;

        Collider2D groundCollider = Physics2D.OverlapCircle(groundSensor.position, 2.0f, LayerMask.GetMask("ground"));
        if (groundCollider == null)
        {
 //           transform.rotation = transform.rotation * Quaternion.AngleAxis(180.0f, Vector3.up);
        }

        Collider2D wallCollider = Physics2D.OverlapCircle(wallSensor.position, 2.0f, LayerMask.GetMask("ground"));
        if (wallCollider)
        {
            transform.rotation = transform.rotation * Quaternion.AngleAxis(180.0f, Vector3.up);
        }

        if (damageCollider)
        {
            ContactFilter2D filter = new ContactFilter2D();
            filter.ClearLayerMask();
            filter.SetLayerMask(LayerMask.GetMask("player"));

            Collider2D[] results = new Collider2D[4];


            int nCollision = Physics2D.OverlapCollider(damageCollider, filter, results);

            if (nCollision > 0)
            {
                 foreach (var collider in results)
                {
                    if (collider)
                    {
                        Player player = collider.GetComponent<Player>();
                        if (player)
                        {
                            Vector3 hitDirection = player.transform.position - transform.position.normalized;
                            hitDirection.y = 1.0f;
                        }
                    }
                   
                }
            }
        }

    }
}
