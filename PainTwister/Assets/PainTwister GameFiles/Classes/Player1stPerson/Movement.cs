using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 movement;

    public float speed;

    public void Update()
    {
        KeyBoardMove();
    }

    public void KeyBoardMove()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        movement = new Vector3(hor, 0, ver) * Time.deltaTime * speed;

        transform.Translate(movement);
    }
}
