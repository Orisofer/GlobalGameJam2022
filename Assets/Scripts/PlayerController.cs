using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public float moveSpeed;
    public Rigidbody2D theRB;
    public float jumpForce;
    private SpriteRenderer theSR;

    // Ground Checking For Unlimited jumping
    public bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;

    // adding hang time between platforms (from YOUTUBE TUTURIAL)
    //public float hangTime = .2f;
    //private float hangCounter;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        //anim = GetComponent<Animator>();
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), theRB.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            //AudioManager.instance.PlaySFX(10);
        }
    }
}