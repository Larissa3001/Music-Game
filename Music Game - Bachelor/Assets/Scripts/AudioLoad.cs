using UnityEngine;
using System.Collections;

public class AudioLoad : MonoBehaviour {

    GameObject eins;
    GameObject zwei;
    GameObject drei;
    GameObject vier;
    GameObject fünf;

    public GameObject E;
    public GameObject Z;
    public GameObject D;
    public GameObject V;
    public GameObject F;

    int loadMode;
    bool start = false;
    

	// Use this for initialization
	void Start () {

        E.GetComponent<AudioSource>().mute = true;
        Z.GetComponent<AudioSource>().mute = true;
        D.GetComponent<AudioSource>().mute = true;
        V.GetComponent<AudioSource>().mute = true;
        F.GetComponent<AudioSource>().mute = true;


        //Debug.Log("Modus " + loadMode);

        loadMode = GlobalValues.mode;

        if (loadMode == 0)
        {
             LoadStandard();

        }
        if (loadMode == 1)
        {
            Load1();


        }
        if (loadMode == 2)
        {
            Load2();


        }
        if (loadMode == 3)
        {
           Load3();


        }
        if (loadMode == 4)
        {
            Load4();

        }
    }
	
	// Update is called once per frame
	void Update () {

    }

    void LoadStandard()
    {

        E.GetComponent<AudioSource>().mute = false;
        Z.GetComponent<AudioSource>().mute = false;
        D.GetComponent<AudioSource>().mute = false;
        V.GetComponent<AudioSource>().mute = false;
        F.GetComponent<AudioSource>().mute = false;

        GlobalValues.GMaS1 = E.name;
        GlobalValues.GMaS2 = Z.name;
        GlobalValues.GMaS3 = D.name;
        GlobalValues.GMaS4 = V.name;
        GlobalValues.GMaS5 = F.name;

    }

    void Load1()
    {
        if (!start)
        {
            string objn1 = PlayerPrefs.GetString("Save1Song1");
            float vol1 = PlayerPrefs.GetFloat("Save1Song1Vol");

            print(objn1);

            if (objn1 != null)
            {
                eins = Instantiate(Resources.Load(objn1, typeof(GameObject))) as GameObject;
                eins.name = objn1;
                eins.GetComponent<AudioSource>().volume = vol1;
                eins.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS1 = objn1;


            }
            else
            {
                eins = null;
            }

            string objn2 = PlayerPrefs.GetString("Save1Song2");
            float vol2 = PlayerPrefs.GetFloat("Save1Song2Vol");

            print(objn2);
            if (objn2 != null)
            {
                zwei = Instantiate(Resources.Load(objn2, typeof(GameObject))) as GameObject;
                zwei.name = objn2;
                zwei.GetComponent<AudioSource>().volume = vol2;
                zwei.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS2 = objn2;
            }
            else
            {
                zwei = null;
            }

            string objn3 = PlayerPrefs.GetString("Save1Song3");
            float vol3 = PlayerPrefs.GetFloat("Save1Song3Vol");
            print(objn3);
            if (objn3 != null)
            {
                drei = Instantiate(Resources.Load(objn3, typeof(GameObject))) as GameObject;
                drei.name = objn3;
                drei.GetComponent<AudioSource>().volume = vol3;
                drei.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS3 = objn3;
            }
            else
            {
                drei = null;
            }

            string objn4 = PlayerPrefs.GetString("Save1Song4");
            float vol4 = PlayerPrefs.GetFloat("Save1Song4Vol");
            print(objn4);
            if (objn4 != null)
            {
                vier = Instantiate(Resources.Load(objn4, typeof(GameObject))) as GameObject;
                vier.name = objn4;
                vier.GetComponent<AudioSource>().volume = vol4;
                vier.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS4 = objn4;
            }
            else
            {
                vier = null;
            }

            string objn5 = PlayerPrefs.GetString("Save1Song5");
            float vol5 = PlayerPrefs.GetFloat("Save1Song5Vol");
            print(objn5);
            if (objn5 != null)
            {
                fünf = Instantiate(Resources.Load(objn5, typeof(GameObject))) as GameObject;
                fünf.name = objn5;
                fünf.GetComponent<AudioSource>().volume = vol5;
                fünf.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS5 = objn5;
            }
            else
            {
                fünf = null;
            }
        }
        start = true;

        //GameObject spawnOb = Instantiate(Resources.Load(spawnObject, typeof(GameObject))) as GameObject;
        //PlayerPrefs.SetString("Save1Song1", track1);
        //PlayerPrefs.SetFloat("Save1Song1Vol", vol1);
    }

