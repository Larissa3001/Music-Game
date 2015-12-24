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

    void OnMouseDown()
    {

        clicksObj3 += 1;

        GlobalValues.clicksObj3 += 1;

        Debug.Log("clickOb3 " + clicksObj3);

    }
}
