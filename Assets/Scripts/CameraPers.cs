using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraPers : MonoBehaviour
{
    public float mouseSensitivity = 150f;

    public Transform Player;

    float xRotation = 0f;

    internal Ray ScreenPointToRay(Vector2 vector2)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Player.Rotate(Vector3.up * mouseX);
    }
}