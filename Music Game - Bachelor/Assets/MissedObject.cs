using UnityEngine;
using System.Collections;

public class MissedObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Object"))
        {
            ChangeSprite.ClickedWrong(col.gameObject);
            GlobalValues.combo = 0;
            GlobalValues.lifes -= 1;

        }

    }
}
