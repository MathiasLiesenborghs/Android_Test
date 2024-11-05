using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathiasTimer : MonoBehaviour
{
    public Text timerText; 
    private float timeElapsed = 0f; 
    private bool isRunning = true; 

    void Update()
    {
        if (isRunning)
        {
            
            timeElapsed += Time.deltaTime;
            // On convertit le temps en minutes et secondes et on le formate
            int minutes = Mathf.FloorToInt(timeElapsed / 60);
            int seconds = Mathf.FloorToInt(timeElapsed % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    
    public void StopTimer()
    {
        isRunning = false;
    }

    
    public void ResetTimer()
    {
        timeElapsed = 0f;
        isRunning = true;
    }
}
