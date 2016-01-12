using UnityEngine;
using System.Collections;

public class Level1Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (Application.loadedLevelName == "Scene2")

                GlobalValues.globalClicksObj1 = 0;
                GlobalValues.globalClicksObj2 = 0;
                GlobalValues.globalClicksObj3 = 0;
                GlobalValues.globalClicksObj4 = 0;
                GlobalValues.globalClicksObj5 = 0;

            Application.LoadLevel("Scene1");

            
        }

    }
}
