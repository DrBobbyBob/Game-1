using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private float nexActionTime = 0f;
    private float delay = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && Time.time > nexActionTime)
        {
            nexActionTime = Time.time + delay;
            Debug.Log("Attack");
        }

        if (Input.GetMouseButton(1) && Time.time>nexActionTime)
        {
            nexActionTime = Time.time + delay;
            Debug.Log("Block");
        }

        if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) && Time.time > nexActionTime)                          
        {
            nexActionTime = Time.time + delay;
            Debug.Log("Dash");
        }
    }
}
