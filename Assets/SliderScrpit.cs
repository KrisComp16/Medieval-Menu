using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SliderScrpit : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider master, music, sfx;


    // Start is called before the first frame update
    void Start()
    {

        Load();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetEffectsVolume(float volume)
    {
        masterMixer.SetFloat("SFXVolume", volume);
        Debug.Log(volume);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        masterMixer.SetFloat("MusicVolume", volume);
        Debug.Log(volume);
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    public void SetMasterVolume(float volume)
    {
        masterMixer.SetFloat("MasterVolume", volume);
        Debug.Log(volume);
        PlayerPrefs.SetFloat("MasterVolume", volume);
    }


    public void Load()
    {

        master.value = PlayerPrefs.GetFloat("MasterVolume");
        music.value = PlayerPrefs.GetFloat("MusicVolume");
        sfx.value = PlayerPrefs.GetFloat("SFXVolume");
    }


}
