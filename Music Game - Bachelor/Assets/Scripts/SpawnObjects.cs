using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour
{

    GameObject Obj;

    float x;
    float y;
    float z;

    float minTime = 0.25f;
    float maxTime = 1f;
    float spawnTime;
    public float untilSpawnTime;

    string spawnObject;
    string nr;

    int number;

    int nextnr;
    int lastnr;

    public GameObject test1;
    public GameObject test2;
    public GameObject test3;
    public GameObject test4;
    public GameObject test5;

    GameObject newOb;

    // Use this for initialization
    void Start()
    {
        nextnr = 0;
        lastnr = 0;

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
        if(nextnr >= 20)
        {
            nextnr = 0;
        }

        lastnr = nextnr;
        nextnr += 1;

        string objnr = nextnr.ToString();
        string objname = "Stern" + objnr;

        number = Random.Range(1,5);
        nr = number.ToString();
        spawnObject = "test" + nr;

        if (spawnObject == "test1") {
            x = -7f;
            y = 7f;
            z = -2.5f;

            newOb = test1;
        }

        if (spawnObject == "test2") {
            x = -3.5f;
            y = 7f;
            z = -2.5f;

            newOb = test2;
        }

        if (spawnObject == "test3") {
            x = 0f;
            y = 7f;
            z = -2.5f;

            newOb = test3;
        }

        if (spawnObject == "test4") {
            x = 3.5f;
            y = 7f;
            z = -2.5f;

            newOb = test4;
        }

        if (spawnObject == "test5") {
            x = 7f;
            y = 7f;
            z = -2.5f;

            newOb = test5;
        }

        Vector3 startPos1 = new Vector3(x, y, z);

        GameObject spawnOb = (GameObject)Instantiate(newOb, startPos1, Quaternion.identity);
        spawnOb.name = objname;
            //Instantiate(Obj = GameObject.Find(spawnObject), startPos1, Quaternion.identity) as GameObject;

       // GameObject newViking1 = (GameObject)Instantiate(viking1, pos, Quaternion.identity); //Instantiating Viking1.
       // newViking1.name = viking1.name;

    }
}