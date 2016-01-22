using UnityEngine;
using System.Collections;

public class Object4Test : MonoBehaviour {

    public GameObject o11;
    public GameObject o12;
    public GameObject o13;
    public GameObject o14;
    public GameObject o15;
    public GameObject o16;
    public GameObject o17;
    public GameObject o18;
    public GameObject o19;

    public GameObject o21;
    public GameObject o22;
    public GameObject o23;
    public GameObject o24;
    public GameObject o25;
    public GameObject o26;
    public GameObject o27;
    public GameObject o28;
    public GameObject o29;

    public static GameObject saveObj;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //if(GlobalValues.save == true)
        //{
        MuteTest();
        Debug.Log(saveObj);
        //}

    }

    void MuteTest()
    {
        if (o11.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o11;
        }
        if (o12.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o12;
        }
        if (o13.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o13;
        }
        if (o14.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o14;
        }
        if (o15.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o15;
        }
        if (o16.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o16;
        }
        if (o17.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o17;
        }
        if (o18.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o18;
        }
        if (o19.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o19;
        }




        if (o21.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o21;
        }
        if (o22.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o22;
        }
        if (o23.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o23;
        }
        if (o24.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o24;
        }
        if (o25.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o25;
        }
        if (o26.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o26;
        }
        if (o27.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o27;
        }
        if (o28.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o28;
        }
        if (o29.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o29;
        }
    }
}
