using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    public float speed;
    private Vector2 movements;
    private Rigidbody2D rb;
    private CharacterAnimationController animationController;
    public float boostSpeed;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animationController = GetComponent<CharacterAnimationController>();
    }


    void Update()
    {
        movements = GetInpyt();

        if (GetInpyt().x.Equals(0))
        {
            animationController.Stay(true);
            animationController.MovementRight(false);
            animationController.MovementLeft(false);
        }
        else if (movements.x.Equals(-1))
        {
            animationController.FlipCharacter(false);
            animationController.MovementLeft(true);
            animationController.MovementRight(false);

            animationController.Stay(false);

        }
        else if (movements.x.Equals(1))
        {
            animationController.FlipCharacter(true);
            animationController.MovementRight(true);
            animationController.MovementLeft(false);

            animationController.Stay(false);

        }

        if (Input.GetKey(KeyCode.LeftShift) && GetInpyt().x.Equals(-1) || Input.GetKey(KeyCode.LeftShift) && GetInpyt().x.Equals(1) ||
            Input.GetKey(KeyCode.LeftShift) && GetInpyt().y.Equals(-1) || Input.GetKey(KeyCode.LeftShift) && GetInpyt().y.Equals(1))
        {
            Debug.Log("¬ход в if ");
            BoostSpeed();

        }


    }

    private void FixedUpdate()
    {
        var tempSpeed = speed * boostSpeed;
        rb.MovePosition(rb.position + movements * speed * Time.fixedDeltaTime);
        

        if (Input.GetKey(KeyCode.LeftShift) && GetInpyt().x.Equals(-1) || Input.GetKey(KeyCode.LeftShift) && GetInpyt().x.Equals(1) ||
            Input.GetKey(KeyCode.LeftShift) && GetInpyt().y.Equals(-1) || Input.GetKey(KeyCode.LeftShift) && GetInpyt().y.Equals(1))
        {
            Debug.Log("¬ход в if ");
            //BoostSpeed();
            rb.MovePosition(rb.position + movements * (speed * tempSpeed) * Time.fixedDeltaTime);

        }



    }

    public Vector2 GetInpyt()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    public void BoostSpeed()
    {

        Debug.Log($"¬ход в Boost ");
    }
}