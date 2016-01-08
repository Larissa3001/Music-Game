using UnityEngine;
using System.Collections;

public class Zone2Obj4 : MonoBehaviour
{

    bool Zone2;

    // Use this for initialization
    void Start()
    {

        Zone2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("ClickArea"))
        {
            Zone2 = true;

            GlobalValues.Zone2Obj4 = true;

             //Debug.Log("Enter Zone2");
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("ClickArea"))
        {
            Zone2 = false;

            GlobalValues.Zone2Obj4 = false;

            //Debug.Log("Exit Zone2");

        }

    }
}
