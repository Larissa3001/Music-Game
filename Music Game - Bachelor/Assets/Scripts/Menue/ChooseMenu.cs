using UnityEngine;
using System.Collections;

public class ChooseMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect((Screen.width / 2) - 75, Screen.height / 2 - 65, 150, 25), "Song 1"))
        {
            Application.LoadLevel("Scene1");
        }

        if (GUI.Button(new Rect((Screen.width / 2) - 75, Screen.height / 2 - 25, 150, 25), "Song 2"))
        {
            Application.LoadLevel("Scene2");
        }
    }
}
