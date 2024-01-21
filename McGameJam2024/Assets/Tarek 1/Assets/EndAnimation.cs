using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndAnimation : MonoBehaviour
{
    public Animator Cubeanimation;
    public bool run;
    public float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        run = false;
        Cubeanimation.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (run) {
            timeElapsed+= Time.deltaTime;
        }
        if (timeElapsed>=4.5f) {
            SceneManager.LoadScene("EndAnimatio",LoadSceneMode.Single);
        }
    }

    public void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Cubeanimation.speed = 1f;
            run = true;
        }
        
        
     }

}
