using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HolderController : MonoBehaviour
{
    // objToHold is the object that will be held in the holder
    public GameObject objToHold;
    // playerCamera is the camera that is attached to the player
    public GameObject playerCamera;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == objToHold)
        {
            playerCamera.GetComponent<PickupController>().DropObject();
            objToHold.transform.position = other.gameObject.transform.position;

            // If you want to rotate the object to match the holder's rotation, uncomment the following line
            //Vector3 eulerRotation = new Vector3(this.transform.eulerAngles.x + 90, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
            //objToHold.transform.rotation = Quaternion.Euler(eulerRotation);

            objToHold.GetComponent<PickUpObjectController>().isFrozen = true; // freeze the object
        }
    }
}
