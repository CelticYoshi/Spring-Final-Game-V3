using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 180f;
    public TextMeshProUGUI timerText;
    private bool _isTimerRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartGameTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if(_isTimerRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                // display the timer amount
                DisplayTime(timeRemaining);
            }
            else 
            {
                timeRemaining = 0;
                _isTimerRunning = false;
            }
        }
    }     

    public void StartGameTimer()
    {
        _isTimerRunning = true;
    }

    public void EndGameTimer()
    {
        _isTimerRunning = false;
    }

    public float GetTimeRemaining()
    {
        return timeRemaining;
    }

    private void DisplayTime(float timetoDisplay)
    {
        timetoDisplay += 1;
        
        float minutes = Mathf.FloorToInt(timetoDisplay / 60);
        float seconds = Mathf.FloorToInt(timetoDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
