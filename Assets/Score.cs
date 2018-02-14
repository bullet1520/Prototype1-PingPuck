using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [SerializeField] private Text scoreText;

    

	// Use this for initialization
	void Start ()
    {
        //GameObject.FindGameObjectsWithTag("Goal").
        GameObject.Find("Goal").GetComponent<Puck>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //scoreText = "Score: " + Score1;
	}
}
