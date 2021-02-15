using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenService : MonoBehaviour
{
    [Header("Shutter Animator")]
    [SerializeField] Animator animator;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //testing purpose only
        {
            ShutterAction();
        }
    }

    //Make it Controllable from level loader
    void ShutterAction()
    {
        animator.SetTrigger("Start");
    }
}
