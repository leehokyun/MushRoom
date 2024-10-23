using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    // _animator ���� 
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        OnMouseDown();
    }

    void OnMouseDown()
    {

        // animationVariable�� ����
        if (Input.GetMouseButtonDown(0))
        {
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
}