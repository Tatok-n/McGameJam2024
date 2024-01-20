using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Rendering.Universal;

public class EagleVision : MonoBehaviour
{
    //Need to use lightweight RP (Import packages)
    // Create > Rendering > Universal Render Pipeline > Pipeline Asset (follow renderer)
    // Layers like target, enemy, ally, Postprocessed?

    public Camera cam1;
    public Camera cam2;

    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    void Vision()
    {
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Vision();
        }
    }
}
