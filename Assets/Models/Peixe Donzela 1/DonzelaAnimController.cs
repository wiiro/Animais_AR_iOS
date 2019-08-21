using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonzelaAnimController : MonoBehaviour
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
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("PeixeDozela_IdleBake"))
            {
                anim.Play("PeixeDonzela_TouchBake");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("PeixeDonzela_TouchBake"))
            {
                anim.Play("PeixeDozela_IdleBake");
            }
        }

        if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("PeixeDozela_IdleBake"))
        {
            anim.Play("PeixeDonzela_TouchBake");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("PeixeDonzela_TouchBake"))
        {
            anim.Play("PeixeDozela_IdleBake");
        }
    }
}
