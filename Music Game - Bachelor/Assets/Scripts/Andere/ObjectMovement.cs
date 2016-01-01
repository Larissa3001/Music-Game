using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour
{
    public GameObject obj;

    Collider2D objcol;
    //test
    float timeUntilSpawn = 1.2f;

    // Use this for initialization
    void Start()
    {

        objcol = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = obj.transform.position;

        obj.transform.position = new Vector3(vec.x - 0f, vec.y - 0.025f, vec.z - 0f);

        if (objcol.enabled == false)
        {
           // Wait();
        }
    }


    /*void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag.Equals("ObjectVer1")){
            objcol.enabled = false;
        }

        if (col.gameObject.tag.Equals("ObjectVersion2")){
            objcol.enabled = false;

        }

    }*/

    void Wait() {

        //test
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            objcol.enabled = true;
           
        }

    }

}
