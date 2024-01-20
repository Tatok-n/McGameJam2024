using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeBullet_Fabian : MonoBehaviour
{
    public float bulletLifeTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, bulletLifeTime);
    }
}
