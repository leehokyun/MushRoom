using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AnimationController : MonoBehaviour
{
    private int animationVariable { get; set; }  = 0;

    public static Action animationController;

    private Animator _animator;

    // _animator ¼¼ÆÃ 
    void Awake()
    {
        _animator = GetComponent<Animator>();

        animationController = () => { ChangeAnimation(); };
    }

    public void ChangeAnimation()
    {
        _animator.SetInteger("State", animationVariable);

        animationVariable++;

        if (animationVariable > 2)
        {
            animationVariable = 0;
        }
        Debug.Log(animationVariable);
    }
}