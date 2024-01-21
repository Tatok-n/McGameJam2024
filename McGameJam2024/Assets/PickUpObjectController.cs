using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PickUpObjectController : MonoBehaviour
{
    public GameObject plug1;
    public GameObject plug2;
    public Boolean isFrozen;

    void Update() {
        if (plug1.GetComponent<PlugController>().isConected || plug2.GetComponent<PlugController>().isConected) {
            isFrozen = true;
        }
        else {
            isFrozen = false;
        }
    }
}
