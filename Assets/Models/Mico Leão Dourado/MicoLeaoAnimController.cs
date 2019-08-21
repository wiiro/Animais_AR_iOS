﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicoLeaoAnimController : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("MicoLeao_idle"))
            {
                anim.Play("MicoLeao_touch");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("MicoLeao_touch"))
            {
                anim.Play("MicoLeao_idle");
            }
        }

        if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("MicoLeao_idle"))
        {
            anim.Play("MicoLeao_touch");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("MicoLeao_touch"))
        {
            anim.Play("MicoLeao_idle");
        }
    }
}
