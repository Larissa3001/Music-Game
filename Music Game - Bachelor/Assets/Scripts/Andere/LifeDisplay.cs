using UnityEngine;
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

    string eins;
    string zwei;
    string drei;
    string vier;
    string fünf;

    public static int Lifes = GlobalValues.lifes;
    public static bool end;

    bool start;

	// Use this for initialization
	void Start () {

        start = false;
        end = false;

        r1 = L1.GetComponent<SpriteRenderer>();
        r2 = L2.GetComponent<SpriteRenderer>();
        r3 = L3.GetComponent<SpriteRenderer>();
        r4 = L4.GetComponent<SpriteRenderer>();
        r5 = L5.GetComponent<SpriteRenderer>();

        


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

            r1.enabled = true;
            r2.enabled = true;
            r3.enabled = true;
            r4.enabled = true;
            r5.enabled = true;

            GlobalValues.lifes = 5;
        }

        if (Lifes == 4){

            AudioMute.Play(GlobalValues.GMaS1);
            AudioMute.Play(GlobalValues.GMaS2);
            AudioMute.Play(GlobalValues.GMaS3);
            AudioMute.Play(GlobalValues.GMaS4);
            AudioMute.Mute(GlobalValues.GMaS5);

            r1.enabled = true;
            r2.enabled = true;
            r3.enabled = true;
            r4.enabled = true;
            r5.enabled = false;
        }

        if (Lifes == 3){

            AudioMute.Play(GlobalValues.GMaS1);
            AudioMute.Play(GlobalValues.GMaS2);
            AudioMute.Play(GlobalValues.GMaS3);
            AudioMute.Mute(GlobalValues.GMaS4);
            AudioMute.Mute(GlobalValues.GMaS5);

            r1.enabled = true;
            r2.enabled = true;
            r3.enabled = true;
            r4.enabled = false;
            r5.enabled = false;
        }

        if (Lifes == 2){

            AudioMute.Play(GlobalValues.GMaS1);
            AudioMute.Play(GlobalValues.GMaS2);
            AudioMute.Mute(GlobalValues.GMaS3);
            AudioMute.Mute(GlobalValues.GMaS4);
            AudioMute.Mute(GlobalValues.GMaS5);

            r1.enabled = true;
            r2.enabled = true;
            r3.enabled = false;
            r4.enabled = false;
            r5.enabled = false;
        }

        if (Lifes == 1){

            AudioMute.Play(GlobalValues.GMaS1);
            AudioMute.Mute(GlobalValues.GMaS2);
            AudioMute.Mute(GlobalValues.GMaS3);
            AudioMute.Mute(GlobalValues.GMaS4);
            AudioMute.Mute(GlobalValues.GMaS5);

            r1.enabled = true;
            r2.enabled = false;
            r3.enabled = false;
            r4.enabled = false;
            r5.enabled = false;
        }

        if (Lifes <= 0)
        {
            AudioMute.Mute(GlobalValues.GMaS1);
            AudioMute.Mute(GlobalValues.GMaS2);
            AudioMute.Mute(GlobalValues.GMaS3);
            AudioMute.Mute(GlobalValues.GMaS4);
            AudioMute.Mute(GlobalValues.GMaS5);

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
