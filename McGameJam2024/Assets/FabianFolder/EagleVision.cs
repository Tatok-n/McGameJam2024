using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Rendering.Universal;

public class EagleVision : MonoBehaviour
{
    public Material enemy, objective, companion;
    public float eagleGlow = 5f;
    public float normalGlow = 0f;

    //public Camera cam1;
    //public Camera cam2;

    /*
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }
    */

    public void Vision()
    {
        if (Input.GetKey(KeyCode.V))
        {
            enemy.SetFloat("_emissionIntensity", eagleGlow);
            objective.SetFloat("_emissionIntensity", eagleGlow);
            companion.SetFloat("_emissionIntensity", eagleGlow);

        } 
        else
        {
            enemy.SetFloat("_emissionIntensity", normalGlow);
            objective.SetFloat("_emissionIntensity", normalGlow);
            companion.SetFloat("_emissionIntensity", normalGlow);
        }
        return;
    }
    

    // Update is called once per frame
    private void Update()
    {
        Vision();
    }
    
}
