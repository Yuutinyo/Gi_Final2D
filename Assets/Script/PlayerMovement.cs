using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    float inputMovement;
    Rigidbody2D rb;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundMask;
    
    public float groundCheckRadius;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);
        
        inputMovement = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(inputMovement * speed, rb.linearVelocity.y);
    }
    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }
}
