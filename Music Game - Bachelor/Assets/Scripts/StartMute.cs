using UnityEngine;
using System.Collections;

public class StartMute : MonoBehaviour {

    AudioSource audio;

	// Use this for initialization
	void Start () {

        audio = GetComponent<AudioSource>();
        audio.mute = true;
	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
