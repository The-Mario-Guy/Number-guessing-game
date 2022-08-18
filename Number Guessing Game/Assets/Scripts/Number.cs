using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{   
    private int guess = 5;
    private int minValue = 1;
    private int maxValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to our Number Guessing game!");
        Debug.Log("The range of numbers is between " + minValue + " and "  + maxValue );
        Debug.Log("Use the up and down arrow keys on your keyboard to guess if you think the number is higher or lower than: " + guess + "?");
        Debug.Log("Good luck and remember to have fun! (To an extent of course.)");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            guess = (maxValue + minValue) /2;
            Debug.Log("Is your number higher or lower than: " + guess + "?");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue + minValue) /2;
            Debug.Log("Is your number higher or lower than: " + guess + "?");
        }
    }
}
