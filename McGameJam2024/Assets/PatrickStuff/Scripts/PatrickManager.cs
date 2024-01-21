using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrickManager : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start() 
    {
        if (player.CompareTag("")) 
        {
            Debug.Log("Hello World!");
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
