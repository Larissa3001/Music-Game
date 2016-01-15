using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    Text text;

    int score;
    int combo;

	// Use this for initialization
	void Start () {

        text = GetComponent<Text>();

        combo = GlobalValues.combo;

        score = 0;
	}
	
	// Update is called once per frame
	void Update () {

        combo = GlobalValues.combo;

        score = GlobalValues.score;

        text.text = "Score: " + score + "\n Bonus: " + combo;
    }
}
