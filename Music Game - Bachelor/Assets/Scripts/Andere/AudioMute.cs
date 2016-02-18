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

    public static void Mute(string name)
    {

        obj = GameObject.Find(name);

        audio = obj.GetComponent<AudioSource>();

        audio.mute = true;

    }

    public static void Play(string name) {

        Debug.Log(name);


        obj = GameObject.Find(name);

        Debug.Log(obj.name);

        audio = obj.GetComponent<AudioSource>();

        audio.mute = false;
    }
}
