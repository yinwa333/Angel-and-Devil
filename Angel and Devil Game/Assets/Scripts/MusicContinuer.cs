using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicContinuer : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        //This primarily makes it so that whatever object this is attached to, won't disappear if you change scenes.
        //Could particularly be problematic if we had scenes you could go back and forth between?? Not sure.
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
    //From scenes, where you want to play music, call method:
    //GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
   
    //From scenes, where you don't want to play music, call method:
    //GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
}
