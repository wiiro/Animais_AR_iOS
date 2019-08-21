using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif

public class PermissionHandler : MonoBehaviour
{
    const int kDialogWidth = 300;
    const int kDialogHeight = 100;
    private bool windowOpen = true;

    public Recorder.ScreenRecorder sr;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("Accepted") == 0)
        {
            GUI.Label(new Rect(10, 20, kDialogWidth - 20, kDialogHeight - 50), "Please let me use the microphone.");
            GUI.Button(new Rect(10, kDialogHeight - 30, 100, 20), "No");
            if (GUI.Button(new Rect(kDialogWidth - 110, kDialogHeight - 30, 100, 20), "Yes"))
            {
#if PLATFORM_ANDROID
                Permission.RequestUserPermission(AndroidPermission.RECORD_AUDIO.ToString());
                Permission.RequestUserPermission(Permission.Microphone);
                Permission.RequestUserPermission(Permission.Camera);
                Permission.RequestUserPermission(Permission.ExternalStorageWrite);
                Permission.RequestUserPermission(Permission.ExternalStorageRead);

#endif
                PlayerPrefs.SetInt("Accepted", 1);
                windowOpen = false;
            }
        }
    }

   /* void DoMyWindow(int windowID)
    {
        GUI.Label(new Rect(10, 20, kDialogWidth - 20, kDialogHeight - 50), "Please let me use the microphone.");
        GUI.Button(new Rect(10, kDialogHeight - 30, 100, 20), "No");
        if (GUI.Button(new Rect(kDialogWidth - 110, kDialogHeight - 30, 100, 20), "Yes"))
        {
#if PLATFORM_ANDROID
            Permission.RequestUserPermission(AndroidPermission.RECORD_AUDIO.ToString());
            Permission.RequestUserPermission(Permission.Microphone);
            Permission.RequestUserPermission(Permission.Camera);
            Permission.RequestUserPermission(Permission.ExternalStorageWrite);
            Permission.RequestUserPermission(Permission.ExternalStorageRead);

#endif
            windowOpen = false;
        }
    }*/

    void OnGUI()
    {
        if (windowOpen)
        {
            Rect rect = new Rect((Screen.width / 2) - (kDialogWidth / 2), (Screen.height / 2) - (kDialogHeight / 2), kDialogWidth, kDialogHeight);
            //GUI.ModalWindow(0, rect, DoMyWindow, "Permissions Request Dialog");
        }
    }
}

