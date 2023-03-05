using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public Text stopwatchText; // Text object to display the stopwatch time
    private float elapsedTime = 0f; // Elapsed time
    private bool isRunning = false; // Flag to indicate if the stopwatch is running
    private float pausedTime = 0f; // Time at which the stopwatch was paused

    //functions to controll the stopwatch

    public void StartStopwatch()
    {
        isRunning = true;
        pausedTime = Time.time - elapsedTime;
    }

    public void PauseStopwatch()
    {
        isRunning = false;
        pausedTime = Time.time;
    }

    public void resetTime()
    {
        elapsedTime = 0f;
        isRunning = false;
    }

    //control functions end here

    //run the Update
    private void Update()
    {
        if (isRunning)
        {
            elapsedTime = Time.time - pausedTime;
        }

        // Format the time as minutes, seconds, and milliseconds
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 1000f) % 1000f);
        string timeString = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);

        stopwatchText.text = timeString;
    }
}
