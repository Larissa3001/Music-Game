﻿using UnityEngine;
using System.Collections;

public class LifeDisplay : MonoBehaviour {

    //public GameObject L1;
    //public GameObject L2;
    // public GameObject L3;
    // public GameObject L4;
    //public GameObject L5;

    //SpriteRenderer r1;
    //SpriteRenderer r2;
    // SpriteRenderer r3;
    //SpriteRenderer r4;
    //SpriteRenderer r5;

    string eins;
    string zwei;
    string drei;
    string vier;
    string fünf;

    public static int Lifes = GlobalValues.lifes;
    public static bool end;

    bool start;

    public Texture note;

    bool L1, L2, L3, L4, L5;

	// Use this for initialization
	void Start () {

        start = false;
        end = false;

        /* r1 = L1.GetComponent<SpriteRenderer>();
         r2 = L2.GetComponent<SpriteRenderer>();
         r3 = L3.GetComponent<SpriteRenderer>();
         r4 = L4.GetComponent<SpriteRenderer>();
         r5 = L5.GetComponent<SpriteRenderer>();*/

        L1 = true;
        L2 = true;
        L3 = true;
        L4 = true;
        L5 = true;



    }
	
	// Update is called once per frame
	void Update () {

        
            eins = GlobalValues.GMaS1;
            zwei = GlobalValues.GMaS2;
            drei = GlobalValues.GMaS3;
            vier = GlobalValues.GMaS4;
            fünf = GlobalValues.GMaS5;
    

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
        if (L5 == true)
        {
            
            GUI.Button(new Rect((Screen.width - 185), Screen.height / 64, 60, 60), note, "label");

        }
        if (L4 == true)
        {
           
            GUI.Button(new Rect((Screen.width - 155), Screen.height / 64, 60, 60), note, "label");

        }
        if (L3 == true)
        {
            
            GUI.Button(new Rect((Screen.width - 125), Screen.height / 64, 60, 60), note, "label");

        }
        if (L2 == true)
        {
            
            GUI.Button(new Rect((Screen.width - 95),Screen.height /64 , 60, 60), note, "label");
        }
        if (L1 == true)
        {
            GUI.Button(new Rect((Screen.width - 65), Screen.height / 64, 60, 60), note, "label");
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

            AudioMute.Play(eins);
            AudioMute.Play(zwei);
            AudioMute.Play(drei);
            AudioMute.Play(vier);
            AudioMute.Play(fünf);

            //r1.enabled = true;
            //r2.enabled = true;
            //r3.enabled = true;
            //r4.enabled = true;
            //r5.enabled = true;

            GlobalValues.lifes = 5;
            L1 = true;
            L2 = true;
            L3 = true;
            L4 = true;
            L5 = true;
        }

        if (Lifes == 4){

            AudioMute.Play(eins);
            AudioMute.Play(zwei);
            AudioMute.Play(drei);
            AudioMute.Play(vier);
            AudioMute.Mute(fünf);

            //r1.enabled = true;
            //r2.enabled = true;
            //r3.enabled = true;
            //r4.enabled = true;
            //r5.enabled = false;

            L1 = true;
            L2 = true;
            L3 = true;
            L4 = true;
            L5 = false;
        }

        if (Lifes == 3){

            AudioMute.Play(eins);
            AudioMute.Play(zwei);
            AudioMute.Play(drei);
            AudioMute.Mute(vier);
            AudioMute.Mute(fünf);

            //r1.enabled = true;
            //r2.enabled = true;
            //r3.enabled = true;
            //r4.enabled = false;
            //r5.enabled = false;
            L1 = true;
            L2 = true;
            L3 = true;
            L4 = false;
            L5 = false;
        }

        if (Lifes == 2){

            AudioMute.Play(eins);
            AudioMute.Play(zwei);
            AudioMute.Mute(drei);
            AudioMute.Mute(vier);
            AudioMute.Mute(fünf);

            //r1.enabled = true;
            //r2.enabled = true;
            //r3.enabled = false;
            // r4.enabled = false;
            // r5.enabled = false;

            L1 = true;
            L2 = true;
            L3 = false;
            L4 = false;
            L5 = false;
        }

        if (Lifes == 1){

            AudioMute.Play(eins);
            AudioMute.Mute(zwei);
            AudioMute.Mute(drei);
            AudioMute.Mute(vier);
            AudioMute.Mute(fünf);

            //r1.enabled = true;
            // r2.enabled = false;
            //r3.enabled = false;
            //r4.enabled = false;
            //r5.enabled = false;

            L1 = true;
            L2 = false;
            L3 = false;
            L4 = false;
            L5 = false;
        }

        if (Lifes <= 0)
        {
            AudioMute.Mute(eins);
            AudioMute.Mute(zwei);
            AudioMute.Mute(drei);
            AudioMute.Mute(vier);
            AudioMute.Mute(fünf);

            // r1.enabled = false;
            //r2.enabled = false;
            // r3.enabled = false;
            // r4.enabled = false;
            // r5.enabled = false;

            //Ende

            L1 = false;
            L2 = false;
            L3 = false;
            L4 = false;
            L5 = false;

            end = true;
            Time.timeScale = 0;

            GlobalValues.lifes = 0;

            Highscore.saveHighscore(GlobalValues.score);
        }
    }
}
