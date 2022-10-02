using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : StaticInstance<GameOverManager>
{
    public bool gameCondition;
    public bool isGameEnd;
    public GameObject gameOverBack;
    public GameObject loseState;
    public GameObject winState;

    public void Update()
    {
        if (isGameEnd == false)
        {
            gameOverBack.SetActive(true);
            
            if(gameCondition==true) { ShowWin();}
            else { ShowLose(); }

        }
    }

    public void ShowLose()
    {
        Time.timeScale = 0f;
        loseState.SetActive(true);
        winState.SetActive(false);
    }

    public void ShowWin()
    {
        Time.timeScale = 0f;
        winState.SetActive(true);
        loseState.SetActive(false);
    }
}
