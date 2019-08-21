using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TakeScreenshot : MonoBehaviour {

	[SerializeField]
	GameObject blink;

    public static UnityAction onAllowCallback, onDenyCallback, onDenyAndNeverAskAgainCallback;

    public NativeShare NativeShare;


    public void TakeAShot()
	{
		StartCoroutine ("CaptureIt");
        
	}

    public void ShareScreenshot()
    {
        NativeShare.Share();
    }

	IEnumerator CaptureIt()
	{
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		//string pathToSave = fileName;

        // File path
        string folderPath = Application.persistentDataPath + "/../../../../DCIM/ARScreenshots/";
        

        // Create the folder beforehand if not exists
        if (!System.IO.Directory.Exists(folderPath))
            System.IO.Directory.CreateDirectory(folderPath);

        // Capture and store the screenshot
        if (!TakeScreenshot.IsPermitted(AndroidPermission.WRITE_EXTERNAL_STORAGE))//request this permission to write recorded file to disk
        {
            TakeScreenshot.RequestPermission(AndroidPermission.WRITE_EXTERNAL_STORAGE);  
        }
        ScreenCapture.CaptureScreenshot(fileName);
        while (!System.IO.File.Exists(fileName))
            yield return null;
        System.IO.File.Copy(fileName, folderPath + fileName);
        yield return new WaitForEndOfFrame();
		Instantiate (blink, new Vector2(0f, 0f), Quaternion.identity);

        RefreshGallery(Application.persistentDataPath + folderPath + fileName);
    }

    public static void RefreshGallery(string path)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        using(AndroidJavaClass javaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer")){
        javaClass.GetStatic<AndroidJavaObject>("currentActivity").Call("refreshGallery", path);
        }
#endif
    }

    public static bool IsPermitted(AndroidPermission permission)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        using (var androidUtils = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            return androidUtils.GetStatic<AndroidJavaObject>("currentActivity").Call<bool>("hasPermission", GetPermissionStrr(permission));
        }
#endif
        return true;
    }

    public static void RequestPermission(AndroidPermission permission, UnityAction onAllow = null, UnityAction onDeny = null, UnityAction onDenyAndNeverAskAgain = null)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        onAllowCallback = onAllow;
        onDenyCallback = onDeny;
        onDenyAndNeverAskAgainCallback = onDenyAndNeverAskAgain;
        using (var androidUtils = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            androidUtils.GetStatic<AndroidJavaObject>("currentActivity").Call("requestPermission", GetPermissionStrr(permission));
        }
#endif
    }

    private static string GetPermissionStrr(AndroidPermission permission)
    {
        return "android.permission." + permission.ToString();
    }

    private void OnAllow()
    {
        if (onAllowCallback != null)
            onAllowCallback();
        ResetAllCallBacks();
    }
    //this function will be called when the permission has been denied
    private void OnDeny()
    {
        if (onDenyCallback != null)
            onDenyCallback();
        ResetAllCallBacks();
    }

    private void OnDenyAndNeverAskAgain()
    {
        if (onDenyAndNeverAskAgainCallback != null)
            onDenyAndNeverAskAgainCallback();
        ResetAllCallBacks();
    }
    private void ResetAllCallBacks()
    {
        onAllowCallback = null;
        onDenyCallback = null;
        onDenyAndNeverAskAgainCallback = null;
    }

}
