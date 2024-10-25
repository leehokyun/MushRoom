using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    TextMeshProUGUI ScoreTxt;

    public int score = 0;

    public void Awake()
    {
        ScoreTxt = GetComponent<TextMeshProUGUI>();

        scoreButton.OnScoreChanged += RefreshUI;
        scoreButton.OnScoreChanged?.Invoke(1); 
    }

    public void RefreshUI(int newScore)
    {
        ScoreTxt.text = scoreButton.score.ToString();
    }
}
