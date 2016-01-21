using UnityEngine;
using System.Collections;

public class MMVersion2Obj2Behaviour : MonoBehaviour
{

    public GameObject obj;

    int clicks = 0;

    public static int tempo;
    public static int art;

    SpriteRenderer sprite;
    Collider2D col;
    AudioSource audio;
    AudioSource aud;

    float doubleClickTimer;
    bool oneClick = false;

    GameObject state1;
    GameObject state2;
    GameObject state3;

    bool activ = false;


    // Use this for initialization
    void Start()
    {
        //obj.SetActive(false);

        tempo = 0;
        art = 0;

        state1 = GameObject.Find("GTschnellP2");
        state2 = GameObject.Find("HochatempoP2");
        state3 = GameObject.Find("HochschnellP2");

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

        clicks = GlobalValues.clicksObj2;
        //Debug.Log("clicks: " +clicks);

        Active();

        if (activ)
        {
            VolumeAdaptation();
        }

    }

    void Active()
    {


        if (clicks == 2)
        {

            ChangeMusic();
            sprite.enabled = true;
            //audio.mute = false;
            //audio.volume = 0.5f;
            col.enabled = true;
            activ = true;

        }

        else
        {
            MusicMute();
            sprite.enabled = false;
            activ = false;
        }

    }

    void VolumeAdaptation()
    {
        float vol = 0.5f;
        float y = gameObject.transform.position.y;
        float adapt;

        adapt = vol + (y / 10);

        aud.volume = adapt;

        //Debug.Log(vol);
    }

    void ChangeMusic()
    {
        AudioSource music;

        if (tempo == 0 && art == 0)
        {
            music = this.GetComponent<AudioSource>();
            state1.GetComponent<AudioSource>().mute = true;
            state2.GetComponent<AudioSource>().mute = true;
            state3.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 1 && art == 0)
        {
            this.GetComponent<AudioSource>().mute = true;
            music = state1.GetComponent<AudioSource>();
            state2.GetComponent<AudioSource>().mute = true;
            state3.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 0 && art == 1)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            music = state2.GetComponent<AudioSource>();
            state3.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 1 && art == 1)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            state2.GetComponent<AudioSource>().mute = true;
            music = state3.GetComponent<AudioSource>();
            music.mute = false;
            aud = music;
        }

    }

    void MusicMute()
    {
        this.GetComponent<AudioSource>().mute = true;
        state1.GetComponent<AudioSource>().mute = true;
        state2.GetComponent<AudioSource>().mute = true;
        state3.GetComponent<AudioSource>().mute = true;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            art += 1;
            if (art == 2)
            {
                art = 0;
            }
        }

        float wait = 1f;

        if (Input.GetMouseButtonDown(0))
        {
            if (!oneClick)
            {
                oneClick = true;

                doubleClickTimer = Time.time;

            }
            else
            {
                oneClick = false;
                tempo += 1;
                if (tempo == 2)
                {
                    tempo = 0;
                }

                ChangeMusic();
            }
        }

        if (oneClick)
        {

            if ((Time.time - doubleClickTimer) > wait)
            {

                oneClick = false;

            }
        }
    }

    void OnMouseDrag()
    {
        float z = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 ObjMove = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, z));
        transform.position = new Vector3(transform.position.x, ObjMove.y, ObjMove.z);

    }
}
