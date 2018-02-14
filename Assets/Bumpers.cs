using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour {

    AudioSource BumperSound;



	// Use this for initialization
	void Start ()
    {
        BumperSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Puck")
        {
            BumperSound.Play();
            BumperSound.pitch = Random.Range(BumperSound.pitch, BumperSound.pitch + 1);
        }
    }
}
