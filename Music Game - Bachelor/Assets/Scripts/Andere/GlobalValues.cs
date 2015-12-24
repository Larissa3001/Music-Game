using UnityEngine;
using System.Collections;

public class GlobalValues : MonoBehaviour {

    public static int clicksObj1;
    public static int clicksObj2;
    public static int clicksObj3;
    public static int clicksObj4;
    public static int clicksObj5;

    // Use this for initialization
    void Start () {

        clicksObj1 = 0;
        clicksObj2 = 0;
        clicksObj3 = 0;
        clicksObj4 = 0;
        clicksObj5 = 0;
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log("Global1 " + clicksObj1);
        Debug.Log("Global2 " + clicksObj2);
        Debug.Log("Global3 " + clicksObj3);
        Debug.Log("Global4 " + clicksObj4);
        Debug.Log("Global5 " + clicksObj5);

    }
}
