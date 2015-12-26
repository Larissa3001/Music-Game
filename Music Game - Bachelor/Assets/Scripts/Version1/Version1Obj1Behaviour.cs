using UnityEngine;
using System.Collections;

public class Version1Obj1Behaviour : MonoBehaviour {

    public GameObject obj;

    int clicks = 0;

    SpriteRenderer sprite;

    Collider2D col;


	// Use this for initialization
	void Start () {

        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = false;

        //obj.SetActive(false);

        col = GetComponent<BoxCollider2D>();
        col.enabled = false;

    }


    // Update is called once per frame
    void Update () {

        clicks = GlobalValues.clicksObj1;
        Debug.Log("clicks: " +clicks);
        Active();
	
	}

    void Active() {


        if (clicks == 1){

            sprite.enabled = true;

        }

        else {
            sprite.enabled = false;
        }

    }
}
