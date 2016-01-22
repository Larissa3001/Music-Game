using UnityEngine;
using System.Collections;

public class AudioSave1 : MonoBehaviour {

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

    void Save1()
    {
        obj1 = Object1Test.saveObj;
        obj2 = Object2Test.saveObj;
        obj3 = Object3Test.saveObj;
        obj4 = Object4Test.saveObj;
        obj5 = Object5Test.saveObj;

        if (obj1 != null)
        {
            track1 = obj1.name;
        }
        if (obj2 != null)
        {
            track2 = obj2.name;
        }
        if (obj3 != null)
        {
            track3 = obj3.name;
        }
        if (obj4 != null)
        {
            track4 = obj4.name;
        }
        if (obj5 != null)
        {
            track5 = obj5.name;
        }

        PlayerPrefs.SetString("Save1Song1", track1);
        PlayerPrefs.SetString("Save1Song2", track2);
        PlayerPrefs.SetString("Save1Song3", track3);
        PlayerPrefs.SetString("Save1Song4", track4);
        PlayerPrefs.SetString("Save1Song5", track5);


    }

    void Save2()
    {
        obj1 = Object1Test.saveObj;
        obj2 = Object2Test.saveObj;
        obj3 = Object3Test.saveObj;
        obj4 = Object4Test.saveObj;
        obj5 = Object5Test.saveObj;

        if (obj1 != null)
        {
            track1 = obj1.name;
        }
        if (obj2 != null)
        {
            track2 = obj2.name;
        }
        if (obj3 != null)
        {
            track3 = obj3.name;
        }
        if (obj4 != null)
        {
            track4 = obj4.name;
        }
        if (obj5 != null)
        {
            track5 = obj5.name;
        }

        PlayerPrefs.SetString("Save2Song1", track1);
        PlayerPrefs.SetString("Save2Song2", track2);
        PlayerPrefs.SetString("Save2Song3", track3);
        PlayerPrefs.SetString("Save2Song4", track4);
        PlayerPrefs.SetString("Save2Song5", track5);
    }


    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 80, Screen.height / 2 - 150, 75, 25), "Nr.1"))
        {
            GlobalValues.save = true;
            Save1();
            GlobalValues.save = false;
        }

        if (GUI.Button(new Rect(Screen.width - 80, Screen.height / 2 - 125, 75, 25), "Nr.2"))
        {
            GlobalValues.save = true;
            Save2();
            GlobalValues.save = false;
        }
        
    }
}
