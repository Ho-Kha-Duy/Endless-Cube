using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;

    public GameObject gameOverUI;
    public float sideForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();

        if (playerRb.position.y < 0)
        {
            GameManager.instance.EndGame();
            gameOverUI.SetActive(true);
        }
    }

    void PlayerMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(Vector3.right * horizontalInput * sideForce * Time.deltaTime, ForceMode.VelocityChange);
    }
}
