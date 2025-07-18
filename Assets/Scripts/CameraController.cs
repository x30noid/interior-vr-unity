﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector2 rotation = new Vector2(0, 0);
    public float speed = 3;

    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector2)rotation * speed;

        float Ymovement = Input.GetAxis("Vertical");
        float Xmovement = Input.GetAxis("Horizontal");

        Ymovement *= Time.deltaTime;
        Xmovement *= Time.deltaTime;

        this.transform.Translate(Vector3.forward * Ymovement);
        this.transform.Translate(Vector3.right * Xmovement);
    }
}
