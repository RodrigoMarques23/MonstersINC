using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float moveInput;
    public Animator animator;
    public float knockbackSpeed = 250.0f;

    float knockbackTimer;

    private Rigidbody2D rb;
    private bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        if (knockbackTimer <= 0.0f)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

            animator.SetFloat("speed", Mathf.Abs(moveInput));

            if (facingRight == false && moveInput > 0)
            {
                flip();
            }
            else if (facingRight == true && moveInput < 0)
            {
                flip();
            }

            if (knockbackTimer > 0.0f)
            {
                knockbackTimer -= Time.deltaTime;
            }
        }
    }

    public void Knockback( Vector2 hitDirection)
    {
        knockbackTimer = 0.5f;
        rb.velocity = knockbackSpeed * hitDirection;
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if(other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
        }

    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
