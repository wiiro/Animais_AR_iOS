using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadein : MonoBehaviour
{ 
    public Image whiteFade;

    void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(0.0f);
        fadeIn();
    }

    
    void fadeIn()
    {
        whiteFade.CrossFadeAlpha(1, 3, false);
    }
}
