using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    //public Boolean play;
    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
    public AudioSource source4;
    public AudioSource source5;
    public AudioSource source6;
    public AudioSource source7;
    public AudioSource source8;
    //public AudioSource source9;
    //public AudioSource source10;
    public AudioSource[] sources;
    private List<AudioSource> instanciatedObjects;
    //private GameObject[] instObj;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        sources = new AudioSource[8];

       // instanciatedObjects = new List<AudioSource>();
        for (int i=1;i<9;i++)
        { 
            
           // sources[i-1] = Instanciate(sources[i-1]) as AudioSource;
            //sources[i-1] = sourcei;

        }

        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Random int between 1-8
        if (timer>8){
            timer = 0;
            int randomInt = Random.Range(1,8);
            sources[randomInt].Play();
        }
        

    }
}
