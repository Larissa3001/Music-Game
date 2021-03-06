﻿using UnityEngine;
using System.Collections;

public class Scene2FMGUI : MonoBehaviour {

    public Texture tex1;
    public Texture tex2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void resetGame()
    {
        GlobalValues.globalClicksObj1 = 0;
        GlobalValues.globalClicksObj2 = 0;
        GlobalValues.globalClicksObj3 = 0;
        GlobalValues.globalClicksObj4 = 0;
        GlobalValues.globalClicksObj5 = 0;
    }

    void OnGUI()
    {

        if (GUI.Button(new Rect((Screen.width - 45), Screen.height / 64, 40, 40), tex1, "label"))
        {
            Level1Button.LevelButton();

        }

        if (GUI.Button(new Rect((Screen.width - 45), Screen.height /10, 40, 40), tex2, "label"))
        {
            Level2Button.LevelButton();
        }

        GUI.color = Color.white;

        if (GUI.Button(new Rect(Screen.width - 85, Screen.height / 2 + 60, 80, 25), "Neustart"))
        {
            resetGame();
            Application.LoadLevel("Scene2");
        }

        if (GUI.Button(new Rect(Screen.width - 85, Screen.height / 2 + 100, 80, 25), "Menü"))
        {
            resetGame();
            Application.LoadLevel("MainMenu");

        }

    }
}
