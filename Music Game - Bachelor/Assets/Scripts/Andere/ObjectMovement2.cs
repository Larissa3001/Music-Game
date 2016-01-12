using UnityEngine;
using System.Collections;

public class ObjectMovement2 : MonoBehaviour
{
    public GameObject obj;

    //float speedUpCooldown = 2;
    //float timeUntilSpeedUp = 2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(GlobalValues.speedY);

        Vector3 vec = obj.transform.position;

        obj.transform.position = new Vector3(vec.x - 0f, vec.y - GlobalValues.speedY, vec.z - 0f);
    }

}
