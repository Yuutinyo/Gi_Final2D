using UnityEngine;

public class SlimeAi : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb2d;
    private Animator anim;
    private Transform currentPoint;
    public float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        //anim.SetBool("isRunning", true);

        
        
    }
    
    void Update()
    {
        Vector2 point = currentPoint.position- transform.position;
        if (currentPoint == pointB.transform)
        {
            rb2d.linearVelocity = new Vector2(speed, 0);
        }
        else
        {
            rb2d.linearVelocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        }
    }
}
