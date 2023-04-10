using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public float lifeTime = 5f;

    private Rigidbody rb;
    private float spawnTime;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnTime = Time.time;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(0,speed, rb.velocity.y);
        if (Time.time - spawnTime >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        Jump();
    }

    void Jump()
    {
        rb.velocity = new Vector3(0, jumpForce, rb.velocity.z);
    }
}
