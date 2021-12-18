using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    public float speed = 30f;
    
    private float desPosZ = -50f;

    // Update is called once per frame
    void Update()
    {
        MovingBack();
    }

    void MovingBack()
    {
        if(GameManager.instance.gameHasEnded == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if(transform.position.z < desPosZ && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
