﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MenuController : MonoBehaviour {

    // Use this for initialization
    
    public GameObject audioOnIcon;
    public GameObject audioOffIcon;

    public Text txtBestScore;
    void Start ()
    {
        SetSoundState();// when starts up calls this method.
        txtBestScore.text = PlayerPrefs.GetFloat("BestScore",0).ToString("0.0");
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
    public void StartGame()
    {
        Application.LoadLevel("jumptutorial2");
    }
    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);

        }
        else
        {
            PlayerPrefs.SetInt("Muted", 1);
            //set player preference to 0.
        }
        SetSoundState();
    }

        private void SetSoundState()
        {
            if (PlayerPrefs.GetInt("Muted",0) == 0)
            {
                AudioListener.volume = 1;
                audioOnIcon.SetActive(true);
                audioOffIcon.SetActive(false);

            }
            else
             {
            AudioListener.volume = 0;
            audioOnIcon.SetActive(false);
            audioOffIcon.SetActive(true);
            }

        }
    
}
