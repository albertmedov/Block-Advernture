using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPopup : MonoBehaviour
{
    public GameObject gameOverPopup;
    public GameObject losePopup;
    public GameObject newBestScorePopup;


    void Start()
    {
        gameOverPopup.SetActive(false);
    }

    private void OnEnable()
    {
        GameEvents.GameOver += OnGameOVer;
    }

    private void OnDisable()
    {
        GameEvents.GameOver -= OnGameOVer;
    }

    private void OnGameOVer(bool newBestScore)
    {
        gameOverPopup.SetActive(true);
        losePopup.SetActive(false);
        newBestScorePopup.SetActive(true);
    }
}
