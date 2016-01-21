using UnityEngine;
using System.Collections;

public class GameModeBehaviour : MonoBehaviour {

    int Lifes = GlobalValues.lifes;
    int Combo = GlobalValues.combo;

	// Use this for initialization
	void Start () {

        Lifes = GlobalValues.lifes;
        Combo = GlobalValues.combo;
    }
	
	// Update is called once per frame
	void Update () {

        Lifes = GlobalValues.lifes;
        Combo = GlobalValues.combo;



        ComboBonus();

    }

    void ComboBonus()
    {

        if(Combo == 3 && Lifes >= 5)
        {
            GlobalValues.score += 150;
            GlobalValues.combo = 0;


        }
        else if(Combo == 3 && Lifes < 5)
        {
            GlobalValues.lifes += 1;
            GlobalValues.combo = 0;
        }
    }
}
