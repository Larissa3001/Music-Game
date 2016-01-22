using UnityEngine;
using System.Collections;

public class FM2Version1Obj3Behaviour : MonoBehaviour
{

    public GameObject obj;

    int clicks = 0;

    int tempo;
    int art;

    SpriteRenderer sprite;
    Collider2D col;
    AudioSource audio;
    AudioSource aud;

    float doubleClickTimer;
    bool oneClick = false;

    GameObject state1;
    GameObject state2;
    GameObject state3;
    GameObject state4;
    GameObject state5;
    GameObject state6;
    GameObject state7;
    GameObject state8;

    bool activ = false;
    // Use this for initialization
    void Start()
    {
        //obj.SetActive(false);

        tempo = 0;
        art = 0;

        state1 = GameObject.Find("2GTlangsamJ3");
        state2 = GameObject.Find("2GTschnellJ3");
        state3 = GameObject.Find("2TiefatempoJ3");
        state4 = GameObject.Find("2TieflangsamJ3");
        state5 = GameObject.Find("2TiefschnellJ3");
        state6 = GameObject.Find("2HochatempoJ3");
        state7 = GameObject.Find("2HochlangsamJ3");
        state8 = GameObject.Find("2HochschnellJ3");

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
        //Debug.Log("clicks: " +clicks);

        Active();

        if (activ)
        {
            VolumeAdaptation();
        }
    }

    void Active()
    {


        if (clicks == 1)
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
            state4.GetComponent<AudioSource>().mute = true;
            state5.GetComponent<AudioSource>().mute = true;
            state6.GetComponent<AudioSource>().mute = true;
            state7.GetComponent<AudioSource>().mute = true;
            state8.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 1 && art == 0)
        {
            this.GetComponent<AudioSource>().mute = true;
            music = state1.GetComponent<AudioSource>();
            state2.GetComponent<AudioSource>().mute = true;
            state3.GetComponent<AudioSource>().mute = true;
            state4.GetComponent<AudioSource>().mute = true;
            state5.GetComponent<AudioSource>().mute = true;
            state6.GetComponent<AudioSource>().mute = true;
            state7.GetComponent<AudioSource>().mute = true;
            state8.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 2 && art == 0)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            music = state2.GetComponent<AudioSource>();
            state3.GetComponent<AudioSource>().mute = true;
            state4.GetComponent<AudioSource>().mute = true;
            state5.GetComponent<AudioSource>().mute = true;
            state6.GetComponent<AudioSource>().mute = true;
            state7.GetComponent<AudioSource>().mute = true;
            state8.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 0 && art == 1)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            state2.GetComponent<AudioSource>().mute = true;
            music = state3.GetComponent<AudioSource>();
            state4.GetComponent<AudioSource>().mute = true;
            state5.GetComponent<AudioSource>().mute = true;
            state6.GetComponent<AudioSource>().mute = true;
            state7.GetComponent<AudioSource>().mute = true;
            state8.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 0 && art == 2)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            state2.GetComponent<AudioSource>().mute = true;
            state3.GetComponent<AudioSource>().mute = true;
            state4.GetComponent<AudioSource>().mute = true;
            state5.GetComponent<AudioSource>().mute = true;
            music = state6.GetComponent<AudioSource>();
            state7.GetComponent<AudioSource>().mute = true;
            state8.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 1 && art == 1)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            state2.GetComponent<AudioSource>().mute = true;
            state3.GetComponent<AudioSource>().mute = true;
            music = state4.GetComponent<AudioSource>();
            state5.GetComponent<AudioSource>().mute = true;
            state6.GetComponent<AudioSource>().mute = true;
            state7.GetComponent<AudioSource>().mute = true;
            state8.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 2 && art == 1)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            state2.GetComponent<AudioSource>().mute = true;
            state3.GetComponent<AudioSource>().mute = true;
            state4.GetComponent<AudioSource>().mute = true;
            music = state5.GetComponent<AudioSource>();
            state6.GetComponent<AudioSource>().mute = true;
            state7.GetComponent<AudioSource>().mute = true;
            state8.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 1 && art == 2)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            state2.GetComponent<AudioSource>().mute = true;
            state3.GetComponent<AudioSource>().mute = true;
            state4.GetComponent<AudioSource>().mute = true;
            state5.GetComponent<AudioSource>().mute = true;
            state6.GetComponent<AudioSource>().mute = true;
            music = state7.GetComponent<AudioSource>();
            state8.GetComponent<AudioSource>().mute = true;
            music.mute = false;
            aud = music;
        }
        if (tempo == 2 && art == 2)
        {
            this.GetComponent<AudioSource>().mute = true;
            state1.GetComponent<AudioSource>().mute = true;
            state2.GetComponent<AudioSource>().mute = true;
            state3.GetComponent<AudioSource>().mute = true;
            state4.GetComponent<AudioSource>().mute = true;
            state5.GetComponent<AudioSource>().mute = true;
            state6.GetComponent<AudioSource>().mute = true;
            state7.GetComponent<AudioSource>().mute = true;
            music = state8.GetComponent<AudioSource>();
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
        state4.GetComponent<AudioSource>().mute = true;
        state5.GetComponent<AudioSource>().mute = true;
        state6.GetComponent<AudioSource>().mute = true;
        state7.GetComponent<AudioSource>().mute = true;
        state8.GetComponent<AudioSource>().mute = true;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            art += 1;
            if (art == 3)
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
                if (tempo == 3)
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
