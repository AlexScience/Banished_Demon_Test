using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    public float speed;
    private Vector2 movements;
    private Animation anim;


    private Rigidbody2D rb;
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movements.x = Input.GetAxisRaw("");
        movements.y = Input.GetAxisRaw("Vertical");

        


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movements * speed * Time.fixedDeltaTime);
        
        
    }
}
