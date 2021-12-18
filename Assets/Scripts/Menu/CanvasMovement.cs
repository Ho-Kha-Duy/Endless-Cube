using System.Collections;
using UnityEngine;

public class CanvasMovement : MonoBehaviour
{
    public GameObject ui;
    public float speed = 10f;
    public bool isMove = false;

    void Update()
    {
        if (isMove == true && transform.position.z > -5f)
        {
            canvasMoving();
        }
    }

    public void canvasMoving()
    {
        isMove = true;
        ui.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

}
