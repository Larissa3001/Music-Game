using UnityEngine;
using System.Collections;

public class StartDeactivation : MonoBehaviour {

    SpriteRenderer rend;

	// Use this for initialization
	void Start () {

        rend = gameObject.GetComponent<SpriteRenderer>();
        rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
