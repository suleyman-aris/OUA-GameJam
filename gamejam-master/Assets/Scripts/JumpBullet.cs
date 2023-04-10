using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBullet : MonoBehaviour
{
    public float jumpForce = 5f; // Zýplama kuvveti
    public float moveSpeed = 2f; // Hareket hýzý
    public float destroyDelay = 3f; // Nesnenin yok olma gecikmesi

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, destroyDelay);
    }

    void Update()
    {
            Vector2 jumpVector = new Vector2(0f, jumpForce);
            rb.velocity += jumpVector;
    }

    void FixedUpdate()
    {
        Vector2 moveVector = new Vector2(moveSpeed, rb.velocity.y);
        rb.velocity = moveVector;
    }

}
