using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [Header ("Set Dynamically")]
    // Start is called before the first frame update
    public Text scoreText;
    static public int score = 1;
    void Start()
    {
        scoreText.text = "Let's START!";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (score++ /2).ToString();
    }
    static public void MinusCount()
    {
        score -= 200;
    }
}
