using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SharePhoto : MonoBehaviour
{

    private string sharePath;
    private string timeStamp;

    public void SharingPhoto()
    {
        timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "Screenshot" + timeStamp + ".png";

        sharePath = Application.persistentDataPath + "/" + fileName;
        print(sharePath);
        new NativeShare().AddFile(sharePath).SetText(sharePath).Share();
    }
}
