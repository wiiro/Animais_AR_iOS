using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavaloMarinhoAnimController : MonoBehaviour
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
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("CavaloMarinho_IdleBake"))
            {
                anim.Play("CavaloMarinho_TouchBake");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("CavaloMarinho_TouchBake"))
            {
                anim.Play("CavaloMarinho_IdleBake");
            }
        }

        if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("CavaloMarinho_IdleBake"))
        {
            anim.Play("CavaloMarinho_TouchBake");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("CavaloMarinho_TouchBake"))
        {
            anim.Play("CavaloMarinho_IdleBake");
        }
    }
}
