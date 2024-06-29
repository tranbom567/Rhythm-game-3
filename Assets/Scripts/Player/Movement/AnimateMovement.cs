using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateMovement : MonoBehaviour
{
    private Animator playerAnimator;
    void Start()
    {
        playerAnimator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
            playerAnimator.SetBool("IsIdle", false);
        else
            playerAnimator.SetBool("IsIdle", true);
    }
}
