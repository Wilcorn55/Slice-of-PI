using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SettingsMenu : MonoBehaviour
{
    //This will adjust the volume of the music through a slider
    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }


    //Quit game will cause the game to close 
    public void QuitGame()
    {
        Application.Quit();
    }
}
