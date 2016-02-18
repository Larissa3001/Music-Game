﻿using UnityEngine;
using System.Collections;

public class ModeMenu : MonoBehaviour {

    bool freeMode = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {


        //GUI.Box(new Rect(10, Screen.height / 2 - 100, 200, 125), "");

        if (GUI.Button(new Rect((Screen.width / 2) - 75, Screen.height / 2 - 100, 150, 25), "Jukebox"))
        {
            Application.LoadLevel("ChooseSong");
        }
        

        if (GUI.Button(new Rect((Screen.width / 2) - 75, Screen.height / 2 - 65, 150, 25), "Komponist"))
        {
            Application.LoadLevel("MusicMode");
        }

        if (GUI.Button(new Rect((Screen.width / 2) - 75, Screen.height / 2 - 30, 150, 25), "Dirigent"))
        {
            Application.LoadLevel("GameModeMusic");
        }

        if (GUI.Button(new Rect((Screen.width / 2) - 75, Screen.height / 2 + 65, 150, 25), "Back to Menu"))
        {
            Application.LoadLevel("MainMenu");
        }


    }
}
