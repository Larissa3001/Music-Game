using UnityEngine;
using System.Collections;

public class Object2Clicks : MonoBehaviour
{

    public int clicksObj2 = 0;

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

            clicksObj2 += 1;

            GlobalValues.globalClicksObj2 += 1;

            // Debug.Log("clickOb1 " + clicksObj1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            clicksObj2 -= 1;

            GlobalValues.globalClicksObj2 -= 1;
        }
    }
    
}
