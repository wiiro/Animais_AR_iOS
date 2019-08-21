using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TucanoAnimController : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<Input.touchCount; i++)
        {
            if(Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Toucan_Idle"))
            {
                anim.Play("Toucan_Touch");
            }else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Toucan_Touch"))
            {
                anim.Play("Toucan_Idle");
            }
        }

        if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("Toucan_Idle"))
        {
            anim.Play("Toucan_Touch");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("Toucan_Touch"))
        {
            anim.Play("Toucan_Idle");
        }
    }
}
