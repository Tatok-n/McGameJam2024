using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlugController : MonoBehaviour
{
    public bool isConected = false;
    public UnityEvent OnWirePlugged;
    public Transform plugPosition;

    [HideInInspector]
    public Transform endAnchor;
    [HideInInspector]
    public Rigidbody endAnchorRB;
    [HideInInspector]
    public WireController wireController;
    public GameObject playerCamera;
    public GameObject powerOnObject;
    public void OnPlugged()
    {
        powerOnObject.SetActive(true);
        OnWirePlugged.Invoke();
    }

    // On trigger enter is called when the object enters the trigger collider
    // Checks if the object that entered the trigger is the end anchor
    // If it is, then it sets the end anchor to the plug position and rotation
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject == endAnchor.gameObject)
        {
            playerCamera.GetComponent<PickupController>().DropObject();
            isConected = true;
            endAnchorRB.isKinematic = true;
            endAnchor.transform.position = plugPosition.position;
            endAnchor.transform.rotation = transform.rotation;

            OnPlugged();

            endAnchorRB.isKinematic = true;
            endAnchor.transform.position = plugPosition.position;
            Vector3 eulerRotation = new Vector3(this.transform.eulerAngles.x + 90, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
            endAnchor.transform.rotation = Quaternion.Euler(eulerRotation);
        }
    }

    private void Update()
    {
        if(!isConected)
        {
            powerOnObject.SetActive(false);
        }
        // check if the end anchor is in the plug position
        // if it is not, then is no longer connected
        if (endAnchor.transform.position != plugPosition.position)
        {
            isConected = false;
        }

        /*
        if (isConected)
        {
            endAnchorRB.isKinematic = true;
            endAnchor.transform.position = plugPosition.position;
            Vector3 eulerRotation = new Vector3(this.transform.eulerAngles.x + 90, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
            endAnchor.transform.rotation = Quaternion.Euler(eulerRotation);
        }
        */
        
    }
}
