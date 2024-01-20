using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;

public class CompanionFollowMe : MonoBehaviour
{
    public Transform companionAnchor;
    public float time = 0.3f;

    private Vector3 velocity;

    void Start()
    {
        companionAnchor = GameObject.Find("companionAnchor").transform;
    }

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, companionAnchor.position, ref velocity, time);
    }


}
