using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject scoreText;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    public Score score;
    public bool gameHasEnded = false;
    public float restartDelay = 2f;

    public void EndGame()
    {
        score = FindObjectOfType<Score>();

        if (gameHasEnded == false)
        {
            score.isScore = false;
            scoreText.SetActive(false);
            gameHasEnded = true;
        }
    }
}
