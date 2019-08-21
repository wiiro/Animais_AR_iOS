using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Recorder
{
    [RequireComponent(typeof(ScreenRecorder))]
    public class RecordManager : MonoBehaviour
    {
        ScreenRecorder recorder;
        public string fileName;
        public string filePath;
		private void Start()
		{
            recorder = GetComponent<ScreenRecorder>();
		}		

        public void StartRecord()
        {
            recorder.PrepareRecorder();
            StartCoroutine(DelayCallRecord());
        }
        private IEnumerator DelayCallRecord()
        {
            yield return new WaitForSeconds(0.1f);
            recorder.StartRecording();
        }


        public void StopRecord()
        {
            
            recorder.StopRecording();
            StartCoroutine(DelaySaveVideo());
            filePath = recorder.FilePath;
            
        }
        private IEnumerator DelaySaveVideo()
        {
            yield return new WaitForSeconds(1);
            recorder.SaveVideoToGallery();
            System.DateTime now = System.DateTime.Now;
            fileName = "Video_" + now.Year + "_" + now.Month + "_" + now.Day + "_" + now.Hour + "_" + now.Minute + "_" + now.Second + ".mp4";

        }
    }
}

