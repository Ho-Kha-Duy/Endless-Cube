using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text finalScoreText;
    public Text highScore;
    public Score score;

    void OnEnable()
    {
        StartCoroutine(AnimeText());
        if (score.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", (int)score.score);
            highScore.text = "New High Score";
        }
    }

    IEnumerator AnimeText()
    {
        finalScoreText.text = "0";
        int _score = 0;

        yield return new WaitForSeconds(0.03f);

        while (_score < score.score)
        {
            _score++;
            finalScoreText.text = _score.ToString();

            yield return new WaitForSeconds(0.01f);
        }
    }
}
