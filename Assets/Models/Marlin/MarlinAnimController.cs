using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarlinAnimController : MonoBehaviour
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
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Marlin_idleBake"))
            {
                anim.Play("Marlin_TouchBake");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Marlin_TouchBake"))
            {
                anim.Play("Marlin_idleBake");
            }
        }

        if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("Marlin_idleBake"))
        {
            anim.Play("Marlin_TouchBake");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("Marlin_TouchBake"))
        {
            anim.Play("Marlin_idleBake");
        }
    }
}
