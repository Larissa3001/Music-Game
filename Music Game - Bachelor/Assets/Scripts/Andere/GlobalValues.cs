using UnityEngine;
using System.Collections;

public class GlobalValues : MonoBehaviour {

    public static int globalClicksObj1 = 0;
    public static int globalClicksObj2 = 0;
    public static int globalClicksObj3 = 0;
    public static int globalClicksObj4 = 0;
    public static int globalClicksObj5 = 0;

    public static int clicksObj1;
    public static int clicksObj2;
    public static int clicksObj3;
    public static int clicksObj4;
    public static int clicksObj5;

    public static int ZoneClicksObj1 = 0;
    public static int ZoneClicksObj2 = 0;
    public static int ZoneClicksObj3 = 0;
    public static int ZoneClicksObj4 = 0;
    public static int ZoneClicksObj5 = 0;

    public static bool Zone1Obj1;
    public static bool Zone2Obj1;
    public static bool Zone1Obj2;
    public static bool Zone2Obj2;
    public static bool Zone1Obj3;
    public static bool Zone2Obj3;
    public static bool Zone1Obj4;
    public static bool Zone2Obj4;
    public static bool Zone1Obj5;
    public static bool Zone2Obj5;


    // Use this for initialization
    void Start () {

        Adjust();

        clicksObj1 = 0;
        clicksObj2 = 0;
        clicksObj3 = 0;
        clicksObj4 = 0;
        clicksObj5 = 0;
    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(Zone1Obj1 + "" + Zone2Obj1);


        Adjust();

      //  Debug.Log("Global1 " + globalClicksObj1 + " ClicksObj1 " + clicksObj1);
      //  Debug.Log("Global2 " + globalClicksObj2 + " ClicksObj2 " + clicksObj2);
      //  Debug.Log("Global3 " + globalClicksObj3 + " ClicksObj3 " + clicksObj3);
      //  Debug.Log("Global4 " + globalClicksObj4 + " ClicksObj4 " + clicksObj4);
      //  Debug.Log("Global5 " + globalClicksObj5 + " ClicksObj5 " + clicksObj5);

    }

    void Adjust() {

        //Object 1

        if (globalClicksObj1 <= 0)
        {
            clicksObj1 = 0;
            globalClicksObj1 = 0;
        }

        else if (globalClicksObj1 == 1)
        {
            clicksObj1 = 1;
        }

        else if (globalClicksObj1 >= 2) {
            clicksObj1 = 2;
            globalClicksObj1 = 2;
        }

        //Object 2

        if (globalClicksObj2 <= 0)
        {
            clicksObj2 = 0;
            globalClicksObj2 = 0;
        }

        else if (globalClicksObj2 == 1)
        {
            clicksObj2 = 1;
        }

        else if (globalClicksObj2 >= 2)
        {
            clicksObj2 = 2;
            globalClicksObj2 = 2;
        }

        //Object 3

        if (globalClicksObj3 <= 0)
        {
            clicksObj3 = 0;
            globalClicksObj3 = 0;
        }

        else if (globalClicksObj3 == 1)
        {
            clicksObj3 = 1;
        }

        else if (globalClicksObj3 >= 2)
        {
            clicksObj3 = 2;
            globalClicksObj3 = 2;
        }

        //Object 4

        if (globalClicksObj4 <= 0)
        {
            clicksObj4 = 0;
            globalClicksObj4 = 0;
        }

        else if (globalClicksObj4 == 1)
        {
            clicksObj4 = 1;
        }

        else if (globalClicksObj4 >= 2)
        {
            clicksObj4 = 2;
            globalClicksObj4 = 2;
        }

        //Object 5

        if (globalClicksObj5 <= 0)
        {
            clicksObj5 = 0;
            globalClicksObj5 = 0;
        }

        else if (globalClicksObj5 == 1)
        {
            clicksObj5 = 1;
        }

        else if (globalClicksObj5 >= 2)
        {
            clicksObj5 = 2;
            globalClicksObj5 = 2;
        }

    }
}
