﻿using UnityEngine;
using System.Collections;

public class SpawnObject1 : MonoBehaviour
{

    public GameObject Obj;

    public float x;
    public float y;
    public float z;


    public float spawnCooldown;
    public float timeUntilSpawn;


    // Use this for initialization
    void Start()
    {
        SpawnObjects();

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

        GameObject spawnOb = Instantiate(Obj, startPos1, Quaternion.identity) as GameObject;

    }
}