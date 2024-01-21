using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class PickUpObjectController : MonoBehaviour
{
    public Boolean isFrozen;
    public GameObject powerOnObject;
    public GameObject playerCamera;
    private int count;
    private void Start() {
        isFrozen = false;
        powerOnObject.SetActive(false);
    }

    private void Update() {
        count = 0;
        foreach (Transform child in transform) {
            if (child.gameObject.CompareTag("Plug")) {
                if (child.GetComponent<PlugController>().isConected) {
                    count += 1;
                }
            }
        }
        if (count > 0 ) {
            isFrozen = true;
            if (count == transform.childCount) {
                powerOnObject.SetActive(true);
            }
            else {
                powerOnObject.SetActive(false);
            }
        }
        else {
            isFrozen = false;
            powerOnObject.SetActive(false);
        }

    }
}
