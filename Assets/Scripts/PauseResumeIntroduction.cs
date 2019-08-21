using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResumeIntroduction : MonoBehaviour
{
    public AudioSource Introduction;


    public void ToggleIntroduction()
    {
        if (Introduction.isPlaying)
            Introduction.Pause();
        else
            Introduction.Play();

    }
}
