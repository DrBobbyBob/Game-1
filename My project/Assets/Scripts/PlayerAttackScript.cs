using Unity.VisualScripting;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private float nexActionTime = 0f;
    private float delay = .5f;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;

    public GameObject attackpoint;
    public float radius;
    public LayerMask enemies;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && animator.GetBool("isIdleUp") && Time.time > nexActionTime)
        {
            nexActionTime = Time.time + delay;
            animator.SetBool("isSweepUp", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("isSweepUp", false);
        }
        if (Input.GetMouseButton(0) && animator.GetBool("isIdleLeft") && Time.time > nexActionTime)
        {
            nexActionTime = Time.time + delay;
            animator.SetBool("isSweepLeft", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("isSweepLeft", false);
        }
        if (Input.GetMouseButton(0) && animator.GetBool("isIdleRight") && Time.time > nexActionTime)
        {
            nexActionTime = Time.time + delay;
            animator.SetBool("isSweepRight", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("isSweepRight", false);
        }
        if (Input.GetMouseButton(0) && animator.GetBool("isIdleDown") && Time.time > nexActionTime)
        {
            nexActionTime = Time.time + delay;
            animator.SetBool("isSweepDown", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("isSweepDown", false);
        }

        if (Input.GetMouseButton(1) && animator.GetBool("isIdleDown"))
        {
            nexActionTime = Time.time + delay;
            animator.SetBool("isBlockDown", true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("isBlockDown", false);
        }

        if (Input.GetMouseButton(1) && animator.GetBool("isIdleLeft"))
        {
            nexActionTime = Time.time + delay;
            animator.SetBool("isBlockLeft", true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("isBlockLeft", false);
        }
        if (Input.GetMouseButton(1) && animator.GetBool("isIdleRight"))
        {
            nexActionTime = Time.time + delay;
            animator.SetBool("isBlockRight", true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("isBlockRight", false);
        }

        if (Input.GetMouseButton(1) && animator.GetBool("isIdleUp"))
        {
            nexActionTime = Time.time + delay;
            animator.SetBool("isBlockUp", true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("isBlockUp", false);
        }


        if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) && Time.time > nexActionTime)
        {
            nexActionTime = Time.time + delay;
            Debug.Log("Dash");
        }
    }

    public void attack()
    {
        Collider2D[] enemy = Physics2D.OverlapCircleAll(attackpoint.transform.position, radius, enemies);

        foreach (Collider2D enemyGameobject in enemy)
        {
            Debug.Log("Hit");
        }
    }
}
