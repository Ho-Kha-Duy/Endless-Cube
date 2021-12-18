using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scoreIncrease = 5f;
    public bool isScore = true;
    public float score;

    // Update is called once per frame
    void Update()
    {
        if (isScore)
        {
            score += scoreIncrease * Time.deltaTime;
        }

        scoreText.text = score.ToString("0");
    }
}
