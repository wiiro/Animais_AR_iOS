using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaranguejoAmareloAnimController : MonoBehaviour
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
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("CaranguejoAmarelo_IdleBake"))
            {
                anim.Play("CaranguejoAmrelo_TouchBake");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("CaranguejoAmrelo_TouchBake"))
            {
                anim.Play("CaranguejoAmarelo_IdleBake");
            }
        }

        if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("CaranguejoAmarelo_IdleBake"))
        {
            anim.Play("CaranguejoAmrelo_TouchBake");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("CaranguejoAmrelo_TouchBake"))
        {
            anim.Play("CaranguejoAmarelo_IdleBake");
        }
    }
}