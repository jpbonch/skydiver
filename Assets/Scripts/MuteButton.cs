using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private GameObject soundmanager;
    

    void Start()
    {
        soundmanager = GameObject.FindGameObjectWithTag("Music");
        if (PlayerPrefs.GetInt("isMuted", 0) == 1)
        {
            gameObject.GetComponent<Image>().sprite = sprite1;
            soundmanager.GetComponent<AudioSource>().Pause();
        }
    }

    public void ChangeImg()
    {
        
        if(soundmanager.GetComponent<AudioSource>().isPlaying)
        {
            gameObject.GetComponent<Image>().sprite = sprite1;
            soundmanager.GetComponent<AudioSource>().Pause();
            PlayerPrefs.SetInt("isMuted", 1);
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = sprite2;
            soundmanager.GetComponent<AudioSource>().Play();
            PlayerPrefs.SetInt("isMuted", 0);
        }
    }
        
    }
