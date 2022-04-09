using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBrebilies : MonoBehaviour
{
    public GameManager manager;
    public Text ScoreText;
    public static int Score;

    // Update is called once per frame
    void Update()
    {
        Score = manager.GetScore();
        ScoreText.text =" Пойманых бабочек: " +Score.ToString()+ " / 10";
    }
}
