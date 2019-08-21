using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShareRoutine : MonoBehaviour
{
    public GameObject Menu1, Menu2;


    public void ClickShare()
    {
        StartCoroutine(ToogleButtons());
        StartCoroutine(TakeSSAndShare());   
    }

    private IEnumerator TakeSSAndShare()
    {
        yield return new WaitForSeconds(1);
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
        File.WriteAllBytes(filePath, ss.EncodeToPNG());

        // To avoid memory leaks
        Destroy(ss);

        new NativeShare().AddFile(filePath).SetSubject("Aprenda e se divirta você também com os animais da fauna brasileira, baixe o app Affagio RA Eco Animais em: https://bit.ly/2TxUGVQ").SetText("Aprenda e se divirta você também com os animais da fauna brasileira, baixe o app Affagio RA Eco Animais em: https://bit.ly/2TxUGVQ").Share();

        // Share on WhatsApp only, if installed (Android only)
        //if( NativeShare.TargetExists( "com.whatsapp" ) )
        //	new NativeShare().AddFile( filePath ).SetText( "Hello world!" ).SetTarget( "com.whatsapp" ).Share();
    }

    private IEnumerator ToogleButtons()
    {
        Menu1.transform.localScale = new Vector3(0, 0, 0);
        Menu2.transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(3);
        Menu1.transform.localScale = new Vector3(1, 1, 1);
        Menu2.transform.localScale = new Vector3(1, 1, 1);
    }
}
