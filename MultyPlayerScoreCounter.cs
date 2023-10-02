using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultyPlayerScoreCounter : MonoBehaviour
{
    public Text scorePl1;
    public Text scorePl2;

    static int scoreCountPl1 = 1;
    static int scoreCountPl2 = 1;
    private void FixedUpdate()
    {
        scorePl1.text = (scoreCountPl1++ / 2).ToString();
        scorePl2.text = (scoreCountPl2++ / 2).ToString();

    }
    static public string Counter()
    {
        if (scoreCountPl1 > scoreCountPl2)
        {
            return "1th";
        }
        return "2th";
    }
    static public void MinusCount(GameObject car)
    {
        if(car.name == "Car")
        {
            scoreCountPl1 -= 200;
        }
        if (car.name == "Car2")
        {
            scoreCountPl2 -= 200;
        }
    }

}
