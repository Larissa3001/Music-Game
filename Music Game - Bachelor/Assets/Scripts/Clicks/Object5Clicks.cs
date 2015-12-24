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

    void OnMouseDown()
    {

        clicksObj5 += 1;

        GlobalValues.clicksObj5 += 1;

        Debug.Log("clickOb5 " + clicksObj5);

    }
}

