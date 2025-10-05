using Unity.VisualScripting;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private float nexActionTime = 0f;
    private float delay = .5f;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
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

        if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) && Time.time > nexActionTime)
        {
            nexActionTime = Time.time + delay;
            Debug.Log("Dash");
        }
    }
}
