using UnityEngine;
using System.Collections;

public class ObjectSpeed : MonoBehaviour {

    float speedUpCooldown = 10;
    public float timeUntilSpeedUp = 10;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        timeUntilSpeedUp -= Time.deltaTime;
        if (timeUntilSpeedUp <= 0)
        {
            SpeedUp();

            timeUntilSpeedUp = speedUpCooldown;
        }

    }

    void SpeedUp()
    {
        GlobalValues.speedY += 0.005f;
    }
}
