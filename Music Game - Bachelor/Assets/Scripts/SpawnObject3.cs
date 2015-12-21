using UnityEngine;
using System.Collections;

public class SpawnObject3 : MonoBehaviour
{

    public GameObject Snow;

    public float x;
    public float y;
    public float z;


    float spawnCooldown = 3;
    float timeUntilSpawn = 3;


    // Use this for initialization
    void Start()
    {
        SpawnObjects();
        // Snow.transform.position = new Vector3(sVec.x,sVec.y,sVec.z);

    }

    // Update is called once per frame
    void Update()
    {

        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            SpawnObjects();

            timeUntilSpawn = spawnCooldown;
        }

    }

    void SpawnObjects()
    {

        Vector3 startPos1 = new Vector3(x, y, z);

        GameObject spawnOb = Instantiate(Snow, startPos1, Quaternion.identity) as GameObject;

    }
}
