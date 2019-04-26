using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{

    public AudioClip Sound;
    bool firstHit = false;
    int counter = 0;


    // Start is called before the first frame update
    void Start()
    {

    }


    void OnCollisionEnter(Collision collision)
    {

        if (Sound != null && !firstHit)
        {
            GetComponent<AudioSource>().clip = Sound;
            GetComponent<AudioSource>().Play();

        }
    }


    // Update is called once per frame
    void Update()
    {



    }
}
