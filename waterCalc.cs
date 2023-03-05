using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterCalc : MonoBehaviour
{

    public InputField inputField1;
    public InputField inputField2;
    public Text resultText;

    public void Add()
    {
        // get the values of the input fields and convert them to floats
        float num1 = float.Parse(inputField1.text); //weight
        float num2 = float.Parse(inputField2.text); //duration

        // add the numbers and display the result
        float result = num1 / 2 / num2 / 60; //formula
        resultText.text = result.ToString() + "oz";
    }
}
