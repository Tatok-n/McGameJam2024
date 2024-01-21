using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject powerPlug;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(powerPlug.GetComponent<PlugController>().isConected) 
        {
            this.gameObject.SetActive(true);
        }
        else 
        {
            this.gameObject.SetActive(false);
        }
    }
}
