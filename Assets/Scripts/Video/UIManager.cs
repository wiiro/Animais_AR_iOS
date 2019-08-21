using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Recorder;
using UnityEngine.Animations;
using System.IO;

public class UIManager : MonoBehaviour
{
    public RecordManager recordManager;
    public ScreenRecorder shareRecord;

    public GameObject sharePanel;
    public Animator videoAnimator;

    private bool isRecording = false;
    private bool stoppedRecording = false;

    public GameObject Menu1;
    public GameObject Menu2;

    private string sharePath;

    // Start is called before the first frame update
    void Start()
    {
        videoAnimator.GetComponent<Animator>();
    }
 
    // Update is called once per frame
    void Update()
    {

    }


    public void ToggleRecord()
    {
        if (!isRecording) {
            recordManager.StartRecord();
            isRecording = true;
            videoAnimator.SetBool("start", true);
            HideButtons();
        }

        //if (isRecording == false)
        //{
        //
        //    recordManager.StartRecord();
        //    isRecording = true;
        //
        //    StartCoroutine(ShowButtons());
        //
        //
        //    print("started recording");
        //    videoAnimator.SetBool("start", true);
        //
        //
        //}
        //else
        //{
        //    recordManager.StopRecord();
        //    stoppedRecording = true;
        //    isRecording = false;
        //    print("stopped recording");
        //    videoAnimator.SetBool("start", false);
        //
        //
        //}

    }

    public void FinishRecording () {
        recordManager.StopRecord();
        isRecording = false;
   
        videoAnimator.SetBool("start", false);
      
        ShowButtons();
        //sharePanel.SetActive(true);

    }

    //public void SaveVideoAfter10()
    //{
    //    StartCoroutine(SaveVideoAfter10Routine());
    //}

    //private IEnumerator SaveVideoAfter10Routine()
    //{
    //    yield return new WaitForSeconds(10);
    //    if (stoppedRecording == false)
    //    {
    //        recordManager.StopRecord();
    //        stoppedRecording = true;
    //        isRecording = false;
    //        print("stopped recording");
    //        videoAnimator.SetBool("start", false);
    //
    //        sharePanel.SetActive(true);
    //
    //    }
    //    else
    //    {
    //        StopCoroutine(SaveVideoAfter10Routine());
    //        StartCoroutine(ShowSharePanelAfter10Seconds());
    //    }
    //}

    public void ShareVideo()
    {
        /* 
         * byte[] myVideoByteArray = File.ReadAllBytes(Application.persistentDataPath + "/" + VIDEO_NAME + ".mp4");
         string filePath = Application.persistentDataPath + "/" + VIDEO_NAME + ".mp4";
         File.WriteAllBytes(filePath, myVideoByteArray);

         new NativeShare().AddFile(filePath).SetSubject("Teste Share video ").SetText("Teste de Share do video").Share();

         ShareAndroid("teste de share do video", " ", " ", Application.persistentDataPath + "/" + VIDEO_NAME + ".mp4", null, false, "noChoosertest");

         sharePath =;
         print(sharePath);
         */

        //new NativeShare().SetText(sharePath).Share();
        // File.WriteAllBytes(filePath, sss);

        sharePath = Application.persistentDataPath + recordManager.filePath + "/" + recordManager.fileName + ".mp4";
        new NativeShare().AddFile(sharePath).SetSubject("Bla").SetText("bla bla").Share();
        sharePanel.SetActive(false);
    }

    //private IEnumerator ShowSharePanelAfter10Seconds()
    //{
    //    yield return new WaitForSeconds(2);
    //    if(stoppedRecording == true)
    //    {
    //        ShareVideo();
    //    }
    //}

    private void HideButtons()
    {
        Menu1.SetActive(false);
        Menu2.SetActive(false);
        //Menu1.transform.localScale = new Vector3(0, 0, 0);
        //Menu2.transform.localScale = new Vector3(0, 0, 0);
        //yield return new WaitForSeconds(20);
        //Menu1.transform.localScale = new Vector3(1, 1, 1);
        //Menu2.transform.localScale = new Vector3(1, 1, 1);
    }

    private void ShowButtons () {
        Menu1.SetActive(true);
        Menu2.SetActive(true);
        //Menu1.transform.localScale = new Vector3(1, 1, 1);
        //Menu2.transform.localScale = new Vector3(1, 1, 1);
    }
}

