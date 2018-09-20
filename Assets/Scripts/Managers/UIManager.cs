using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {
    [SerializeField] private Text scoreDisplay;
    [SerializeField] private Image gameOverDisplay;


    public void UpdateScoreDisplay()
    {
        scoreDisplay.text = "Score: " + GameManager.getScore();
    }

    public void ShowGameOver()
    {
        gameOverDisplay.gameObject.SetActive(true);
    }


}
