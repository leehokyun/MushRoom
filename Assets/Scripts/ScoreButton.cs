using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{

    Button scoreButton;
    public ScoreText scoreText; 

    public int score = 0;

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
        scoreButton.onClick.AddListener(scoreText.RefreshUI);
    }

    void PointUp()
    {
        score++;
    }


}
