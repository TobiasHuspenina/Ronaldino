using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 60f;

    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
    }
    void FixedUpdate()
    {

        currentTime += -1 * Time.deltaTime;
        countdownText.text = Mathf.Round (currentTime) +"";
      //  Debug.Log("Time"+ )
        if (currentTime <= 10)//Change 10 to anything you want
        {
            countdownText.color = Color.red;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
             countdownText.text = "0";
            // Your Code Here
        }
    }
}