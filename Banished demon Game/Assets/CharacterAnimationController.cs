using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{

    public Animator characterAnimation;
    public SpriteRenderer[] characterSpriteRenderer;
    public MotionController motionController;


    private void Awake()
    {
        characterAnimation = GetComponent<Animator>();
        motionController = GetComponent<MotionController>();
    }
    public void FlipCharacter(bool isFlipX)
    {
        for (int i = 0; i < characterSpriteRenderer.Length; i++)
        {

            characterSpriteRenderer[i].flipX = isFlipX;

        }
    }

    public void Stay(bool isStay)
    {
        characterAnimation.SetBool("idle", isStay);
    }

    public void MovementLeft (bool isLeft)
    {
        characterAnimation.SetBool("IsMovementsLeft", isLeft);

    }
    public void MovementRight(bool isRight)
    {
        characterAnimation.SetBool("IsMovementsRight", isRight);

    }
}
