﻿using UnityEngine;
using System.Collections;

public class LifeDisplay : MonoBehaviour {

    public GameObject L1;
    public GameObject L2;
    public GameObject L3;
    public GameObject L4;
    public GameObject L5;

    SpriteRenderer r1;
    SpriteRenderer r2;
    SpriteRenderer r3;
    SpriteRenderer r4;
    SpriteRenderer r5;


    public static int Lifes = GlobalValues.lifes;
    public static bool end;

	// Use this for initialization
	void Start () {

        end = false;

        r1 = L1.GetComponent<SpriteRenderer>();
        r2 = L2.GetComponent<SpriteRenderer>();
        r3 = L3.GetComponent<SpriteRenderer>();
        r4 = L4.GetComponent<SpriteRenderer>();
        r5 = L5.GetComponent<SpriteRenderer>();


	}
	
	// Update is called once per frame
	void Update () {

        Lifes = GlobalValues.lifes;

        LifeAdjustment();


	}

    void OnGUI()
    {
        GUIStyle titleStyle = new GUIStyle();
        FontStyle fontStyle;

        //titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.normal.textColor = Color.white;
        titleStyle.fontSize = 20;

        if (end) {
            GUI.Box(new Rect(200, Screen.height / 2 - 100, 250, 200), "");

            GUI.Label(new Rect(272, Screen.height / 2 - 50, 150, 25), "Game Over!", titleStyle);

            if ((GUI.Button(new Rect(245, Screen.height / 2 - 10, 80, 25), "Neustart?")))
            {
                resetGame();
                Application.LoadLevel("GameMode");
            }

            if ((GUI.Button(new Rect(335, Screen.height / 2 - 10, 80, 25), "Highscore!")))
            {
                resetGame();
                Application.LoadLevel("Highscore");
            }

            if ((GUI.Button(new Rect(288, Screen.height / 2 + 30, 80, 25), "Menü!")))
            {
                resetGame();
                Application.LoadLevel("MainMenu");
            }
            

        }
    }

    void resetGame()
    {
        end = false;
        GlobalValues.lifes = 5;
        GlobalValues.combo = 0;
        GlobalValues.score = 0;
        Time.timeScale = 1;
    }



    void LifeAdjustment()
    {
         if(Lifes >= 5){

            AudioMute.Play("Eins");
            AudioMute.Play("Zwei");
            AudioMute.Play("Drei");
            AudioMute.Play("Vier");
            AudioMute.Play("Fünf");

            r1.enabled = true;
            r2.enabled = true;
            r3.enabled = true;
            r4.enabled = true;
            r5.enabled = true;

            GlobalValues.lifes = 5;
        }

        if (Lifes == 4){

            AudioMute.Play("Eins");
            AudioMute.Play("Zwei");
            AudioMute.Play("Drei");
            AudioMute.Play("Vier");
            AudioMute.Mute("Fünf");

            r1.enabled = true;
            r2.enabled = true;
            r3.enabled = true;
            r4.enabled = true;
            r5.enabled = false;
        }

        if (Lifes == 3){

            AudioMute.Play("Eins");
            AudioMute.Play("Zwei");
            AudioMute.Play("Drei");
            AudioMute.Mute("Vier");
            AudioMute.Mute("Fünf");

            r1.enabled = true;
            r2.enabled = true;
            r3.enabled = true;
            r4.enabled = false;
            r5.enabled = false;
        }

        if (Lifes == 2){

            AudioMute.Play("Eins");
            AudioMute.Play("Zwei");
            AudioMute.Mute("Drei");
            AudioMute.Mute("Vier");
            AudioMute.Mute("Fünf");

            r1.enabled = true;
            r2.enabled = true;
            r3.enabled = false;
            r4.enabled = false;
            r5.enabled = false;
        }

        if (Lifes == 1){

            AudioMute.Play("Eins");
            AudioMute.Mute("Zwei");
            AudioMute.Mute("Drei");
            AudioMute.Mute("Vier");
            AudioMute.Mute("Fünf");

            r1.enabled = true;
            r2.enabled = false;
            r3.enabled = false;
            r4.enabled = false;
            r5.enabled = false;
        }

        if (Lifes <= 0)
        {
            AudioMute.Mute("Eins");
            AudioMute.Mute("Zwei");
            AudioMute.Mute("Drei");
            AudioMute.Mute("Vier");
            AudioMute.Mute("Fünf");

            r1.enabled = false;
            r2.enabled = false;
            r3.enabled = false;
            r4.enabled = false;
            r5.enabled = false;

            //Ende

            end = true;
            Time.timeScale = 0;

            GlobalValues.lifes = 0;

            Highscore.saveHighscore(GlobalValues.score);
        }
    }
}
