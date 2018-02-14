using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLoseManager : MonoBehaviour
{
    [SerializeField]
    private Text GameOver;

    [SerializeField]
    private GameObject ActiveGameOverText;

    [SerializeField]
    private int IsThisTooHard;

    // Use this for initialization
    void Awake()
    {
        GameObject.Find("TimerText").GetComponent<TimeScript>();
        GameObject.Find("Scoreboard").GetComponent<Puck>();
    }
	
	// Update is called once per frame
	void FixedUpdate()
    {
        if (TimeScript.TimerTime <= 0)
        {
            if (Puck.Score1 < IsThisTooHard)
            {
                ActiveGameOverText.SetActive(true);
                GameOver.text = "Wow you suck, git gud scrub" + "\n" + "Press J to restart, or Q to quit";
            }

            if (Puck.Score1 >= IsThisTooHard)
            {
                ActiveGameOverText.SetActive(true);
                GameOver.text = "Good job, you win!" + "\n" + "Press J to restart, or Q to quit";
            }

            
        }
	}

    void Update()
    {
        if (TimeScript.TimerTime <= 0)
        {

            if (Input.GetKeyDown(KeyCode.J))
            {
                SceneManager.LoadScene(0);
                ActiveGameOverText.SetActive(false);
                TimeScript.TimerTime = 90;
                TimeScript.TimeIsActive = true;
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }

        }
    }
}
