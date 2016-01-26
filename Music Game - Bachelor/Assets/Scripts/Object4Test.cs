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
        else if (o12.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o12;
        }
        else if (o13.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o13;
        }
        else if (o14.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o14;
        }
        else if (o15.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o15;
        }
        else if (o16.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o16;
        }
        else if (o17.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o17;
        }
        else if (o18.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o18;
        }
        else if (o19.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o19;
        }




        else if (o21.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o21;
        }
        else if (o22.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o22;
        }
        else if (o23.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o23;
        }
        else if (o24.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o24;
        }
        else if (o25.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o25;
        }
        else if (o26.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o26;
        }
        else if (o27.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o27;
        }
        else if (o28.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o28;
        }
        else if (o29.GetComponent<AudioSource>().mute == false)
        {
            saveObj = o29;
        }
        else
        {
            saveObj = null;
        }
    }
}
