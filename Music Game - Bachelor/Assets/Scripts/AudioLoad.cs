using UnityEngine;
using System.Collections;

public class AudioLoad : MonoBehaviour {

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

            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 200, 75, 25), "Nr.1"))
            {
               
               Application.LoadLevel("MusicGame");
            }

            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 150, 75, 25), "Nr.2"))
            {
               
                Application.LoadLevel("MusicGame");
            }

            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 100, 75, 25), "Nr.3"))
            {
                
                Application.LoadLevel("MusicGame");
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 50, 75, 25), "Nr.4"))
            {
                
                Application.LoadLevel("MusicGame");
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 30, Screen.height / 2 - 50, 75, 25), "Standard"))
            {
                Application.LoadLevel("MusicGame");
            }
        }
    }
}
