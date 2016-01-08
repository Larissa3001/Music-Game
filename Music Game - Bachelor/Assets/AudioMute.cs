using UnityEngine;
using System.Collections;

public class AudioMute : MonoBehaviour {

    public static AudioSource audio;
    public static GameObject obj;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void Mute(string tag)
    {

        obj = GameObject.FindGameObjectWithTag(tag);

        audio = obj.GetComponent<AudioSource>();

        audio.mute = true;

    }

    public static void Play(string tag) {

        obj = GameObject.FindGameObjectWithTag(tag);

        audio = obj.GetComponent<AudioSource>();

        audio.mute = false;
    }
}
