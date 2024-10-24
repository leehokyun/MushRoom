using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{

    Button scoreButton;
    public ScoreText scoreText;
    TextMeshProUGUI ScoreTxt;

    public Action<int> OnScoreChanged;

    public int score = 0;

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    void PointUp()
    {
        score ++;
        OnScoreChanged?.Invoke(score);
        AnimationController.animationController();
    }

}
