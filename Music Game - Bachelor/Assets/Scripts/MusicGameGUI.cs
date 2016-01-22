using UnityEngine;
using System.Collections;

public class MusicGameGUI : MonoBehaviour {

    GameObject obj1;
    GameObject obj2;
    GameObject obj3;
    GameObject obj4;
    GameObject obj5;

    AudioSource aud1;
    AudioSource aud2;
    AudioSource aud3;
    AudioSource aud4;
    AudioSource aud5;

    bool right;
    bool wrong;

    // Use this for initialization
    void Start () {

        right = false;
        wrong = false;

        obj1 = GameObject.Find("obj1version1");
        obj2 = GameObject.Find("obj2version1");
        obj3 = GameObject.Find("obj3version1");
        obj4 = GameObject.Find("obj4version1");
        obj5 = GameObject.Find("obj5version1");

        aud1 = obj1.GetComponent<AudioSource>();
        aud2 = obj2.GetComponent<AudioSource>();
        aud3 = obj3.GetComponent<AudioSource>();
        aud4 = obj4.GetComponent<AudioSource>();
        aud5 = obj5.GetComponent<AudioSource>();
    }

   
	
	// Update is called once per frame
	void Update () {
	
	}

    void checkTask()
    {
        if (aud1.mute == false && aud2.mute == false && aud3.mute == false && aud4.mute == false && aud5.mute == false)
        {
            right = true;
            wrong = false;
        }
        else
        {
            right = false;
            wrong = true;
        }


    }

    void resetValues()
    {
        GlobalValues.globalClicksObj1 = 0;
        GlobalValues.globalClicksObj2 = 0;
        GlobalValues.globalClicksObj3 = 0;
        GlobalValues.globalClicksObj4 = 0;
        GlobalValues.globalClicksObj5 = 0;

        MMVersion1Obj1Behaviour.art = 0;
        MMVersion1Obj1Behaviour.tempo = 0;
        MMVersion1Obj2Behaviour.art = 0;
        MMVersion1Obj2Behaviour.tempo = 0;
        MMVersion1Obj3Behaviour.art = 0;
        MMVersion1Obj3Behaviour.tempo = 0;
        MMVersion1Obj4Behaviour.art = 0;
        MMVersion1Obj4Behaviour.tempo = 0;
        MMVersion1Obj5Behaviour.art = 0;
        MMVersion1Obj5Behaviour.tempo = 0;

        MMVersion2Obj1Behaviour.art = 0;
        MMVersion2Obj1Behaviour.tempo = 0;
        MMVersion2Obj2Behaviour.art = 0;
        MMVersion2Obj2Behaviour.tempo = 0;
        MMVersion2Obj3Behaviour.art = 0;
        MMVersion2Obj3Behaviour.tempo = 0;
        MMVersion2Obj4Behaviour.art = 0;
        MMVersion2Obj4Behaviour.tempo = 0;
        MMVersion2Obj5Behaviour.art = 0;
        MMVersion2Obj5Behaviour.tempo = 0;

       
    }

    void resetTask()
    {
        right = false;
        wrong = false;
    }

    void OnGUI()
    {
        GUIStyle titleStyle = new GUIStyle();
        FontStyle fontStyle;

        //titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.normal.textColor = Color.grey;
        titleStyle.fontSize = 15;

        GUI.Label(new Rect(90, Screen.height / 2 - 185, 150, 25), "Finde die Zusammenstellung, die ein Stück aus dem Genre Jazz ergibt!", titleStyle);


        GUI.color = Color.white;

        if (!right)
        {

            if (GUI.Button(new Rect(Screen.width - 80, Screen.height / 2 + 60, 75, 25), "Fertig!"))
            {
                checkTask();
            }

            if (GUI.Button(new Rect(Screen.width - 80, Screen.height / 2 + 100, 75, 25), "Neustart"))
            {
                resetValues();
            }

            if (GUI.Button(new Rect(Screen.width - 80, Screen.height / 2 + 140, 75, 25), "Menü"))
            {

                resetValues();
                Application.LoadLevel("MainMenu");


            }
        } 

        if (wrong)
        {
            GUI.color = Color.white;
            GUI.Box(new Rect(Screen.width - Screen.width + (Screen.width / 4) , Screen.height / 2 - 100, 300, 200), "");

            GUI.Label(new Rect(Screen.width - Screen.width + (Screen.width / 4) + 55, Screen.height / 2 - 50, 250, 25), "Leider nicht die richtige Lösung!");

            if ((GUI.Button(new Rect(Screen.width - Screen.width + (Screen.width / 4) + 60, Screen.height / 2 - 10, 80, 25), "Weiter?")))
            {
                resetTask();
            }

            if ((GUI.Button(new Rect(Screen.width - Screen.width + (Screen.width / 4) + 150, Screen.height / 2 - 10, 80, 25), "Menü!")))
            {
                resetValues();
                Application.LoadLevel("MainMenu");
            }

            if ((GUI.Button(new Rect(Screen.width - Screen.width + (Screen.width / 4) + 105, Screen.height / 2 + 30, 80, 25), "Neustart!")))
            {
                resetValues();
                Application.LoadLevel("MusicGame");
            }
        }

        if (right)
        {
            GUI.color = Color.white;
            GUI.Box(new Rect(155, Screen.height / 2 - 100, 300, 200), "");

            GUI.Label(new Rect(185, Screen.height / 2 - 50, 250, 25), "Glückwunsch dies ist die richtige Lösung!");

            if ((GUI.Button(new Rect(220, Screen.height / 2 - 10, 80, 25), "Nochmal?")))
            {
                resetTask();
                resetValues();
                Application.LoadLevel("MusicMode");
            }

            if ((GUI.Button(new Rect(310, Screen.height / 2 - 10, 80, 25), "Menü!")))
            {
                resetValues();
                Application.LoadLevel("MainMenu");
            }
           
        }

    }

}
