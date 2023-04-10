using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region
    //private bool isJumping = false;
    //private bool isMagic = false;
    //private bool isLifeAnim = false;
    #endregion
    private bool isRunning = false;
    private bool isStanding = true;

    public float singleJumpForce = 5f;
    public float doubleJumpForce = 7.5f;

    private bool canDoubleJump = false;
    private bool isJump = false;
    private Rigidbody rb;
    [SerializeField] private GameObject fireballPrefab;
    public float launchForce = 10f;


    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Stand()
    {
        isStanding = true;
        isRunning = false;
    }

    public void SingleJump()
    {
        if (isJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, singleJumpForce);
            isJump = false;
        }
    }

    public void DoubleJump()
    {
        if (isJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, doubleJumpForce);
            isJump = false;
        }
    }

    void Run()
    {
        isStanding = false;
        isRunning = true;
    }

    void Move(float direction)
    {
        transform.Translate( 0, 0, direction * Time.deltaTime * 5);
    }


    void HandleInput()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move(1);
            Run();
            //Rotation(0.0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move(-1);
            Run();
            //Rotation(180.0f);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            if (canDoubleJump)
                DoubleJump();
            else
                SingleJump();

        }
        else if (Input.GetKey(KeyCode.E))
        {
            //Life();
        }
        else if (Input.GetKey(KeyCode.F))
        {
            FireBullet();
        }
        else
        {
            Stand();
        }
    }

    private void FireBullet()
    {
        Vector3 newLaunchPosition = new Vector3(1, 1, 0);
        Vector3 bulletPos = this.transform.position + newLaunchPosition;
        GameObject fireball = Instantiate(fireballPrefab, bulletPos, Quaternion.identity);
    }

    private void Rotation(float rotation)
    {
        transform.rotation = Quaternion.Euler(0f, rotation, 0f);
    }

    void Update()
    {
        HandleInput();
        //animator.SetBool("isJumping", isJumping);
        animator.SetBool("isRunning", isRunning);
        animator.SetBool("isStanding", isStanding);
        //animator.SetBool("isMagic", isMagic);
        //animator.SetBool("isLifeAnim", isLifeAnim);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJump = true;
        }
    }
}
