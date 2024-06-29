using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicInfo : MonoBehaviour
{
    public GameObject tmpMusicName;
    public GameObject tmpAuthorName;
    private AudioSource audioSource;
    private Animator musicAnimator;
    void Start()
    {
        audioSource = GameObject.Find("Music").GetComponent<AudioSource>();
        musicAnimator=GetComponent<Animator>();
        tmpMusicName.GetComponent<TMP_Text>().SetText(audioSource.clip.name.Split("-")[1]);
        tmpAuthorName.GetComponent<TMP_Text>().SetText(audioSource.clip.name.Split("-")[0]);
        StartCoroutine(musicIntro());

    }
    IEnumerator musicIntro()
    {
        musicAnimator.SetBool("Show", true);
        yield return new WaitForSeconds(3);
        musicAnimator.SetBool("Show", false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
