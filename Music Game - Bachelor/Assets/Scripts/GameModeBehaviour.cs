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
        if(Combo == 3)
        {
            GlobalValues.lifes += 1;
            GlobalValues.combo = 0;

        }
    }
}
