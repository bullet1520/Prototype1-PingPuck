using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeScript : MonoBehaviour
{
    public static float TimerTime = 90;

    private Text timerText;

    public static bool TimeIsActive;

	// Use this for initialization
	void Start ()
    {
        timerText = GetComponent<Text>();
        TimeIsActive = true;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (TimeIsActive)
        {
            TimerTime -= Time.deltaTime;
        }
        
        timerText.text = "TIME" + "\n" + Mathf.Round(TimerTime);

        if (TimerTime <= 0)
        {
            TimeIsActive = false;
        }
	}

}
