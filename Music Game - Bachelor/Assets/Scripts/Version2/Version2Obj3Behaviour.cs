using UnityEngine;
using System.Collections;

public class Version2Obj3Behaviour : MonoBehaviour
{

    public GameObject obj;

    int clicks = 0;

    SpriteRenderer sprite;
    Collider2D col;
    AudioSource audio;


    // Use this for initialization
    void Start()
    {
        //obj.SetActive(false);

        audio = GetComponent<AudioSource>();
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<BoxCollider2D>();

        audio.mute = true;
        sprite.enabled = false;
        col.enabled = false;

    }


    // Update is called once per frame
    void Update()
    {

        clicks = GlobalValues.clicksObj3;
        //Debug.Log("clicks: " + clicks);

        Active();
        VolumeAdaptation();

    }

    void Active()
    {


        if (clicks == 2)
        {

            sprite.enabled = true;
            audio.mute = false;
            audio.volume = 0.5f;
            col.enabled = true;

        }

        else
        {
            sprite.enabled = false;
            audio.mute = true;
        }

    }

    void VolumeAdaptation()
    {
        float vol = 0.5f;
        float y = gameObject.transform.position.y;
        float adapt;

        adapt = vol + (y / 10);

        audio.volume = adapt;

        //Debug.Log(vol);
    }

    void OnMouseDrag()
    {
        float z = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 ObjMove = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, z));
        transform.position = new Vector3(transform.position.x, ObjMove.y, ObjMove.z);

    }
}
