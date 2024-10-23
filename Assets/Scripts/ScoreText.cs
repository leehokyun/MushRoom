using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    TextMeshProUGUI ScoreTxt;

    public int score;

    public void Awake()
    {
        ScoreTxt = GetComponent<TextMeshProUGUI>();
    }

    public void RefreshUI()
    {
        ScoreTxt.text = scoreButton.score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
