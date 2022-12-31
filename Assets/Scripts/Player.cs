using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;
public class Player : MonoBehaviour
{
    public CharacterController controller;

    public float Speed = 12f;
    Vector3 velocity;
 
    

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Verh");
        y = 0;
        
        if ("isGrounded" != null ^ Input.GetKeyDown(KeyCode.Space))
        {
            y = 2f * Time.deltaTime;
        }
        Vector3 move = transform.right * x + transform.forward * z + y * transform.up;
        controller.Move(move * Time.deltaTime * Speed);
        controller.Move(velocity * Time.deltaTime);
    }
}