using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    // _animator 세팅 
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable을 수정

        if (animationVariable >= 0 && animationVariable < 2)
        {
            animationVariable++;
        }
        else
        {
            animationVariable = 0;
        }
        _animator.SetInteger("State", animationVariable);
    }
}
