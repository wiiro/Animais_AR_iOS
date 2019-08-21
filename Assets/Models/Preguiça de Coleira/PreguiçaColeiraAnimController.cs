using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguiçaColeiraAnimController : MonoBehaviour
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
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Preguica_IdleBake"))
            {
                anim.Play("Preguica_TouchBake");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Preguica_TouchBake"))
            {
                anim.Play("Preguica_IdleBake");
            }
        }

        if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("Preguica_IdleBake"))
        {
            anim.Play("Preguica_TouchBake");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("Preguica_TouchBake"))
        {
            anim.Play("Preguica_IdleBake");
        }
    }
}
