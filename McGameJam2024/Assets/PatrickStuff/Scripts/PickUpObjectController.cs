using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class PickUpObjectController : MonoBehaviour
{
    public Boolean isFrozen,enabled;
    public GameObject powerOnObject;
    public GameObject playerCamera;
    public int count,tempcount;

    private void Start() 
    {
        enabled = false;
        isFrozen = false;
        powerOnObject.SetActive(false);
    }

    private void Update() {
       tempcount = 0;
        foreach (Transform child in transform) {
            if (child.gameObject.CompareTag("Plug")) {
                if (child.GetComponent<PlugController>().isConected) {
                    tempcount += 1;
                }
            }
        }
        count = tempcount;
        
        if ( count > 0 ) {
            Debug.Log(count==2);
            isFrozen = true;
            if (count == 2) {
                Debug.Log("A");
                powerOnObject.SetActive(true);
                enabled = true;
            }
            
        }
        else {
            isFrozen = false;
            //powerOnObject.SetActive(false);
        }

    }
}
