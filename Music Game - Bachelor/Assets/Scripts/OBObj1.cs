using UnityEngine;
using System.Collections;

public class OBObj1 : MonoBehaviour {

    string currentObjName;
    GameObject currentObj;

    BoxCollider2D[] coll;
    BoxCollider2D[] childcoll;


	// Use this for initialization
	void Start () {

        coll = this.gameObject.GetComponents<BoxCollider2D>();

        foreach (BoxCollider2D co in coll)
        {
            co.enabled = false;
        }

        childcoll = this.gameObject.GetComponentsInChildren<BoxCollider2D>();

        foreach (BoxCollider2D co in childcoll)
        {
            co.enabled = false;
        }

    }
	
	// Update is called once per frame
	void Update () {


    }

    void OnMouseOver()
 
    {


        GameObject test;
        BoxCollider2D[] colltest;
        BoxCollider2D[] childcolltest;

        currentObjName = this.name;

        test = GameObject.Find(currentObjName);
        colltest = test.GetComponents<BoxCollider2D>();

        foreach (BoxCollider2D co in colltest)
        {
            co.enabled = true;
        }

        childcolltest = test.GetComponentsInChildren<BoxCollider2D>();

        foreach (BoxCollider2D co in childcolltest)
        {
            co.enabled = true;
        }


        // Debug.Log(this);
        //Debug.Log(currentObjName);

            if (Input.GetMouseButtonDown(0))
            {
                ZoneTest1();

        }
    }

    void OnMouseExit()
    {
        coll = this.gameObject.GetComponents<BoxCollider2D>();

        foreach (BoxCollider2D co in coll)
        {
            co.enabled = false;
        }

        childcoll = this.gameObject.GetComponentsInChildren<BoxCollider2D>();

        foreach (BoxCollider2D co in childcoll)
        {
            co.enabled = false;
        }
    }

    void ZoneTest1()
    {
            bool zone1, zone2;

            zone1 = GlobalValues.Zone1Obj1;
            zone2 = GlobalValues.Zone2Obj1;

            if (zone1 == true && zone2 == false)
            {
                GlobalValues.score += 50;
                //GlobalValues.combo = 0;
                //Debug.Log("Zone1obj1 getroffen");
            }

            if (zone2 == true && zone1 == false)
            {
                GlobalValues.score += 50;
                //GlobalValues.combo += 1;
                //Debug.Log("Zone2obj1 getroffen");
            }

            if (zone2 == true && zone1 == true)
            {
                GlobalValues.score += 100;
                GlobalValues.combo += 1;
                //Debug.Log("Zone1/2obj1 getroffen");
            }

            if (zone1 == false && zone2 == false)
            {
                GlobalValues.lifes -= 1;
                //GlobalValues.combo = 0;
                //Debug.Log("keine Zoneobj1 getroffen");
            }
    }
}
