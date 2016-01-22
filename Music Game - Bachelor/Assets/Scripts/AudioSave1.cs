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

    AudioSource aud1;
    AudioSource aud2;
    AudioSource aud3;
    AudioSource aud4;
    AudioSource aud5;

    float vol1;
    float vol2;
    float vol3;
    float vol4;
    float vol5;




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
            aud1 = obj1.GetComponent<AudioSource>();
            vol1 = aud1.volume;
            track1 = obj1.name;
            Debug.Log(obj1.name);
            PlayerPrefs.SetString("Save1Song1", track1);
            PlayerPrefs.SetFloat("Save1Song1Vol",vol1);
        }
        else
        {
            vol1 = 0;
            track1 = null;
            PlayerPrefs.SetString("Save1Song1", track1);
            PlayerPrefs.SetFloat("Save1Song1Vol", vol1);
        }

        if (obj2 != null)
        {
            aud2 = obj2.GetComponent<AudioSource>();
            vol2 = aud2.volume;
            track2 = obj2.name;
            Debug.Log(obj2.name);
            PlayerPrefs.SetString("Save1Song2", track2);
            PlayerPrefs.SetFloat("Save1Song2Vol", vol2);
        }
        else
        {
            vol2 = 0;
            track2 = null;
            PlayerPrefs.SetString("Save1Song2", track2);
            PlayerPrefs.SetFloat("Save1Song2Vol", vol2);
        }

        if (obj3 != null)
        {
            aud3 = obj3.GetComponent<AudioSource>();
            vol3 = aud3.volume;
            track3 = obj3.name;
            Debug.Log(obj3.name);
            PlayerPrefs.SetString("Save1Song3", track3);
            PlayerPrefs.SetFloat("Save1Song3Vol", vol3);
        }
        else
        {
            vol3 = 0;
            track3 = null;
            PlayerPrefs.SetString("Save1Song3", track3);
            PlayerPrefs.SetFloat("Save1Song3Vol", vol3);
        }

        if (obj4 != null)
        {
            aud4 = obj4.GetComponent<AudioSource>();
            vol4 = aud4.volume;
            track4 = obj4.name;
            Debug.Log(obj4.name);
            PlayerPrefs.SetString("Save1Song4", track4);
            PlayerPrefs.SetFloat("Save1Song4Vol", vol4);
        }
        else
        {
            vol4 = 0;
            track4 = null;
            PlayerPrefs.SetString("Save1Song4", track4);
            PlayerPrefs.SetFloat("Save1Song4Vol", vol4);
        }

        if (obj5 != null)
        {
            aud5 = obj5.GetComponent<AudioSource>();
            vol5 = aud5.volume;
            track5 = obj5.name;
            Debug.Log(obj5.name);
            PlayerPrefs.SetString("Save1Song5", track5);
            PlayerPrefs.SetFloat("Save1Song5Vol", vol5);
        }
        else
        {
            vol5 = 0;
            track5 = null;
            PlayerPrefs.SetString("Save1Song5", track5);
            PlayerPrefs.SetFloat("Save1Song5Vol", vol5);
        }


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
            aud1 = obj1.GetComponent<AudioSource>();
            vol1 = aud1.volume;
            track1 = obj1.name;
            Debug.Log(obj1.name);
            PlayerPrefs.SetString("Save2Song1", track1);
            PlayerPrefs.SetFloat("Save2Song1Vol", vol1);
        }
        else
        {
            vol1 = 0;
            track1 = null;
            PlayerPrefs.SetString("Save2Song1", track1);
            PlayerPrefs.SetFloat("Save2Song1Vol", vol1);
        }

        if (obj2 != null)
        {
            aud2 = obj2.GetComponent<AudioSource>();
            vol2 = aud2.volume;
            track2 = obj2.name;
            Debug.Log(obj2.name);
            PlayerPrefs.SetString("Save2Song2", track2);
            PlayerPrefs.SetFloat("Save2Song2Vol", vol2);
        }
        else
        {
            vol2 = 0;
            track2 = null;
            PlayerPrefs.SetString("Save2Song2", track2);
            PlayerPrefs.SetFloat("Save2Song2Vol", vol2);
        }

        if (obj3 != null)
        {
            aud3 = obj3.GetComponent<AudioSource>();
            vol3 = aud3.volume;
            track3 = obj3.name;
            Debug.Log(obj3.name);
            PlayerPrefs.SetString("Save2Song3", track3);
            PlayerPrefs.SetFloat("Save2Song3Vol", vol3);
        }
        else
        {
            vol3 = 0;
            track3 = null;
            PlayerPrefs.SetString("Save2Song3", track3);
            PlayerPrefs.SetFloat("Save2Song3Vol", vol3);
        }

        if (obj4 != null)
        {
            aud4 = obj4.GetComponent<AudioSource>();
            vol4 = aud4.volume;
            track4 = obj4.name;
            Debug.Log(obj4.name);
            PlayerPrefs.SetString("Save2Song4", track4);
            PlayerPrefs.SetFloat("Save2Song4Vol", vol4);
        }
        else
        {
            vol4 = 0;
            track4 = null;
            PlayerPrefs.SetString("Save2Song4", track4);
            PlayerPrefs.SetFloat("Save2Song4Vol", vol4);
        }

        if (obj5 != null)
        {
            aud5 = obj5.GetComponent<AudioSource>();
            vol5 = aud5.volume;
            track5 = obj5.name;
            Debug.Log(obj5.name);
            PlayerPrefs.SetString("Save2Song5", track5);
            PlayerPrefs.SetFloat("Save2Song5Vol", vol5);
        }
        else
        {
            vol5 = 0;
            track5 = null;
            PlayerPrefs.SetString("Save2Song5", track5);
            PlayerPrefs.SetFloat("Save2Song5Vol", vol5);
        }
    }


    void OnGUI()
    {
        GUI.color = Color.white;

        if (GUI.Button(new Rect(Screen.width - 45, Screen.height / 2 - 100, 40, 25), "Nr.1"))
        {
            Save1();
        }

        if (GUI.Button(new Rect(Screen.width - 45, Screen.height / 2 -60, 40, 25), "Nr.2"))
        {
            Save2();
        }
    }
}
