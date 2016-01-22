using UnityEngine;
using System.Collections;

public class AudioSave2 : MonoBehaviour {

    GameObject obj1;
    GameObject obj2;
    GameObject obj3;
    GameObject obj4;
    GameObject obj5;

    string track1;
    string track2;
    string track3;
    string track4;
    string track5;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Save3()
    {
        obj1 = Object1Test.saveObj;
        obj2 = Object2Test.saveObj;
        obj3 = Object3Test.saveObj;
        obj4 = Object4Test.saveObj;
        obj5 = Object5Test.saveObj;

        track1 = obj1.name;
        track1 = obj2.name;
        track1 = obj3.name;
        track1 = obj4.name;
        track1 = obj5.name;

        PlayerPrefs.SetString("Save3Song1", track1);
        PlayerPrefs.SetString("Save3Song2", track1);
        PlayerPrefs.SetString("Save3Song3", track1);
        PlayerPrefs.SetString("Save3Song4", track1);
        PlayerPrefs.SetString("Save3Song5", track1);


    }

    void Save4()
    {
        obj1 = Object1Test.saveObj;
        obj2 = Object2Test.saveObj;
        obj3 = Object3Test.saveObj;
        obj4 = Object4Test.saveObj;
        obj5 = Object5Test.saveObj;

        track1 = obj1.name;
        track1 = obj2.name;
        track1 = obj3.name;
        track1 = obj4.name;
        track1 = obj5.name;

        PlayerPrefs.SetString("Save4Song1", track1);
        PlayerPrefs.SetString("Save4Song2", track1);
        PlayerPrefs.SetString("Save4Song3", track1);
        PlayerPrefs.SetString("Save4Song4", track1);
        PlayerPrefs.SetString("Save4Song5", track1);
    }


    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 80, Screen.height / 2 - 150, 75, 25), "Nr.1"))
        {
            GlobalValues.save = true;
            Save3();
            GlobalValues.save = false;
        }

        if (GUI.Button(new Rect(Screen.width - 80, Screen.height / 2 - 125, 75, 25), "Nr.2"))
        {
            GlobalValues.save = true;
            Save4();
            GlobalValues.save = false;
        }
        
    }
}
