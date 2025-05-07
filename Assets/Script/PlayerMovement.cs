using NUnit.Framework.Constraints;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    float inputMovement;
    Rigidbody2D rb2d;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundMask;
    public bool facingRight = true;
    //Vector2 move;
    
    public float groundCheckRadius;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);
        
        inputMovement = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(inputMovement * speed, rb2d.linearVelocity.y);
    }
    void Update()
    {
        //move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"));
        //rb2d.AddForce(move * speed);
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.linearVelocity = Vector2.up * jumpForce;
        }
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;  
    }
}
