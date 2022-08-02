using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEngine.Events;
using System;
public class SceneLoader : MonoBehaviour
{
    VideoPlayer _videoPlayer;
    public string name;
    long numberFramesInVideo=1000;
    void Start()
    {
        
        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.url = Application.streamingAssetsPath + "/" + name +".mp4";
        _videoPlayer.Prepare();

        StartCoroutine(qwe());
        //  _videoPlayer.loopPointReached += _videoPlayer_loopPointReached;



    }

   IEnumerator qwe()
    {
        while (true)
        {
            if (_videoPlayer.isPrepared)
            {
                break;
            }
            yield return null;
        }

        _videoPlayer.Play();
        numberFramesInVideo = Convert.ToInt64(_videoPlayer.frameCount);
        print(_videoPlayer.frameCount);
    }
    /*
    private void _videoPlayer_loopPointReached(VideoPlayer source)
    {

        SceneManager.LoadScene(1);
    }
    */
 

    void Update()
    {
        //print(_videoPlayer.frame);

        if (_videoPlayer.frame+4 >= numberFramesInVideo)
        {
            StartCoroutine(LoadScene());
        }

        if (Input.GetKeyUp(KeyCode.Escape) | Input.GetKeyUp(KeyCode.Return))
        { StartCoroutine(LoadScene()); }

    }
    IEnumerator LoadScene()
    {
        yield return null;

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(1);
        asyncOperation.allowSceneActivation = false;
        while (!asyncOperation.isDone)
        {
           // m_Text.text = "Loading progress: " + (asyncOperation.progress * 100) + "%";

            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
