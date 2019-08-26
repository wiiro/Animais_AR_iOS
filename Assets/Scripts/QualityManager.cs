using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QualityManager : MonoBehaviour
{

    public bool muteMusic = false, muteEffects = false;

    public GameObject avisoM, avisoF;
    public Sprite musicaA, musicaD, efeitoA, efeitoD;

    public void SetLowQuality()
    {
        QualitySettings.SetQualityLevel(1, true);
        print(QualitySettings.GetQualityLevel());
    }

    public void SetHighQuality()
    {
        QualitySettings.SetQualityLevel(0, true);
        print(QualitySettings.GetQualityLevel());
    }

    public void ToggleMusic()
    {
        if(muteMusic == false)
        {
            StaticVariables.volume = 0;
            muteMusic = true;
            avisoM.GetComponent<Image>().sprite = musicaD;
            print("music muted");
        }
        else
        {
            StaticVariables.volume = 0.5f;
            muteMusic = false;
            avisoM.GetComponent<Image>().sprite = musicaA;
            print("music unmuted");
        }
    }

    public void ToggleEffects()
    {
        if (muteEffects == false)
        {
            StaticVariables.effects = 0;
            muteEffects = true;
            avisoF.GetComponent<Image>().sprite = efeitoD;
            print("music muted");
        }
        else
        {
            StaticVariables.effects = 0.5f;
            muteEffects = false;
            avisoF.GetComponent<Image>().sprite = efeitoA;
            print("music unmuted");
        }
    }

}
