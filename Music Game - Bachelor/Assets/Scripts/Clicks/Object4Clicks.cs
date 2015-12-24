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

    void OnMouseDown()
    {

        clicksObj4 += 1;

        GlobalValues.clicksObj4 += 1;

        Debug.Log("clickOb4 " + clicksObj4);

    }
}
