using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 60f;
    public TMP_Text score1;
    public TMP_Text score2;

    [SerializeField] TMP_Text countdownText;
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
             int num1 = int.Parse(score1.text);
        int num2 = int.Parse(score2.text);

        if (num1 > num2)
        {
            SceneManager.LoadScene(3);
        }
        else if (num2 > num1)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
        }
    }

}