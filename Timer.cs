using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Slider timerSlider;
    public float currentTime;

    // Update is called once per frame
    void Update()
    {
        useTime();
    }


    //function responsible for keeping track of elapsed time
    void useTime()
    {
        currentTime -= Time.deltaTime;
        timerSlider.value = currentTime;
        if(currentTime < 0f)
        {
            Destroy(gameObject);
        }
    }
}
