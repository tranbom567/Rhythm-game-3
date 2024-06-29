using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMusicSync : MonoBehaviour
{
    private AudioSource music;
    private Vector3 tmpScale;
    void Start()
    {
        music=GameObject.Find("Music").GetComponent<AudioSource>();
        tmpScale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(AudioWAVSync.loudness(music.timeSamples, music.clip));
        this.transform.localScale = Vector3.Lerp(tmpScale, tmpScale * 2, AudioWAVSync.loudness(music.timeSamples, music.clip)*0.2f);
    }
}
