using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class EndingSceneController : MonoBehaviour
{
    public AudioSource sound;
    public Animator ourCube,newCube,Cam;
    public AnimationCurve VignetteProgress;

    public float progress;
    public VolumeProfile Volume;
    public Vignette Vignette;

    // Start is called before the first frame update
    void Start()
    {
        Volume.TryGet(out Vignette);
        Vignette.intensity.value =0f;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (!sound.isPlaying) {
            ourCube.speed = 0f;
            newCube.speed = 0f;
            Cam.speed = 0f;
            progress += Time.deltaTime;
            Vignette.intensity.value = VignetteProgress.Evaluate(progress);
        } if (progress >= 2f) {
            Application.Quit();
        }
    }
}
