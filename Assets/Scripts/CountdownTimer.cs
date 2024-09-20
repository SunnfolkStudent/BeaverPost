using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;




public class CountdownTimer : MonoBehaviour
{
    public Text textClock;
    
    private float countdownTimerDuration;
    private float countdownTimerStartTime;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textClock = GetComponent<Text>();
        CountdownTimerReset(30);
    }

    // Update is called once per frame
    void Update()
    {
        // default = timer finished
        string timerMessage = "Countdown has finished";
        int timeLeft = (int)CountdownTimerSecondsRemaining();

            if (timeLeft > 0)
            {
                timerMessage = "Time remaining: " + LeadingZero( timeLeft );
            
                textClock.text = timerMessage;
            }
            
            else
            {
                print("Countdown has finished");
                SceneManager.LoadScene("MainMenu 1");
            }

        
    }
    
    private void CountdownTimerReset(float delayInSeconds)
    {
        countdownTimerDuration = delayInSeconds;
        countdownTimerStartTime = Time.time;
    }

    private float CountdownTimerSecondsRemaining()
    {
        float elapsedSeconds = Time.time - countdownTimerStartTime;
        float timeLeft = countdownTimerDuration - elapsedSeconds;
        return timeLeft;
    }

    private string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
