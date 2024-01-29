using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");

        if (forwardPressed && !isWalking)
        {
            animator.SetBool("isWalking", true);
        }
        if(!forwardPressed && isWalking)
        {
            animator.SetBool("isWalking", false);
        }
    }
}
