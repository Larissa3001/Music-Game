using UnityEngine;
using System.Collections;

public class Object1Clicks : MonoBehaviour
{

    public int clicksObj1 = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {

            clicksObj1 += 1;

            GlobalValues.globalClicksObj1 += 1;


            // Debug.Log("clickOb1 " + clicksObj1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            clicksObj1 -= 1;

            GlobalValues.globalClicksObj1 -= 1;
   
        }
    }


    /*void OnMouseDown()
    {

        clicksObj2 += 1;

        GlobalValues.globalClicksObj2 += 1;

      //  Debug.Log("clickOb2 " + clicksObj2);

    }*/
}
