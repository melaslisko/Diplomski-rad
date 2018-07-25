using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class TutorialVideoPlayer : MonoBehaviour
{

    public RawImage image;

    public VideoClip videoToPlay;

    //public bool isCorrect;
    private VideoPlayer videoPlayer;
    private VideoSource videoSource;

    //private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        Application.runInBackground = true;
        
        //StartCoroutine(playVideo());
    }
    private void OnEnable()
    {
        
        StartCoroutine(playVideo());
    }
    private void OnDisable()
    {
        StopCoroutine(playVideo());
    }

    IEnumerator playVideo()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.playOnAwake = true;
        videoPlayer.isLooping = true;
        videoPlayer.waitForFirstFrame = false;


        /*if (Application.platform == RuntimePlatform.WebGLPlayer && isCorrect == true)
        {
            // Vide clip from Url
            videoPlayer.source = VideoSource.Url;
            videoPlayer.url = "https://s3-us-west-2.amazonaws.com/converterpoint-22/encodings/612375e29ab111dce874ec2ad1fee788.mp4";
        }
        else if (Application.platform == RuntimePlatform.WebGLPlayer && isCorrect == false)
        {
            videoPlayer.source = VideoSource.Url;
            videoPlayer.url = "https://s3-us-west-2.amazonaws.com/converterpoint-22/encodings/b90abed10c8e293dea0e4de2e4cbdbef.mp4";
        } else if (Application.platform != RuntimePlatform.WebGLPlayer)
        {*/
        //We want to play from video clip not from url

        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videoToPlay;

        // }


        //Set Audio Output to AudioSource
        //videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

        //Assign the Audio from Video to AudioSource to be played
        //videoPlayer.EnableAudioTrack(0, true);
        //videoPlayer.SetTargetAudioSource(0, audioSource);

        //Set video To Play then prepare Audio to prevent Buffering
        videoPlayer.Prepare();

        //Wait until video is prepared
        WaitForSeconds waitTime = new WaitForSeconds(0);
        while (!videoPlayer.isPrepared)
        {
            //Debug.Log("Preparing Video");
            //Prepare/Wait for 5 sceonds only
            yield return waitTime;
        }

        //Assign the Texture from Video to RawImage to be displayed
        image.texture = videoPlayer.texture;

        //Play Video
        videoPlayer.Play();
        //Play Sound
        //audioSource.Play();

        while (videoPlayer.isPlaying)
        {

             yield return null;
            
        }


    }
}



