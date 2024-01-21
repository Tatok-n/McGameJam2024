using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    [Header("Pickup Settings")]
    [SerializeField] Transform holdArea;
    private GameObject heldObj;
    private Rigidbody heldObjRB;

    [Header("Phyics Parameters")]
    [SerializeField] private float pickupRange = 5.0f;
    [SerializeField] private float pickupForce = 150.0f;
    public Boolean isHolding;

    private void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(heldObj == null)
            {
                RaycastHit hit;
                if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange) && !hit.transform.gameObject.CompareTag("Segment"))
                {
                    if(!hit.transform.gameObject.CompareTag("PickUp"))
                    {
                        PickupObject(hit.transform.gameObject);
                    }
                    else if (!hit.transform.gameObject.GetComponent<PickUpObjectController>().isFrozen)
                    {
                        PickupObject(hit.transform.gameObject);
                    }
                }
            }
            else
            {
                DropObject();
            }
        }
        if (Input.GetKey(KeyCode.Q))
        {
            // Rotate Object Clockwise
            if (heldObj != null)
            {
                heldObj.transform.Rotate(0, 0, 1);
            }
        }
        if (Input.GetKey(KeyCode.E))
        {
            // Rotate Object Counter Clockwise
            if (heldObj != null)
            {
                heldObj.transform.Rotate(0, 0, -1);
            }
        }
        if(heldObj != null) 
        {
            MoveObject();
        }
    }
    
    void MoveObject() 
    {
        if(Vector3.Distance(heldObj.transform.position, holdArea.position) > 0.1f)
        {
            Vector3 moveDirection = (holdArea.position - heldObj.transform.position);
            heldObjRB.AddForce(moveDirection * pickupForce);
        }
    }

    void PickupObject(GameObject pickObj)
    {
        if (pickObj.GetComponent<Rigidbody>())
        {
            isHolding = true;
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.drag = 10;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRB.transform.parent = holdArea;
            heldObj = pickObj;
        }
    }

    public void DropObject()
    {
        heldObjRB.useGravity = true;
        heldObjRB.drag = 1;
        heldObjRB.constraints = RigidbodyConstraints.None;

        heldObj.transform.parent = null;
        heldObj = null;
        isHolding = false;
    }
}
