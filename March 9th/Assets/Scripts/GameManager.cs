using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour {

    public GameObject settingsMenu;
    public AudioMixer audioMixer;

    private void Awake()
    {
        // Create Default Player Prefs
        if (!PlayerPrefs.HasKey("masterVol"))
        {
            PlayerPrefs.SetFloat("masterVol", 0f);
        }
    }

    void Start () {
        // Load Player Prefs
        audioMixer.SetFloat("masterVolume", PlayerPrefs.GetFloat("masterVol"));

        settingsMenu.SetActive(false);
    }
	
	void Update () {
		
	}
}