    void Load2()
    {
        if (!start)
        {
            string objn1 = PlayerPrefs.GetString("Save2Song1");
            float vol1 = PlayerPrefs.GetFloat("Save2Song1Vol");

            print(objn1);

            if (objn1 != null)
            {
                eins = Instantiate(Resources.Load(objn1, typeof(GameObject))) as GameObject;
                eins.name = objn1;
                eins.GetComponent<AudioSource>().volume = vol1;
                eins.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS1 = objn1;


            }
            else
            {
                eins = null;
            }

            string objn2 = PlayerPrefs.GetString("Save2Song2");
            float vol2 = PlayerPrefs.GetFloat("Save2Song2Vol");

            print(objn2);
            if (objn2 != null)
            {
                zwei = Instantiate(Resources.Load(objn2, typeof(GameObject))) as GameObject;
                zwei.name = objn2;
                zwei.GetComponent<AudioSource>().volume = vol2;
                zwei.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS2 = objn2;
            }
            else
            {
                zwei = null;
            }

            string objn3 = PlayerPrefs.GetString("Save2Song3");
            float vol3 = PlayerPrefs.GetFloat("Save2Song3Vol");
            print(objn3);
            if (objn3 != null)
            {
                drei = Instantiate(Resources.Load(objn3, typeof(GameObject))) as GameObject;
                drei.name = objn3;
                drei.GetComponent<AudioSource>().volume = vol3;
                drei.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS3 = objn3;
            }
            else
            {
                drei = null;
            }

            string objn4 = PlayerPrefs.GetString("Save2Song4");
            float vol4 = PlayerPrefs.GetFloat("Save2Song4Vol");
            print(objn4);
            if (objn4 != null)
            {
                vier = Instantiate(Resources.Load(objn4, typeof(GameObject))) as GameObject;
                vier.name = objn4;
                vier.GetComponent<AudioSource>().volume = vol4;
                vier.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS4 = objn4;
            }
            else
            {
                vier = null;
            }

            string objn5 = PlayerPrefs.GetString("Save2Song5");
            float vol5 = PlayerPrefs.GetFloat("Save2Song5Vol");
            print(objn5);
            if (objn5 != null)
            {
                fünf = Instantiate(Resources.Load(objn5, typeof(GameObject))) as GameObject;
                fünf.name = objn5;
                fünf.GetComponent<AudioSource>().volume = vol5;
                fünf.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS5 = objn5;
            }
            else
            {
                fünf = null;
            }
        }
        start = true;
    } 

