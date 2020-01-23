using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform playerBody;

    public Vector2 minMaxClampValue;

    public float mouseSen;
    public float clampValue = 90.0f;
    private float xAxisClamp = 90.0f;

    void Awake()
    {
        LockCursor();
        xAxisClamp = 0.0f;
    }

    private void LockCursor()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = !Cursor.visible;
    }

    void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSen * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSen * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > clampValue)
        {
            xAxisClamp = clampValue;
            mouseY = 0.0f;
            ClampXAxisrotationToValue(minMaxClampValue.y);
        }

        else if (xAxisClamp < -clampValue)
        {
            xAxisClamp = -clampValue;
            mouseY = 0.0f;
            ClampXAxisrotationToValue(minMaxClampValue.x);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisrotationToValue(float value)
    {
        Vector3 ealerRotation = transform.eulerAngles;
        ealerRotation.x = value;
        transform.eulerAngles = ealerRotation;
    }
}
