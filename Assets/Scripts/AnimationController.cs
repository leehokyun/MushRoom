using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AnimationController : MonoBehaviour
{
    private int animationVariable { get; set; }  = 0;

    public Action animationController; //싱글턴 빼고는 static 안붙인다고 보면 된다.

    private Animator _animator;

    // _animator 세팅 
    void Awake()
    {
        _animator = GetComponent<Animator>();

        //animationController = () => { ChangeAnimation(); };
    }

    public void OnMouseDown()
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