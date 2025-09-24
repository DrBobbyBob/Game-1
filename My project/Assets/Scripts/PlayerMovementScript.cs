using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

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
        float xInput = UnityEngine.Input.GetAxis("Horizontal");
        float yInput = UnityEngine.Input.GetAxis("Vertical");

        if (Mathf.Abs(xInput) > 0)
        {
            body.linearVelocity = new Vector2(xInput*speed, body.linearVelocity.y);
        }
        if (Mathf.Abs(yInput) > 0)
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, yInput*speed);
        }


        idle();

        move(yInput, xInput);
    }

    void move(float yInput, float xInput)
    {
        if (yInput < 0)
        {
            animator.SetBool("isRunningDown", true);
        }
        else
        {
            animator.SetBool("isRunningDown", false);
        }

        if (yInput > 0)
        {
            animator.SetBool("isRunningUp", true);
        }
        else
        {
            animator.SetBool("isRunningUp", false);
        }

        if (xInput > 0)
        {
            animator.SetBool("isRunningRight", true);
        }
        else
        {
            animator.SetBool("isRunningRight", false);
        }

        if (xInput < 0)
        {
            animator.SetBool("isRunningLeft", true);
        }
        else
        {
            animator.SetBool("isRunningLeft", false);
        }
    }

    void idle()
    {
        if (UnityEngine.Input.GetKeyDown("w"))
        {
            animator.SetBool("isIdleUp", true);
        }
        else if (UnityEngine.Input.GetKeyDown("s") || UnityEngine.Input.GetKeyDown("a") || UnityEngine.Input.GetKeyDown("d"))
        {
            animator.SetBool("isIdleUp", false);
        }

        if (UnityEngine.Input.GetKeyDown("a"))
        {
            animator.SetBool("isIdleLeft", true);
        }
        else if (UnityEngine.Input.GetKeyDown("s") || UnityEngine.Input.GetKeyDown("w") || UnityEngine.Input.GetKeyDown("d"))
        {
            animator.SetBool("isIdleLeft", false);
        }

        if (UnityEngine.Input.GetKeyDown("d"))
        {
            animator.SetBool("isIdleRight", true);
        }
        else if (UnityEngine.Input.GetKeyDown("s") || UnityEngine.Input.GetKeyDown("a") || UnityEngine.Input.GetKeyDown("w"))
        {
            animator.SetBool("isIdleRight", false);
        }

        if (UnityEngine.Input.GetKeyDown("s"))
        {
            animator.SetBool("isIdleDown", true);
        }
        else if (UnityEngine.Input.GetKeyDown("a") || UnityEngine.Input.GetKeyDown("d") || UnityEngine.Input.GetKeyDown("w"))
        {
            animator.SetBool("isIdleDown", false);
        }
    }
}
