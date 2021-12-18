using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMove;
    public GameObject gameOverUI;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            playerMove.enabled = false;
            GameManager.instance.EndGame();
            gameOverUI.SetActive(true);
        }
    }
}
