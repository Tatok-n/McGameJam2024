
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PauseMenu : MonoBehaviour
{
    public GameObject panel; 
    public PlayerCam CameraController;
    public float defaultX, defaultY;
    public Boolean pressed;

    
    void Start() 
    {
        panel.SetActive(false);
        defaultX = CameraController.sensX;
        defaultY = CameraController.sensY;
        pressed = false;
    }

    public void Update()
    {
         
        //if escape is pressed, open/close settings panel
        if (Input.GetKey(KeyCode.P))
        {
            
            pressed = !pressed;
            System.Threading.Thread.Sleep(200);
            if (pressed) 
            {
                panel.SetActive(true);
                CameraController.sensX = 0f;
                CameraController.sensY = 0f;
                Time.timeScale = 0f;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            } 
            else 
            {
                panel.SetActive(false);
                CameraController.sensX = defaultX;
                CameraController.sensY = defaultY;
                Time.timeScale = 1f;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}