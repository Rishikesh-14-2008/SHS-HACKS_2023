using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public GameObject fitnessButton;
    public GameObject e0;
    public GameObject e1;
    public GameObject e2;
    public GameObject e3;
    public GameObject confirmE3;
    public GameObject e4;
    public GameObject confirmE4;
    public GameObject e5;
    int counts = 0;
    int totalCounts = 0;
    int repsCounts = 0;
    int countsPush = 0;
    int totalCountsPush = 0;
    int repsCountsPush = 0;
    public Text countText;
    public Text repsCountText;
    public Text countTextPush;
    public Text repsCountTextPush;
    public Text statsText;

    // Start is called before the first frame update

    //set only the needed elements active upon start
    void Start()
    {
        e0.SetActive(true);
        e1.SetActive(false);
        e2.SetActive(false);
        e3.SetActive(false);
        confirmE3.SetActive(false);
        e4.SetActive(false);
        confirmE4.SetActive(false);
        e5.SetActive(false);
    }

    //button function
    public void continueToE1()
    {
        e0.SetActive(false);
        e1.SetActive(true);
        e2.SetActive(false);
        e3.SetActive(false);
    }

    public void continueToE2()
    {
        e0.SetActive(false);
        e1.SetActive(false);
        e2.SetActive(true);
        e3.SetActive(false);
    }

    public void continueToE3()
    {
        e0.SetActive(false);
        e1.SetActive(false);
        e2.SetActive(false);
        e3.SetActive(true);
    }

    public void confirmE3Function()
    {
        e3.SetActive(false);
        confirmE3.SetActive(true);
    }

    public void continueToE4()
    {
        confirmE3.SetActive(false);
        e4.SetActive(true);
    }

    public void confirmE4Function()
    {
        e4.SetActive(false);
        confirmE4.SetActive(true);
    }

    public void continueToE5()
    {
        confirmE4.SetActive(false);
        e5.SetActive(true);
    }
    public void goToCardioScene()
    {
        SceneManager.LoadScene("Cardio");
    }

    public void goToStrengthScene()
    {
        SceneManager.LoadScene("Strength");
    }

    public void homeButton()
    {
        SceneManager.LoadScene("Fitness App");
    }


    //counting functions start
    public void counter()
    {
        counts += 1;
        countText.text = counts.ToString();
    }

    public void repsCounter()
    {
       // totalCounts += counts;
        repsCounts += 1;
        repsCountText.text = repsCounts.ToString();
    }

    public void countPush()
    {
        countsPush += 1;
        countTextPush.text = countsPush.ToString();
    }

    public void repsPushCounter()
    {
        //totalCountsPush += countsPush;
        repsCountsPush += 1;
        repsCountTextPush.text = repsCountsPush.ToString();
    }
    //end counting and display the results
    public void displayStats()
    {
        statsText.text = "\n" + counts.ToString() + "\n" + repsCounts.ToString() + "\n\n\n" + countsPush.ToString() + "\n" + repsCountsPush.ToString();
    }
}