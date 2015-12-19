using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

    public GameObject Snow;

    public GameObject flake;

    Vector3 sVec;

    float x = -6.71f;
    float y = 5.41f; 
    float z = 0;

    float spawnCooldown = 5;
    float timeUntilSpawn = 5;


    // Use this for initialization
    void Start () {

   // Snow.transform.position = new Vector3(sVec.x,sVec.y,sVec.z);


    }
	
	// Update is called once per frame
	void Update () {

        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            SpawnObjects();

         timeUntilSpawn = spawnCooldown;
        }

}

    void SpawnObjects(){

        Vector3 startPos = new Vector3(x,y,z);
        GameObject spawnOb = Instantiate(Snow, startPos, Quaternion.identity) as GameObject;
    }
}
