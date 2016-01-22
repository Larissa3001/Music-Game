using UnityEngine;
using System.Collections;

public class Highscore : MonoBehaviour {

    public static int one, two, three;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void saveHighscore(int score)
    {
        bool h1 = true;
        bool h2 = true;

        PlayerPrefs.SetInt("Score",score);

        one = PlayerPrefs.GetInt("HS1");
        two = PlayerPrefs.GetInt("HS2");
        three = PlayerPrefs.GetInt("HS3");


        if(score > one)
        {
            PlayerPrefs.SetInt("HS3", two);
            PlayerPrefs.SetInt("HS2", one);
            PlayerPrefs.SetInt("HS1", score);

            h1 = true;
        }

        if (score < one && score > two)
        {
            PlayerPrefs.SetInt("HS3", two);
            PlayerPrefs.SetInt("HS2", score);

        }

        if (score < two && score > three)
        {
            PlayerPrefs.SetInt("HS3", score);

        }

    }

    public static void resetHighscore()
    {

        PlayerPrefs.SetInt("HS1", 0);
        PlayerPrefs.SetInt("HS2", 0);
        PlayerPrefs.SetInt("HS3", 0);

    }

    void OnGUI()
    {
        GUIStyle labelStyle = new GUIStyle();
        GUIStyle titleStyle = new GUIStyle();
        FontStyle fontStyle;

        labelStyle.fontStyle = FontStyle.Bold;
        labelStyle.normal.textColor = Color.white;

        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.normal.textColor = Color.white;
        titleStyle.fontSize = 20;



        GUI.Label(new Rect((Screen.width / 2) - 75, Screen.height / 2 - 125, 150, 25), "Highscore", titleStyle);
    
        GUI.Label(new Rect((Screen.width / 2) - 75, Screen.height / 2 - 80, 150, 25), "• Platz 1: " +  PlayerPrefs.GetInt("HS1"), labelStyle);

        GUI.Label(new Rect((Screen.width / 2) - 75, Screen.height / 2 - 35, 150, 25), "• Platz 2: " +  PlayerPrefs.GetInt("HS2"), labelStyle);

        GUI.Label(new Rect((Screen.width / 2) - 75, Screen.height / 2 + 10, 150, 25), "• Platz 3: " +  PlayerPrefs.GetInt("HS3"), labelStyle);


        GUI.color = Color.white;

        if (GUI.Button(new Rect(Screen.width - 155, Screen.height / 2 + 60, 150, 25), "Reset"))
        {
            resetHighscore();
        }
        if (GUI.Button(new Rect(Screen.width - 155, Screen.height / 2 + 100, 150, 25), "Menü"))
        {
            Application.LoadLevel("MainMenu");
        }

    }
}
