using UnityEngine;
using System.Collections;

public class ClickArea : MonoBehaviour
{

    int clickObj1;
    int clickObj2;
    int clickObj3;
    int clickObj4;
    int clickObj5;

    int newClick1;
    int newClick2;
    int newClick3;
    int newClick4;
    int newClick5;

    bool click1;
    bool click2;
    bool click3;
    bool click4;
    bool click5;


    // Use this for initialization
    void Start()
    {

        click1 = false;

        clickObj1 = 0;
        clickObj2 = 0;
        clickObj3 = 0;
        clickObj4 = 0;
        clickObj5 = 0;

        newClick1 = 0;
        newClick2 = 0;
        newClick3 = 0;
        newClick4 = 0;
        newClick5 = 0;
    }

    // Update is called once per frame
    void Update()
    {

        clickObj1 = GlobalValues.ZoneClicksObj1;
        clickObj2 = GlobalValues.ZoneClicksObj2;
        clickObj3 = GlobalValues.ZoneClicksObj3;
        clickObj4 = GlobalValues.ZoneClicksObj4;
        clickObj5 = GlobalValues.ZoneClicksObj5;

        NewClickTest();

    }

    void NewClickTest()
    {
        //Object1
        if (clickObj1 > newClick1 && click1 == false)
        {
            click1 = true;
            ZoneTest1();
            newClick1 = clickObj1;


            //Debug.Log("click1 " + click1);
        }


        if (newClick1 == clickObj1)
        {
            click1 = false;
        }

        //Object2
        if (clickObj2 > newClick2 && click2 == false)
        {
            click2 = true;
            ZoneTest2();
            newClick2 = clickObj2;


            //Debug.Log("click2 " + click2);
        }


        if (newClick2 == clickObj2)
        {
            click2 = false;
        }

        //Object3
        if (clickObj3 > newClick3 && click3 == false)
        {
            click3 = true;
            ZoneTest3();
            newClick3 = clickObj3;


            //Debug.Log("click3 " + click3);
        }


        if (newClick3 == clickObj3)
        {
            click3 = false;
        }

        //Object4
        if (clickObj4 > newClick4 && click4 == false)
        {
            click4 = true;
            ZoneTest4();
            newClick4 = clickObj4;


            //Debug.Log("click4 " + click4);
        }


        if (newClick4 == clickObj4)
        {
            click4 = false;
        }

        //Object5
        if (clickObj5 > newClick5 && click5 == false)
        {
            click5 = true;
            ZoneTest5();
            newClick5 = clickObj5;


           // Debug.Log("click5 " + click5);
        }


        if (newClick5 == clickObj5)
        {
            click5 = false;
        }
    }


    void ZoneTest1()
    {

        bool zone1, zone2;

        zone1 = GlobalValues.Zone1Obj1;
        zone2 = GlobalValues.Zone2Obj1;

        if (zone1 == true && zone2 == false)
        {
            AudioMute.Play("Eins");
            //Debug.Log("Zone1obj1 getroffen");
        }

        if (zone2 == true && zone1 == false)
        {
            AudioMute.Play("Eins");
            //Debug.Log("Zone2obj1 getroffen");
        }

        if (zone2 == true && zone1 == true)
        {
            AudioMute.Play("Eins");
            //Debug.Log("Zone1/2obj1 getroffen");
        }

        if (zone1 == false && zone2 == false)
        {
            AudioMute.Mute("Eins");
            GlobalValues.lifes -= 1;
            Debug.Log("keine Zoneobj1 getroffen");
        }

    }

    void ZoneTest2()
    {

        bool zone1, zone2;

        zone1 = GlobalValues.Zone1Obj2;
        zone2 = GlobalValues.Zone2Obj2;

        if (zone1 == true && zone2 == false)
        {
            AudioMute.Play("Zwei");
            //Debug.Log("Zone1obj2 getroffen");
        }

        if (zone2 == true && zone1 == false)
        {
            AudioMute.Play("Zwei");
            //Debug.Log("Zone2obj2 getroffen");
        }

        if (zone2 == true && zone1 == true)
        {
            AudioMute.Play("Zwei");
            //Debug.Log("Zone1/2obj2 getroffen");
        }

        if (zone1 == false && zone2 == false)
        {
            AudioMute.Mute("Zwei");
            GlobalValues.lifes -= 1;
            //Debug.Log("keine Zoneobj2 getroffen");
        }

    }

    void ZoneTest3()
    {

        bool zone1, zone2;

        zone1 = GlobalValues.Zone1Obj3;
        zone2 = GlobalValues.Zone2Obj3;

        if (zone1 == true && zone2 == false)
        {
            AudioMute.Play("Drei");
            //Debug.Log("Zone1obj3 getroffen");
        }

        if (zone2 == true && zone1 == false)
        {
            AudioMute.Play("Drei");
            //Debug.Log("Zone2obj3 getroffen");
        }

        if (zone2 == true && zone1 == true)
        {
            AudioMute.Play("Drei");
            //Debug.Log("Zone1/2obj3 getroffen");
        }

        if (zone1 == false && zone2 == false)
        {
            AudioMute.Mute("Drei");
            GlobalValues.lifes -= 1;
            //Debug.Log("keine Zoneobj3 getroffen");
        }

    }

    void ZoneTest4()
    {

        bool zone1, zone2;

        zone1 = GlobalValues.Zone1Obj4;
        zone2 = GlobalValues.Zone2Obj4;

        if (zone1 == true && zone2 == false)
        {
            AudioMute.Play("Vier");
            //Debug.Log("Zone1obj4 getroffen");
        }

        if (zone2 == true && zone1 == false)
        {
            AudioMute.Play("Vier");
            //Debug.Log("Zone2obj4 getroffen");
        }

        if (zone2 == true && zone1 == true)
        {
            AudioMute.Play("Vier");
            //Debug.Log("Zone1/2obj4 getroffen");
        }

        if (zone1 == false && zone2 == false)
        {
            AudioMute.Mute("Vier");
            GlobalValues.lifes -= 1;
            //Debug.Log("keine Zoneobj4 getroffen");
        }

    }

    void ZoneTest5()
    {

        bool zone1, zone2;

        zone1 = GlobalValues.Zone1Obj5;
        zone2 = GlobalValues.Zone2Obj5;

        if (zone1 == true && zone2 == false)
        {
            AudioMute.Play("Fünf");
            //Debug.Log("Zone1obj5 getroffen");
        }

        if (zone2 == true && zone1 == false)
        {
            AudioMute.Play("Fünf");
            //Debug.Log("Zone2obj5 getroffen");
        }

        if (zone2 == true && zone1 == true)
        {
            AudioMute.Play("Fünf");
            //Debug.Log("Zone1/2obj5 getroffen");
        }

        if (zone1 == false && zone2 == false)
        {
            AudioMute.Mute("Fünf");
            GlobalValues.lifes -= 1;
            //Debug.Log("keine Zoneobj5 getroffen");
        }

    }
}
