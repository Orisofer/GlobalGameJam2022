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

    public GameObject fitch;


    // Ground Checking For Unlimited jumping
    public bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;
    private BoxCollider2D boxCollider2D;

    // adding hang time between platforms (from YOUTUBE TUTURIAL)
    public float hangTime = .2f;

    private float hangCounter;

    //animations

    private Animator anim;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        theSR = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        //movement
        theRB.velocity =
            new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"),
                theRB.velocity.y);

        //jumping
        //isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .1f, whatIsGround);

        if (IsGrounded())
        {
            anim.SetBool("isGrounded", true);
            hangCounter = hangTime;
        }
        else
        {
            anim.SetBool("isGrounded", false);
            hangCounter -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (hangCounter > 0f)
            {
                theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                anim.SetTrigger("Jumping");

                //AudioManager.instance.PlaySFX(10);
                hangCounter = 0f;
            }
        }

        //direction change
        Vector3 temp = fitch.transform.localScale;
        if (theRB.velocity.x < 0)
        {
            //print("entering flipX");
            anim.SetBool("isWalking", true);
            temp.x = Mathf.Abs(temp.x);
            theSR.flipX = true;
        }
        else if (theRB.velocity.x > 0)
        {
            //print("entering flipX 2");
            anim.SetBool("isWalking", true);
            temp.x = -Mathf.Abs(temp.x);
            theSR.flipX = false;
        } else if (theRB.velocity.x == 0)
        {
            anim.SetBool("isWalking", false);
        }
        fitch.transform.localScale = temp;
    }

    //ground check
    private bool IsGrounded()
    {
        float extraHeightText = 1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.size, 0f, Vector2.down, extraHeightText, whatIsGround);
        Color raycolor;
        if (raycastHit.collider != null)
        {
            raycolor = Color.green;
        }
        else
        {
            raycolor = Color.red;
        }

        return raycastHit.collider != null;
    }
}
