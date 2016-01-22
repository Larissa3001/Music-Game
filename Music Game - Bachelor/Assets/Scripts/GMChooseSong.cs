using UnityEngine;
using System.Collections;

public class GMChooseSong : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (Application.loadedLevelName == "GameModeMusic")
        {

            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 150, 75, 25), "Nr.1"))
            {
                GlobalValues.mode = 1;
                Application.LoadLevel("GameMode");
            }

            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 100, 75, 25), "Nr.2"))
            {
                GlobalValues.mode = 2;
                Application.LoadLevel("GameMode");
            }

            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 50, 75, 25), "Nr.3"))
            {
                GlobalValues.mode = 3;
                Application.LoadLevel("GameMode");
            }

            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 0, 75, 25), "Nr.4"))
            {
                GlobalValues.mode = 4;
                Application.LoadLevel("GameMode");
            }

            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 + 50, 75, 25), "Standard"))
            {
                GlobalValues.mode = 0;
                Application.LoadLevel("GameMode");
            }
            /*if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 50, 75, 25), "Standard"))
            {
                GlobalValues.mode = 0;
                Application.LoadLevel("GameMode");
            }*/
        }
    }
}
