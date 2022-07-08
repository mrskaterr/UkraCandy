using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimeOn = false;

    public TMP_Text TimerTxt;

    // Start is called before the first frame update
    void Start()
    {
        TimeOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -=  Time.deltaTime;
                updateTimer(TimeLeft);
            }
        }
        else
        {
            Debug.Log("Time is up");
            TimeLeft = 0;
            TimeOn = false;
        }

        
    }

    void updateTimer(float currentTime)
    {
        currentTime +=1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = minutes.ToString()+ ":" +seconds.ToString();
    }
}
