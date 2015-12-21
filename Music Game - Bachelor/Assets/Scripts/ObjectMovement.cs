using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour
{
    public GameObject obj;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       Vector3 vec = obj.transform.position;

        obj.transform.position = new Vector3(vec.x - 0f, vec.y - 0.025f, vec.z - 0f);

    }


}
