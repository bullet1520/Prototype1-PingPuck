using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puck : MonoBehaviour {

    static public int Score1;
    public GameObject Puck1;

    [SerializeField]
    private Text scoreText;

    AudioSource Yay;

    // Use this for initialization
    void Start ()
    {
        Instantiate(Puck1);
        Yay = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "SCORE" + "\n" + Score1;
    }

    void OnCollisionEnter(Collision puck)
    {
        if (puck.gameObject.tag == "Puck")
        {
            Score1++;
			Debug.Log("You scored a goal!!!!!!!");
			//Destroy();
			puck.gameObject.transform.position = new Vector3(-3,1,-3);
            //Instantiate(Puck1);
            Yay.Play();
        }

    }
}
