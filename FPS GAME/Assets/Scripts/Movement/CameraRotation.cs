﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    private GameObject cameraObject;
    private InputManager inputManager;
    private float verticleCameraSpeed;

    [SerializeField]
    private float cameraSpeed = 5;

    /*
     * Initialize the required components components
     */
    void Start()
    {
        cameraObject = Camera.main.gameObject;
        //check if the inputmanager is present. If it's not, add it.
        if (!(inputManager = this.GetComponent<InputManager>()))
        {
            inputManager = this.gameObject.AddComponent<InputManager>();
        }
    }

    void Update()
    {
        //rotate the entire gameobject
        this.transform.Rotate(0, inputManager.GetXRot() * cameraSpeed, 0);
        //rotate the camera only.
        verticleCameraSpeed += inputManager.GetYRot() * cameraSpeed;
        verticleCameraSpeed = Mathf.Clamp(verticleCameraSpeed, -70f, 70f);
        cameraObject.transform.localEulerAngles = new Vector3(verticleCameraSpeed, 0, 0);
    }
}