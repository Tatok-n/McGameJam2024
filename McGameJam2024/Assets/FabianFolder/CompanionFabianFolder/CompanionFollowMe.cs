using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;

public class CompanionFollowMe : MonoBehaviour
{
    public Transform companionAnchor;
    public float time = 0.3f;

    //public float FloatStrength;
    public float RandomRotationStrength;

    //public Rigidbody rb;

    private Vector3 velocity;

    void Start()
    {
        companionAnchor = GameObject.Find("companionAnchor").transform;
        //rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, companionAnchor.position, ref velocity, time);
        //rb.AddForce(Vector3.up * FloatStrength);
        transform.Rotate(RandomRotationStrength, RandomRotationStrength, RandomRotationStrength);

    }



}
