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

    void OnMouseDown()
    {

        clicksObj1 += 1;

        GlobalValues.clicksObj1 += 1;

        Debug.Log("clickOb1 " + clicksObj1);

    }
}
