using UnityEngine;
using System.Collections;

public class GameModeGUI : MonoBehaviour {

    bool end;

	// Use this for initialization
	void Start () {
        end = LifeDisplay.end;
	}
	
	// Update is called once per frame
	void Update () {
        end = LifeDisplay.end;
    }

    void resetGame()
    {
        GlobalValues.lifes = 5;
        GlobalValues.combo = 0;
        GlobalValues.score = 0;
        Time.timeScale = 1;
    }

    void OnGUI()
    {

        if (!end) {
            GUI.color = Color.white;

            if (GUI.Button(new Rect(585, Screen.height / 2 + 60, 80, 25), "Neustart"))
            {
                resetGame();
                Application.LoadLevel("GameMode");
            }

            if (GUI.Button(new Rect(585, Screen.height / 2 + 100, 80, 25), "Menü"))
            {
                resetGame();
                Application.LoadLevel("MainMenu");

            }

        }
    }
}
