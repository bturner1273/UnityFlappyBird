using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private static UIManager ui;
    private static int score;
    private static bool gameActive;

    private void Start()
    {
        score = 0;
        gameActive = true;
        ui = FindObjectOfType<UIManager>();
    }

    public static void IncrementScore()
    {
        score++;
        ui.UpdateScoreDisplay();
    }

    public static int getScore()
    {
        return score;
    }

    public static void setGameActive(bool initGameActive)
    {
        gameActive = initGameActive;
        if (!gameActive)
        {
            ui.ShowGameOver();  
        }
    }

    public static bool isGameActive()
    {
        return gameActive;
    }
}
