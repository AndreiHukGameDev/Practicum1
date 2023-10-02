using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public GameObject frontGround;
    private RectTransform rectTransform;
    public float speed = 0.0001f;

    public GameObject textWin;
    public Text text;

    public GameObject button;
    private void Start()
    {
        textWin.SetActive(false);
        rectTransform = frontGround.GetComponent<RectTransform>();
    }
    private void FixedUpdate()
    {
        rectTransform.localScale = new Vector3(rectTransform.localScale.x - speed, rectTransform.localScale.y, 0);
        CheckingEnd(rectTransform);
    }
    private void Finish()
    {
        textWin.SetActive(true);
        button.SetActive(true);
        text = textWin.GetComponent<Text>();
        text.text = $"{MultyPlayerScoreCounter.Counter()} is win!\nGratulacje!";
    }
    private void CheckingEnd(RectTransform rectTransform)
    {
        if (rectTransform.localScale.x <= 0.001f)
        {
            Time.timeScale = 0;
            Finish();
        }
    }

}
