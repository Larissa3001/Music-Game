using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour
{

    GameObject Obj;

    float x;
    float y;
    float z;

    float minTime = 1f;
    float maxTime = 3f;
    float spawnTime;
    public float untilSpawnTime;

    string spawnObject;
    string nr;

    int number;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //spawnTime = Mathf.Round(Random.Range(minTime, maxTime));
        spawnTime = Random.Range(minTime, maxTime);

        untilSpawnTime -= Time.deltaTime;
        if (untilSpawnTime <= 0)
        {
            Spawn();

            untilSpawnTime = spawnTime;
        }
    }

    void Spawn()
    {
        number = Random.Range(1,5);
        nr = number.ToString();
        spawnObject = "test" + nr;

        if (spawnObject == "test1") {
            x = -7f;
            y = 7f;
            z = -2.5f;
        }

        if (spawnObject == "test2") {
            x = -3.5f;
            y = 7f;
            z = -2.5f;
        }

        if (spawnObject == "test3") {
            x = 0f;
            y = 7f;
            z = -2.5f;
        }

        if (spawnObject == "test4") {
            x = 3.5f;
            y = 7f;
            z = -2.5f;
        }

        if (spawnObject == "test5") {
            x = 7f;
            y = 7f;
            z = -2.5f;
        }

        Vector3 startPos1 = new Vector3(x, y, z);

        GameObject spawnOb = Instantiate(Obj = GameObject.Find(spawnObject), startPos1, Quaternion.identity) as GameObject;

    }
}