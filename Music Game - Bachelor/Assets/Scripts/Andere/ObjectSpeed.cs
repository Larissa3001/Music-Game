using UnityEngine;
using System.Collections;

public class ObjectSpeed : MonoBehaviour {

    float speedUpCooldown;
    public float timeUntilSpeedUp;

    bool firstSpeedUp;

    float wait = 5f;
    float cool = 5f;


    // Use this for initialization
    void Start () {

        speedUpCooldown = 25;
        timeUntilSpeedUp = 25;
    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(firstSpeedUp);


        timeUntilSpeedUp -= Time.deltaTime;
        if (timeUntilSpeedUp <= 0)
        {
            Debug.Log("Speedup");
            SpeedUp();
            timeUntilSpeedUp = speedUpCooldown;
        }

        if (firstSpeedUp)
        {

            wait -= Time.deltaTime;
            if (wait <= 0)
            {
                SpeedUp();
                Debug.Log(GlobalValues.speedY);
                wait = cool;

                firstSpeedUp = false;

            }
        }

    }


    void SpeedUp()
    {
        
        GlobalValues.speedY += 0.00625f;
        Debug.Log(GlobalValues.speedY);

        firstSpeedUp = true;
    }
}