    void Load3()
    {
        if (!start)
        {
            string objn1 = PlayerPrefs.GetString("Save3Song1");
            float vol1 = PlayerPrefs.GetFloat("Save3Song1Vol");

            print(objn1);

            if (objn1 != null)
            {
                eins = Instantiate(Resources.Load(objn1, typeof(GameObject))) as GameObject;
                eins.name = objn1;
                eins.GetComponent<AudioSource>().volume = vol1;
                eins.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS1 = objn1;


            }
            else
            {
                eins = null;
            }

            string objn2 = PlayerPrefs.GetString("Save3Song2");
            float vol2 = PlayerPrefs.GetFloat("Save3Song2Vol");

            print(objn2);
            if (objn2 != null)
            {
                zwei = Instantiate(Resources.Load(objn2, typeof(GameObject))) as GameObject;
                zwei.name = objn2;
                zwei.GetComponent<AudioSource>().volume = vol2;
                zwei.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS2 = objn2;
            }
            else
            {
                zwei = null;
            }

            string objn3 = PlayerPrefs.GetString("Save3Song3");
            float vol3 = PlayerPrefs.GetFloat("Save3Song3Vol");
            print(objn3);
            if (objn3 != null)
            {
                drei = Instantiate(Resources.Load(objn3, typeof(GameObject))) as GameObject;
                drei.name = objn3;
                drei.GetComponent<AudioSource>().volume = vol3;
                drei.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS3 = objn3;
            }
            else
            {
                drei = null;
            }

            string objn4 = PlayerPrefs.GetString("Save3Song4");
            float vol4 = PlayerPrefs.GetFloat("Save3Song4Vol");
            print(objn4);
            if (objn4 != null)
            {
                vier = Instantiate(Resources.Load(objn4, typeof(GameObject))) as GameObject;
                vier.name = objn4;
                vier.GetComponent<AudioSource>().volume = vol4;
                vier.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS4 = objn4;
            }
            else
            {
                vier = null;
            }

            string objn5 = PlayerPrefs.GetString("Save3Song5");
            float vol5 = PlayerPrefs.GetFloat("Save3Song5Vol");
            print(objn5);
            if (objn5 != null)
            {
                fünf = Instantiate(Resources.Load(objn5, typeof(GameObject))) as GameObject;
                fünf.name = objn5;
                fünf.GetComponent<AudioSource>().volume = vol5;
                fünf.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS5 = objn5;
            }
            else
            {
                fünf = null;
            }
        }
        start = true;
    }

    void Load4()
    {
        if (!start)
        {
            string objn1 = PlayerPrefs.GetString("Save4Song1");
            float vol1 = PlayerPrefs.GetFloat("Save4Song1Vol");

            print(objn1);

            if (objn1 != null)
            {
                eins = Instantiate(Resources.Load(objn1, typeof(GameObject))) as GameObject;
                eins.name = objn1;
                eins.GetComponent<AudioSource>().volume = vol1;
                eins.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS1 = objn1;


            }
            else
            {
                eins = null;
            }

            string objn2 = PlayerPrefs.GetString("Save4Song2");
            float vol2 = PlayerPrefs.GetFloat("Save4Song2Vol");

            print(objn2);
            if (objn2 != null)
            {
                zwei = Instantiate(Resources.Load(objn2, typeof(GameObject))) as GameObject;
                zwei.name = objn2;
                zwei.GetComponent<AudioSource>().volume = vol2;
                zwei.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS2 = objn2;
            }
            else
            {
                zwei = null;
            }

            string objn3 = PlayerPrefs.GetString("Save4Song3");
            float vol3 = PlayerPrefs.GetFloat("Save4Song3Vol");
            print(objn3);
            if (objn3 != null)
            {
                drei = Instantiate(Resources.Load(objn3, typeof(GameObject))) as GameObject;
                drei.name = objn3;
                drei.GetComponent<AudioSource>().volume = vol3;
                drei.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS3 = objn3;
            }
            else
            {
                drei = null;
            }

            string objn4 = PlayerPrefs.GetString("Save4Song4");
            float vol4 = PlayerPrefs.GetFloat("Save4Song4Vol");
            print(objn4);
            if (objn4 != null)
            {
                vier = Instantiate(Resources.Load(objn4, typeof(GameObject))) as GameObject;
                vier.name = objn4;
                vier.GetComponent<AudioSource>().volume = vol4;
                vier.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS4 = objn4;
            }
            else
            {
                vier = null;
            }

            string objn5 = PlayerPrefs.GetString("Save4Song5");
            float vol5 = PlayerPrefs.GetFloat("Save4Song5Vol");
            print(objn5);
            if (objn5 != null)
            {
                fünf = Instantiate(Resources.Load(objn5, typeof(GameObject))) as GameObject;
                fünf.name = objn5;
                fünf.GetComponent<AudioSource>().volume = vol5;
                fünf.GetComponent<AudioSource>().mute = false;
                GlobalValues.GMaS5 = objn5;
            }
            else
            {
                fünf = null;
            }
        }
        start = true;
    }

}
