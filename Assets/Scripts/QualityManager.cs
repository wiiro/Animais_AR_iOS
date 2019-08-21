using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualityManager : MonoBehaviour
{

    public bool muteMusic = false, muteEffects = false;

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
            print("music muted");
        }
        else
        {
            StaticVariables.volume = 0.5f;
            muteMusic = false;
            print("music unmuted");
        }
    }

    public void ToggleEffects()
    {
        if (muteEffects == false)
        {
            StaticVariables.effects = 0;
            muteEffects = true;
            print("music muted");
        }
        else
        {
            StaticVariables.effects = 0.5f;
            muteEffects = false;
            print("music unmuted");
        }
    }

}
