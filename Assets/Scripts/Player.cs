using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed;
    public float jumpForce;
    public float moveInput;
    public Animator animator;
    public float knockbackSpeed = 300.0f;

    float knockbackTimer;
    private bool key;

    private Rigidbody2D rb;
    [SerializeField] private Collider2D mainCollider;

    private bool facingRight = true;
    private float gravityScale;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        gravityScale = rb.gravityScale;
    }

    void FixedUpdate() {


        if (knockbackTimer <= 0.0f) {
            moveInput = Input.GetAxis("Horizontal");

            Vector2 currentVelocity = rb.velocity;

            currentVelocity.x = moveInput * speed;

            Ladder ladder = IsOnLadder();
            if (ladder) {
                rb.gravityScale = 0.0f;

                float deltaY = Input.GetAxis("Vertical") * speed;

                if ((!ladder.canGoUp) && (deltaY > 0.0f)) deltaY = 0.0f;
                if ((!ladder.canGoDown) && (deltaY < 0.0f)) deltaY = 0.0f;

                currentVelocity.y = deltaY;
            } else {
                rb.gravityScale = gravityScale;
            }

            rb.velocity = currentVelocity;

            animator.SetFloat("speed", Mathf.Abs(moveInput));

            if (facingRight == false && moveInput > 0) {
                flip();
            } else if (facingRight == true && moveInput < 0) {
                flip();
            }


        } else {

            knockbackTimer -= Time.deltaTime;
        }

    }


    public void Knockback(Vector2 hitDirection) {
        knockbackTimer = 0.5f;
        rb.velocity = knockbackSpeed * hitDirection;
    }

    void flip() {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    Ladder IsOnLadder() {
        ContactFilter2D filter = new ContactFilter2D();
        filter.SetLayerMask(LayerMask.GetMask("ladder"));

        Collider2D[] collisions = new Collider2D[16];

        Collider2D collider = Physics2D.OverlapCircle(transform.position, 5.0f);
        if (collider) {
            Ladder ladder = collider.GetComponent<Ladder>();
            if (ladder) {
                return ladder;
            }
        }
        return null;
    }
}



