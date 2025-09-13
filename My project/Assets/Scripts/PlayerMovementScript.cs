using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField]private float speed = 3f;
    [SerializeField]private SpriteRenderer spriteRenderer;
    [SerializeField]private Animator animator;
    public Rigidbody2D body;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(xInput) > 0)
        {
            body.linearVelocity = new Vector2(xInput*speed, body.linearVelocity.y);
        }
        if (Mathf.Abs(yInput) > 0)
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, yInput*speed);
        }

        if (Input.GetKeyDown("w"))
        {
            animator.SetBool("isIdleUp", true);
        }
        else if (Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            animator.SetBool("isIdleUp", false);
        }

        if (Input.GetKeyDown("a"))
        {
            animator.SetBool("isIdleLeft", true);
        }
        else if (Input.GetKeyDown("s") || Input.GetKeyDown("w") || Input.GetKeyDown("d"))
        {
            animator.SetBool("isIdleLeft", false);
        }

        if (Input.GetKeyDown("d"))
        {
            animator.SetBool("isIdleRight", true);
        }
        else if (Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("w"))
        {
            animator.SetBool("isIdleRight", false);
        }

        

        if (yInput < 0)
        {
            animator.SetBool("isRunningDown", true);
        }
        else
        {
            animator.SetBool("isRunningDown", false);
        }
    }
}
