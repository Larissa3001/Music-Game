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

    void OnMouseDown()
    {

        clicksObj2 += 1;

        GlobalValues.clicksObj2 += 1;

        Debug.Log("clickOb2 " + clicksObj2);

    }
}
