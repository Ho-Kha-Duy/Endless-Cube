using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public CanvasMovement canvasMovement;
    public Text highScoreText;
    public int bestScore;
    public string sceneToLoad = "Main Scene";

    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Play()
    {
        StartCoroutine(WaitingScene(sceneToLoad));
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator WaitingScene(string scene)
    {
        while (transform.position.z > -5f)
        {
            canvasMovement.canvasMoving();
            yield return 0;
        }

        SceneManager.LoadScene(scene);
    }
}
