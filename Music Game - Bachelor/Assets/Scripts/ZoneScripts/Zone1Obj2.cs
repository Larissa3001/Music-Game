using UnityEngine;
using System.Collections;

public class Zone1Obj2 : MonoBehaviour
{

    bool Zone1;

    // Use this for initialization
    void Start()
    {

        Zone1 = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("ClickArea"))
        {
            Zone1 = true;

            GlobalValues.Zone1Obj2 = true;

            //Debug.Log("Enter Zone1");
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("ClickArea"))
        {
            Zone1 = false;

            GlobalValues.Zone1Obj2 = false;

            //Debug.Log("Exit Zone1");

        }

    }
}
