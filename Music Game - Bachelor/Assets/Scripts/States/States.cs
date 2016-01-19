using UnityEngine;
using System.Collections;

public class States : MonoBehaviour {

    public static GameObject activ;
    public static GameObject deactiv;

    public static SpriteRenderer rendA;
    public static SpriteRenderer rendD;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void ActivateState(string name)
    {
        activ = GameObject.Find(name);
        rendA = activ.GetComponent<SpriteRenderer>();

        rendA.enabled = true;
    }

    public static void DeactivateState(string name)
    {
        deactiv = GameObject.Find(name);
        rendD = deactiv.GetComponent<SpriteRenderer>();

        rendD.enabled = false;
    }
}
