﻿using UnityEngine;
using System.Collections;

public class Scene1FMGUI : MonoBehaviour {

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

            GUI.color = Color.white;

            if (GUI.Button(new Rect(585, Screen.height / 2 + 60, 80, 25), "Neustart"))
            {
                resetGame();
                Application.LoadLevel("Scene1");
            }

            if (GUI.Button(new Rect(585, Screen.height / 2 + 100, 80, 25), "Menü"))
            {
                resetGame();
                Application.LoadLevel("MainMenu");

            }

    }
}
