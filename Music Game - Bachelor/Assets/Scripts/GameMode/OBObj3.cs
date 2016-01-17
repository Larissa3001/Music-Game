using UnityEngine;
using System.Collections;

public class OBObj3 : MonoBehaviour
{

    string currentObjName;
    GameObject currentObj;

    BoxCollider2D[] coll;
    BoxCollider2D[] childcoll;

    bool clicked = false;

    bool clickable = false;

    // Use this for initialization
    void Start()
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

    // Update is called once per frame
    void Update()
    {

        Debug.Log(clickable);
    }

    void OnMouseDown()
    {
        if (clickable == false)
        {
            GlobalValues.lifes -= 1;
            GlobalValues.combo = 0;
            ChangeSprite.ClickedWrong(currentObj);

            clicked = true;
        }
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

        currentObj = test;

        // Debug.Log(this);
        //Debug.Log(currentObjName);

        if (Input.GetMouseButtonDown(0) && clickable == true)
        {
            ZoneTest3();

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

    void ZoneTest3()
    {

        bool zone1, zone2;

        zone1 = GlobalValues.Zone1Obj3;
        zone2 = GlobalValues.Zone2Obj3;

        if (zone1 == true && zone2 == false)
        {
            GlobalValues.score += 50;
            //GlobalValues.combo = 0;
            //Debug.Log("Zone1obj3 getroffen");

            ChangeSprite.ClickedRight(currentObj);

            clicked = true;
        }

        if (zone2 == true && zone1 == false)
        {
            GlobalValues.score += 50;
            //GlobalValues.combo += 1;
            //Debug.Log("Zone2obj3 getroffen");

            ChangeSprite.ClickedRight(currentObj);

            clicked = true;
        }

        if (zone2 == true && zone1 == true)
        {
            GlobalValues.score += 100;
            GlobalValues.combo += 1;
            //Debug.Log("Zone1/2obj3 getroffen");

            ChangeSprite.ClickedRight(currentObj);

            clicked = true;
        }

        if (zone1 == false && zone2 == false)
        {
            GlobalValues.lifes -= 1;
            GlobalValues.combo = 0;
            //Debug.Log("keine Zoneobj3 getroffen");

            ChangeSprite.ClickedWrong(currentObj);

            clicked = true;
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("ClickArea"))
        {
            clickable = true;

            //Destroy(gameObject);
        }
        else
        {
            clickable = false;
        }

    }
}