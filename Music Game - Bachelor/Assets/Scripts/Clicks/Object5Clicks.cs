using UnityEngine;
using System.Collections;

public class Object5Clicks : MonoBehaviour
{

    public int clicksObj5 = 0;

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

            clicksObj5 += 1;

            GlobalValues.globalClicksObj5 += 1;

            GlobalValues.ZoneClicksObj5 += 1;

             //Debug.Log("Klick!! " + GlobalValues.ZoneClicksObj5);
        }

        if (Input.GetMouseButtonDown(1))
        {
            clicksObj5 -= 1;

            GlobalValues.globalClicksObj5 -= 1;

        }
    }
}

