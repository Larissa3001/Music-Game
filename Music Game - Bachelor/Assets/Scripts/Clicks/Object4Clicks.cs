using UnityEngine;
using System.Collections;

public class Object4Clicks : MonoBehaviour
{

    public int clicksObj4 = 0;

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

            clicksObj4 += 1;

            GlobalValues.globalClicksObj4 += 1;

            GlobalValues.ZoneClicksObj4 += 1;

            // Debug.Log("clickOb1 " + clicksObj1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            clicksObj4 -= 1;

            GlobalValues.globalClicksObj4 -= 1;

        }
    }
}
