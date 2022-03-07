﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    
    
    public float timeRemaining = 10;
    public bool timerIsRunning = true;
    public Text timeText;
    void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
      
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("Time Remaining " + "{0:00}:{1:00}", minutes, seconds);
    }
}