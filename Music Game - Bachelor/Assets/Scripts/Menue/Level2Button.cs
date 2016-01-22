using UnityEngine;
using System.Collections;

public class Level2Button : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    public static void LevelButton() { 
            if (Application.loadedLevelName == "Scene1")
            {

                GlobalValues.globalClicksObj1 = 0;
                GlobalValues.globalClicksObj2 = 0;
                GlobalValues.globalClicksObj3 = 0;
                GlobalValues.globalClicksObj4 = 0;
                GlobalValues.globalClicksObj5 = 0;

                Application.LoadLevel("Scene2");
            }

            if (Application.loadedLevelName == "Scene2")
            {

                GlobalValues.globalClicksObj1 = 0;
                GlobalValues.globalClicksObj2 = 0;
                GlobalValues.globalClicksObj3 = 0;
                GlobalValues.globalClicksObj4 = 0;
                GlobalValues.globalClicksObj5 = 0;

                Application.LoadLevel("Scene2");
            }
        }

    }

