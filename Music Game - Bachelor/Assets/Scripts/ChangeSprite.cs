using UnityEngine;
using System.Collections;

public class ChangeSprite : MonoBehaviour {

    public Sprite wSprite;
    public Sprite rSprite;

    public static Sprite wrong;
    public static Sprite right;


    // Use this for initialization
    void Start () {

        wrong = wSprite;
        right = rSprite;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void ClickedWrong(GameObject obj)
    {
        obj.GetComponent<SpriteRenderer>().sprite = wrong;
        obj.tag = "clicked";
            
    }

    public static void ClickedRight(GameObject obj)
    {
        obj.GetComponent<SpriteRenderer>().sprite = right;
        obj.tag = "clicked";

    }
}
