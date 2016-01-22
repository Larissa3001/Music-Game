using UnityEngine;
using System.Collections;

public class StartMute : MonoBehaviour {

    AudioSource audio;

	// Use this for initialization
	void Start () {

        if (Application.loadedLevelName == "GameMode")
        {
            audio = GetComponent<AudioSource>();
            audio.mute = false;
            Destroy(this);
        }
        else {
            audio = GetComponent<AudioSource>();
            audio.mute = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
