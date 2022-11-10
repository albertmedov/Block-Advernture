using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text scoreText;

    private int currentScores_; 
    void Start()
    {

        currentScores_ = 0;
        UpdateScoretext();
    }

    private void OnEnable()
    {
        GameEvents.AddScores += AddScores;
    }

    private void OnDisable()
    {
        GameEvents.AddScores -= AddScores;
    }

    private void AddScores(int scores)
    {
        currentScores_ += scores;
        UpdateScoretext();
    }

    private void UpdateScoretext()
    {
        scoreText.text = currentScores_.ToString();
    }
}
