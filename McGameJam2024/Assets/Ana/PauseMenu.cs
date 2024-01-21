using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject panel; 

    public void Bla()
    {
        //if escape is pressed, open/close settings panel
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }

}
