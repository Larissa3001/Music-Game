using UnityEngine;
using System.Collections;

public class Object3Clicks : MonoBehaviour
{

    public int clicksObj3 = 0;

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

            clicksObj3 += 1;

            GlobalValues.globalClicksObj3 += 1;

            GlobalValues.ZoneClicksObj3 += 1;

            // Debug.Log("clickOb1 " + clicksObj1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            clicksObj3 -= 1;

            GlobalValues.globalClicksObj3 -= 1;

        }
    }
}
